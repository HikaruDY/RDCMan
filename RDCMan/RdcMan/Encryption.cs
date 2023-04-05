using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using Win32;

namespace RdcMan
{
	public static class Encryption
	{
		public static void DeferDecryption(IDeferDecryption o, RdcTreeNode node, string errorDetail)
		{
			Encryption.PendingDecryption.Add(new DeferDecryptionItem
			{
				Object = o,
				Node = node,
				ErrorDetail = errorDetail
			});
		}

		public static void DecryptPasswords()
		{
			StringBuilder builder = new StringBuilder("There were problems decrypting some credentials.").AppendLine().AppendLine("Click OK to copy the details to the clipboard.");
			bool credentialsProfileFail = false;
			(from d in Encryption.PendingDecryption
			where d.Object is CredentialsProfile
			select d).ForEach(delegate(DeferDecryptionItem item)
			{
				Encryption.DecryptPassword(item, builder, "Credentials profiles:", ref credentialsProfileFail);
			});
			bool passwordFail = false;
			(from d in Encryption.PendingDecryption
			where d.Object is PasswordSetting
			select d).ForEach(delegate(DeferDecryptionItem item)
			{
				Encryption.DecryptPassword(item, builder, "Custom passwords:", ref passwordFail);
			});
			Encryption.PendingDecryption.Clear();
			if (credentialsProfileFail | passwordFail)
			{
				DialogResult dialogResult = FormTools.ExclamationDialog(builder.ToString(), MessageBoxButtons.OKCancel);
				if (dialogResult == DialogResult.OK)
				{
					Clipboard.SetText(builder.ToString());
				}
			}
		}

		private static bool DecryptPassword(DeferDecryptionItem item, StringBuilder builder, string header, ref bool anyFailed)
		{
			IDeferDecryption @object = item.Object;
			RdcTreeNode node = item.Node;
			string errorDetail = item.ErrorDetail;
			bool flag = false;
			node.EncryptionSettings.InheritSettings(node, ref flag);
			try
			{
				@object.Decrypt(node.EncryptionSettings);
			}
			catch (Exception ex)
			{
				if (!anyFailed)
				{
					builder.AppendLine().AppendLine(header);
					anyFailed = true;
				}
				if (node is DefaultSettingsGroup)
				{
					builder.Append("Default settings group");
				}
				else
				{
					builder.Append(node.FullPath);
				}
				builder.AppendFormat(": {0}", errorDetail);
				if (!string.IsNullOrEmpty(ex.Message))
				{
					builder.AppendFormat(" [{0}]", ex.Message);
				}
				builder.AppendLine();
			}
			return anyFailed;
		}

		public static string SimpleName(this X509Certificate2 cert)
		{
			string text = cert.FriendlyName;
			if (string.IsNullOrEmpty(text))
			{
				text = cert.GetNameInfo(X509NameType.SimpleName, false);
			}
			return text + ", " + cert.GetNameInfo(X509NameType.SimpleName, true);
		}

		public static string EncryptionMethodToString(EncryptionMethod method)
		{
			if (method == EncryptionMethod.LogonCredentials)
			{
				return "Logged on user's credentials";
			}
			if (method == EncryptionMethod.Certificate)
			{
				return "Certificate";
			}
			throw new Exception("Unexpected EncryptionMethod");
		}

		public static X509Certificate2 SelectCertificate()
		{
			X509Store x509Store = new X509Store();
			X509Certificate2Collection privateCollection = new X509Certificate2Collection();
			try
			{
				x509Store.Open(OpenFlags.OpenExistingOnly);
				X509Certificate2Collection certificates = x509Store.Certificates;
				X509Certificate2Collection foundCollection = certificates.Find(X509FindType.FindByTimeValid, DateTime.Now, false);
				LongRunningActionForm.PerformOperation("Checking valid certificates", true, delegate
				{
					foreach (X509Certificate2 x509Certificate in foundCollection)
					{
						try
						{
							if (Encryption.DecryptStringUsingCertificate(x509Certificate, Encryption.EncryptStringUsingCertificate(x509Certificate, "test")) == "test")
							{
								privateCollection.Add(x509Certificate);
							}
						}
						catch
						{
						}
						LongRunningActionForm.Instance.UpdateStatus(x509Certificate.SimpleName());
					}
				});
			}
			finally
			{
				x509Store.Close();
			}
			X509Certificate2Collection x509Certificate2Collection = X509Certificate2UI.SelectFromCollection(privateCollection, "Select Certificate", "Select a certificate for secure password storage", X509SelectionFlag.SingleSelection, Program.TheForm.Handle);
			if (x509Certificate2Collection.Count != 1)
			{
				return null;
			}
			return x509Certificate2Collection[0];
		}

		public static X509Certificate2 GetCertificate(string thumbprint)
		{
			X509Store x509Store = new X509Store();
			x509Store.Open(OpenFlags.OpenExistingOnly);
			X509Certificate2Collection certificates = x509Store.Certificates;
			X509Certificate2Collection x509Certificate2Collection = certificates.Find(X509FindType.FindByThumbprint, thumbprint, false);
			if (x509Certificate2Collection.Count != 1)
			{
				return null;
			}
			return x509Certificate2Collection[0];
		}

		public static string EncryptString(string plaintext, EncryptionSettings settings)
		{
			EncryptionMethod value = settings.EncryptionMethod.Value;
			if (value == EncryptionMethod.LogonCredentials)
			{
				return Encryption.EncryptStringUsingLocalUser(plaintext);
			}
			if (value != EncryptionMethod.Certificate)
			{
				throw new NotImplementedException("Unexpected encryption method '{0}'".InvariantFormat(new object[]
				{
					settings.EncryptionMethod.Value.ToString()
				}));
			}
			X509Certificate2 certificate = Encryption.GetCertificate(settings.CredentialData.Value);
			return Encryption.EncryptStringUsingCertificate(certificate, plaintext);
		}

		private unsafe static string EncryptStringUsingLocalUser(string plaintext)
		{
			Crypto.DataBlob dataBlob = default(Crypto.DataBlob);
			Crypto.CryptProtectPromptStruct cryptProtectPromptStruct = default(Crypto.CryptProtectPromptStruct);
			if (string.IsNullOrEmpty(plaintext))
			{
				return null;
			}
			dataBlob.Size = 0;
			cryptProtectPromptStruct.Size = 0;
			char[] array = plaintext.ToCharArray();
			Crypto.DataBlob dataBlob2;
			dataBlob2.Size = array.Length * 2;
			char[] array2;
			char* value;
			if ((array2 = array) == null || array2.Length == 0)
			{
				value = null;
			}
			else
			{
				value = &array2[0];
			}
			dataBlob2.Data = (IntPtr)((void*)value);
			Crypto.DataBlob dataBlob3;
			if (!Crypto.CryptProtectData(ref dataBlob2, null, ref dataBlob, (IntPtr)null, ref cryptProtectPromptStruct, 0, out dataBlob3))
			{
				FormTools.ErrorDialog("Unable to encrypt password");
				return null;
			}
			array2 = null;
			byte* ptr = (byte*)((void*)dataBlob3.Data);
			byte[] array3 = new byte[dataBlob3.Size];
			for (int i = 0; i < array3.Length; i++)
			{
				array3[i] = ptr[i];
			}
			string result = Convert.ToBase64String(array3);
			Crypto.LocalFree(dataBlob3.Data);
			return result;
		}

		private static string EncryptStringUsingCertificate(X509Certificate2 cert, string plaintext)
		{
			RSACryptoServiceProvider rsacryptoServiceProvider = (RSACryptoServiceProvider)cert.PublicKey.Key;
			byte[] inArray = rsacryptoServiceProvider.Encrypt(Encoding.UTF8.GetBytes(plaintext), false);
			return Convert.ToBase64String(inArray);
		}

		public static string DecryptString(string encryptedString, EncryptionSettings settings)
		{
			if (string.IsNullOrEmpty(encryptedString))
			{
				return encryptedString;
			}
			EncryptionMethod value = settings.EncryptionMethod.Value;
			string result;
			if (value != EncryptionMethod.LogonCredentials)
			{
				if (value != EncryptionMethod.Certificate)
				{
					throw new NotImplementedException("Unexpected encryption method '{0}'".InvariantFormat(new object[]
					{
						settings.EncryptionMethod.Value.ToString()
					}));
				}
				X509Certificate2 certificate = Encryption.GetCertificate(settings.CredentialData.Value);
				if (certificate == null)
				{
					throw new Exception("Certificate '{0}' with thumbprint '{1}' not found".InvariantFormat(new object[]
					{
						settings.CredentialName.Value,
						settings.CredentialData.Value
					}));
				}
				result = Encryption.DecryptStringUsingCertificate(certificate, encryptedString);
			}
			else
			{
				result = Encryption.DecryptStringUsingLocalUser(encryptedString);
			}
			return result;
		}

		private unsafe static string DecryptStringUsingLocalUser(string encryptedString)
		{
			Crypto.DataBlob dataBlob = default(Crypto.DataBlob);
			Crypto.CryptProtectPromptStruct cryptProtectPromptStruct = default(Crypto.CryptProtectPromptStruct);
			if (string.IsNullOrEmpty(encryptedString))
			{
				return string.Empty;
			}
			dataBlob.Size = 0;
			cryptProtectPromptStruct.Size = 0;
			byte[] array = Convert.FromBase64String(encryptedString);
			Crypto.DataBlob dataBlob2;
			dataBlob2.Size = array.Length;
			byte[] array2;
			byte* value;
			if ((array2 = array) == null || array2.Length == 0)
			{
				value = null;
			}
			else
			{
				value = &array2[0];
			}
			dataBlob2.Data = (IntPtr)((void*)value);
			Crypto.DataBlob dataBlob3;
			if (!Crypto.CryptUnprotectData(ref dataBlob2, null, ref dataBlob, (IntPtr)null, ref cryptProtectPromptStruct, 0, out dataBlob3))
			{
				throw new Exception("Failed to decrypt using {0} credential".InvariantFormat(new object[]
				{
					CredentialsUI.GetLoggedInUser()
				}));
			}
			char* ptr = (char*)((void*)dataBlob3.Data);
			char[] array3 = new char[dataBlob3.Size / 2];
			for (int i = 0; i < array3.Length; i++)
			{
				array3[i] = ptr[i];
			}
			string result = new string(array3);
			array2 = null;
			Crypto.LocalFree(dataBlob3.Data);
			return result;
		}

		private static string DecryptStringUsingCertificate(X509Certificate2 cert, string encryptedString)
		{
			if (string.IsNullOrEmpty(encryptedString))
			{
				return null;
			}
			RSACryptoServiceProvider rsacryptoServiceProvider = (RSACryptoServiceProvider)cert.PrivateKey;
			byte[] bytes = rsacryptoServiceProvider.Decrypt(Convert.FromBase64String(encryptedString), false);
			return Encoding.UTF8.GetString(bytes);
		}

		private static readonly List<DeferDecryptionItem> PendingDecryption = new List<DeferDecryptionItem>();
	}
}
