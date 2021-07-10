using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Win32
{
	// Token: 0x0200000F RID: 15
	public class User
	{
		// Token: 0x06000015 RID: 21
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool TrackMouseEvent(ref Structs.TRACKMOUSEEVENT lpEventTrack);

		// Token: 0x06000016 RID: 22
		[DllImport("user32.dll")]
		public static extern short GetAsyncKeyState(int vkey);

		// Token: 0x06000017 RID: 23
		[DllImport("user32.dll")]
		public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

		// Token: 0x06000018 RID: 24
		[DllImport("user32.dll")]
		public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		// Token: 0x06000019 RID: 25
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr handle, int wMsg, int wParam, int lParam);

		// Token: 0x0600001A RID: 26
		[DllImport("user32.dll")]
		public static extern IntPtr GetWindow(IntPtr handle, uint wCmd);

		// Token: 0x0600001B RID: 27
		[DllImport("user32.dll")]
		public static extern bool SetForegroundWindow(IntPtr handle);

		// Token: 0x0600001C RID: 28
		[DllImport("user32.dll")]
		public static extern bool GetCaretPos(out Point pt);

		// Token: 0x0600001D RID: 29
		[DllImport("user32.dll")]
		public static extern bool SetCaretPos(int x, int y);

		// Token: 0x0600001E RID: 30
		[DllImport("user32.dll")]
		public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

		// Token: 0x0600001F RID: 31
		[DllImport("user32.dll", SetLastError = true)]
		public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

		// Token: 0x06000020 RID: 32
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x06000021 RID: 33
		[DllImport("user32.dll")]
		public static extern int GetDlgCtrlID(IntPtr hwndCtl);

		// Token: 0x06000022 RID: 34
		[DllImport("user32.dll")]
		public static extern int ScrollWindowEx(IntPtr hWnd, int dx, int dy, IntPtr prcScroll, IntPtr prcClip, IntPtr hrgnUpdate, IntPtr prcUpdate, uint flags);

		// Token: 0x06000023 RID: 35
		[DllImport("user32.dll")]
		public static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray)] [In] User.INPUT[] pInputs, int cbSize);

		// Token: 0x0400004D RID: 77
		public const uint INPUT_KEYBOARD = 1u;

		// Token: 0x02000010 RID: 16
		public struct INPUT
		{
			// Token: 0x17000004 RID: 4
			// (get) Token: 0x06000025 RID: 37 RVA: 0x000020E5 File Offset: 0x000002E5
			public static int Size
			{
				get
				{
					return Marshal.SizeOf(typeof(User.INPUT));
				}
			}

			// Token: 0x0400004E RID: 78
			public uint type;

			// Token: 0x0400004F RID: 79
			public User.InputUnion U;
		}

		// Token: 0x02000011 RID: 17
		[StructLayout(LayoutKind.Explicit)]
		public struct InputUnion
		{
			// Token: 0x04000050 RID: 80
			[FieldOffset(0)]
			public User.MOUSEINPUT mi;

			// Token: 0x04000051 RID: 81
			[FieldOffset(0)]
			public User.KEYBDINPUT ki;
		}

		// Token: 0x02000012 RID: 18
		public struct MOUSEINPUT
		{
			// Token: 0x04000052 RID: 82
			public int dx;

			// Token: 0x04000053 RID: 83
			public int dy;

			// Token: 0x04000054 RID: 84
			public User.MouseEventDataXButtons mouseData;

			// Token: 0x04000055 RID: 85
			public User.MOUSEEVENTF dwFlags;

			// Token: 0x04000056 RID: 86
			public uint time;

			// Token: 0x04000057 RID: 87
			public UIntPtr dwExtraInfo;
		}

		// Token: 0x02000013 RID: 19
		[Flags]
		public enum MouseEventDataXButtons : uint
		{
			// Token: 0x04000059 RID: 89
			Nothing = 0u,
			// Token: 0x0400005A RID: 90
			XBUTTON1 = 1u,
			// Token: 0x0400005B RID: 91
			XBUTTON2 = 2u
		}

		// Token: 0x02000014 RID: 20
		[Flags]
		public enum MOUSEEVENTF : uint
		{
			// Token: 0x0400005D RID: 93
			ABSOLUTE = 32768u,
			// Token: 0x0400005E RID: 94
			HWHEEL = 4096u,
			// Token: 0x0400005F RID: 95
			MOVE = 1u,
			// Token: 0x04000060 RID: 96
			MOVE_NOCOALESCE = 8192u,
			// Token: 0x04000061 RID: 97
			LEFTDOWN = 2u,
			// Token: 0x04000062 RID: 98
			LEFTUP = 4u,
			// Token: 0x04000063 RID: 99
			RIGHTDOWN = 8u,
			// Token: 0x04000064 RID: 100
			RIGHTUP = 16u,
			// Token: 0x04000065 RID: 101
			MIDDLEDOWN = 32u,
			// Token: 0x04000066 RID: 102
			MIDDLEUP = 64u,
			// Token: 0x04000067 RID: 103
			VIRTUALDESK = 16384u,
			// Token: 0x04000068 RID: 104
			WHEEL = 2048u,
			// Token: 0x04000069 RID: 105
			XDOWN = 128u,
			// Token: 0x0400006A RID: 106
			XUP = 256u
		}

		// Token: 0x02000015 RID: 21
		public struct KEYBDINPUT
		{
			// Token: 0x0400006B RID: 107
			public User.VirtualKeyShort wVk;

			// Token: 0x0400006C RID: 108
			public User.ScanCodeShort wScan;

			// Token: 0x0400006D RID: 109
			public User.KEYEVENTF dwFlags;

			// Token: 0x0400006E RID: 110
			public int time;

			// Token: 0x0400006F RID: 111
			public UIntPtr dwExtraInfo;
		}

		// Token: 0x02000016 RID: 22
		[Flags]
		public enum KEYEVENTF : uint
		{
			// Token: 0x04000071 RID: 113
			EXTENDEDKEY = 1u,
			// Token: 0x04000072 RID: 114
			KEYUP = 2u,
			// Token: 0x04000073 RID: 115
			SCANCODE = 8u,
			// Token: 0x04000074 RID: 116
			UNICODE = 4u
		}

		// Token: 0x02000017 RID: 23
		public enum VirtualKeyShort : short
		{
			// Token: 0x04000076 RID: 118
			LBUTTON = 1,
			// Token: 0x04000077 RID: 119
			RBUTTON,
			// Token: 0x04000078 RID: 120
			CANCEL,
			// Token: 0x04000079 RID: 121
			MBUTTON,
			// Token: 0x0400007A RID: 122
			XBUTTON1,
			// Token: 0x0400007B RID: 123
			XBUTTON2,
			// Token: 0x0400007C RID: 124
			BACK = 8,
			// Token: 0x0400007D RID: 125
			TAB,
			// Token: 0x0400007E RID: 126
			CLEAR = 12,
			// Token: 0x0400007F RID: 127
			RETURN,
			// Token: 0x04000080 RID: 128
			SHIFT = 16,
			// Token: 0x04000081 RID: 129
			CONTROL,
			// Token: 0x04000082 RID: 130
			MENU,
			// Token: 0x04000083 RID: 131
			PAUSE,
			// Token: 0x04000084 RID: 132
			CAPITAL,
			// Token: 0x04000085 RID: 133
			KANA,
			// Token: 0x04000086 RID: 134
			HANGUL = 21,
			// Token: 0x04000087 RID: 135
			JUNJA = 23,
			// Token: 0x04000088 RID: 136
			FINAL,
			// Token: 0x04000089 RID: 137
			HANJA,
			// Token: 0x0400008A RID: 138
			KANJI = 25,
			// Token: 0x0400008B RID: 139
			ESCAPE = 27,
			// Token: 0x0400008C RID: 140
			CONVERT,
			// Token: 0x0400008D RID: 141
			NONCONVERT,
			// Token: 0x0400008E RID: 142
			ACCEPT,
			// Token: 0x0400008F RID: 143
			MODECHANGE,
			// Token: 0x04000090 RID: 144
			SPACE,
			// Token: 0x04000091 RID: 145
			PRIOR,
			// Token: 0x04000092 RID: 146
			NEXT,
			// Token: 0x04000093 RID: 147
			END,
			// Token: 0x04000094 RID: 148
			HOME,
			// Token: 0x04000095 RID: 149
			LEFT,
			// Token: 0x04000096 RID: 150
			UP,
			// Token: 0x04000097 RID: 151
			RIGHT,
			// Token: 0x04000098 RID: 152
			DOWN,
			// Token: 0x04000099 RID: 153
			SELECT,
			// Token: 0x0400009A RID: 154
			PRINT,
			// Token: 0x0400009B RID: 155
			EXECUTE,
			// Token: 0x0400009C RID: 156
			SNAPSHOT,
			// Token: 0x0400009D RID: 157
			INSERT,
			// Token: 0x0400009E RID: 158
			DELETE,
			// Token: 0x0400009F RID: 159
			HELP,
			// Token: 0x040000A0 RID: 160
			KEY_0,
			// Token: 0x040000A1 RID: 161
			KEY_1,
			// Token: 0x040000A2 RID: 162
			KEY_2,
			// Token: 0x040000A3 RID: 163
			KEY_3,
			// Token: 0x040000A4 RID: 164
			KEY_4,
			// Token: 0x040000A5 RID: 165
			KEY_5,
			// Token: 0x040000A6 RID: 166
			KEY_6,
			// Token: 0x040000A7 RID: 167
			KEY_7,
			// Token: 0x040000A8 RID: 168
			KEY_8,
			// Token: 0x040000A9 RID: 169
			KEY_9,
			// Token: 0x040000AA RID: 170
			KEY_A = 65,
			// Token: 0x040000AB RID: 171
			KEY_B,
			// Token: 0x040000AC RID: 172
			KEY_C,
			// Token: 0x040000AD RID: 173
			KEY_D,
			// Token: 0x040000AE RID: 174
			KEY_E,
			// Token: 0x040000AF RID: 175
			KEY_F,
			// Token: 0x040000B0 RID: 176
			KEY_G,
			// Token: 0x040000B1 RID: 177
			KEY_H,
			// Token: 0x040000B2 RID: 178
			KEY_I,
			// Token: 0x040000B3 RID: 179
			KEY_J,
			// Token: 0x040000B4 RID: 180
			KEY_K,
			// Token: 0x040000B5 RID: 181
			KEY_L,
			// Token: 0x040000B6 RID: 182
			KEY_M,
			// Token: 0x040000B7 RID: 183
			KEY_N,
			// Token: 0x040000B8 RID: 184
			KEY_O,
			// Token: 0x040000B9 RID: 185
			KEY_P,
			// Token: 0x040000BA RID: 186
			KEY_Q,
			// Token: 0x040000BB RID: 187
			KEY_R,
			// Token: 0x040000BC RID: 188
			KEY_S,
			// Token: 0x040000BD RID: 189
			KEY_T,
			// Token: 0x040000BE RID: 190
			KEY_U,
			// Token: 0x040000BF RID: 191
			KEY_V,
			// Token: 0x040000C0 RID: 192
			KEY_W,
			// Token: 0x040000C1 RID: 193
			KEY_X,
			// Token: 0x040000C2 RID: 194
			KEY_Y,
			// Token: 0x040000C3 RID: 195
			KEY_Z,
			// Token: 0x040000C4 RID: 196
			LWIN,
			// Token: 0x040000C5 RID: 197
			RWIN,
			// Token: 0x040000C6 RID: 198
			APPS,
			// Token: 0x040000C7 RID: 199
			SLEEP = 95,
			// Token: 0x040000C8 RID: 200
			NUMPAD0,
			// Token: 0x040000C9 RID: 201
			NUMPAD1,
			// Token: 0x040000CA RID: 202
			NUMPAD2,
			// Token: 0x040000CB RID: 203
			NUMPAD3,
			// Token: 0x040000CC RID: 204
			NUMPAD4,
			// Token: 0x040000CD RID: 205
			NUMPAD5,
			// Token: 0x040000CE RID: 206
			NUMPAD6,
			// Token: 0x040000CF RID: 207
			NUMPAD7,
			// Token: 0x040000D0 RID: 208
			NUMPAD8,
			// Token: 0x040000D1 RID: 209
			NUMPAD9,
			// Token: 0x040000D2 RID: 210
			MULTIPLY,
			// Token: 0x040000D3 RID: 211
			ADD,
			// Token: 0x040000D4 RID: 212
			SEPARATOR,
			// Token: 0x040000D5 RID: 213
			SUBTRACT,
			// Token: 0x040000D6 RID: 214
			DECIMAL,
			// Token: 0x040000D7 RID: 215
			DIVIDE,
			// Token: 0x040000D8 RID: 216
			F1,
			// Token: 0x040000D9 RID: 217
			F2,
			// Token: 0x040000DA RID: 218
			F3,
			// Token: 0x040000DB RID: 219
			F4,
			// Token: 0x040000DC RID: 220
			F5,
			// Token: 0x040000DD RID: 221
			F6,
			// Token: 0x040000DE RID: 222
			F7,
			// Token: 0x040000DF RID: 223
			F8,
			// Token: 0x040000E0 RID: 224
			F9,
			// Token: 0x040000E1 RID: 225
			F10,
			// Token: 0x040000E2 RID: 226
			F11,
			// Token: 0x040000E3 RID: 227
			F12,
			// Token: 0x040000E4 RID: 228
			F13,
			// Token: 0x040000E5 RID: 229
			F14,
			// Token: 0x040000E6 RID: 230
			F15,
			// Token: 0x040000E7 RID: 231
			F16,
			// Token: 0x040000E8 RID: 232
			F17,
			// Token: 0x040000E9 RID: 233
			F18,
			// Token: 0x040000EA RID: 234
			F19,
			// Token: 0x040000EB RID: 235
			F20,
			// Token: 0x040000EC RID: 236
			F21,
			// Token: 0x040000ED RID: 237
			F22,
			// Token: 0x040000EE RID: 238
			F23,
			// Token: 0x040000EF RID: 239
			F24,
			// Token: 0x040000F0 RID: 240
			NUMLOCK = 144,
			// Token: 0x040000F1 RID: 241
			SCROLL,
			// Token: 0x040000F2 RID: 242
			LSHIFT = 160,
			// Token: 0x040000F3 RID: 243
			RSHIFT,
			// Token: 0x040000F4 RID: 244
			LCONTROL,
			// Token: 0x040000F5 RID: 245
			RCONTROL,
			// Token: 0x040000F6 RID: 246
			LMENU,
			// Token: 0x040000F7 RID: 247
			RMENU,
			// Token: 0x040000F8 RID: 248
			BROWSER_BACK,
			// Token: 0x040000F9 RID: 249
			BROWSER_FORWARD,
			// Token: 0x040000FA RID: 250
			BROWSER_REFRESH,
			// Token: 0x040000FB RID: 251
			BROWSER_STOP,
			// Token: 0x040000FC RID: 252
			BROWSER_SEARCH,
			// Token: 0x040000FD RID: 253
			BROWSER_FAVORITES,
			// Token: 0x040000FE RID: 254
			BROWSER_HOME,
			// Token: 0x040000FF RID: 255
			VOLUME_MUTE,
			// Token: 0x04000100 RID: 256
			VOLUME_DOWN,
			// Token: 0x04000101 RID: 257
			VOLUME_UP,
			// Token: 0x04000102 RID: 258
			MEDIA_NEXT_TRACK,
			// Token: 0x04000103 RID: 259
			MEDIA_PREV_TRACK,
			// Token: 0x04000104 RID: 260
			MEDIA_STOP,
			// Token: 0x04000105 RID: 261
			MEDIA_PLAY_PAUSE,
			// Token: 0x04000106 RID: 262
			LAUNCH_MAIL,
			// Token: 0x04000107 RID: 263
			LAUNCH_MEDIA_SELECT,
			// Token: 0x04000108 RID: 264
			LAUNCH_APP1,
			// Token: 0x04000109 RID: 265
			LAUNCH_APP2,
			// Token: 0x0400010A RID: 266
			OEM_1 = 186,
			// Token: 0x0400010B RID: 267
			OEM_PLUS,
			// Token: 0x0400010C RID: 268
			OEM_COMMA,
			// Token: 0x0400010D RID: 269
			OEM_MINUS,
			// Token: 0x0400010E RID: 270
			OEM_PERIOD,
			// Token: 0x0400010F RID: 271
			OEM_2,
			// Token: 0x04000110 RID: 272
			OEM_3,
			// Token: 0x04000111 RID: 273
			OEM_4 = 219,
			// Token: 0x04000112 RID: 274
			OEM_5,
			// Token: 0x04000113 RID: 275
			OEM_6,
			// Token: 0x04000114 RID: 276
			OEM_7,
			// Token: 0x04000115 RID: 277
			OEM_8,
			// Token: 0x04000116 RID: 278
			OEM_102 = 226,
			// Token: 0x04000117 RID: 279
			PROCESSKEY = 229,
			// Token: 0x04000118 RID: 280
			PACKET = 231,
			// Token: 0x04000119 RID: 281
			ATTN = 246,
			// Token: 0x0400011A RID: 282
			CRSEL,
			// Token: 0x0400011B RID: 283
			EXSEL,
			// Token: 0x0400011C RID: 284
			EREOF,
			// Token: 0x0400011D RID: 285
			PLAY,
			// Token: 0x0400011E RID: 286
			ZOOM,
			// Token: 0x0400011F RID: 287
			NONAME,
			// Token: 0x04000120 RID: 288
			PA1,
			// Token: 0x04000121 RID: 289
			OEM_CLEAR
		}

		// Token: 0x02000018 RID: 24
		public enum ScanCodeShort : short
		{
			// Token: 0x04000123 RID: 291
			LBUTTON,
			// Token: 0x04000124 RID: 292
			RBUTTON = 0,
			// Token: 0x04000125 RID: 293
			CANCEL = 70,
			// Token: 0x04000126 RID: 294
			MBUTTON = 0,
			// Token: 0x04000127 RID: 295
			XBUTTON1 = 0,
			// Token: 0x04000128 RID: 296
			XBUTTON2 = 0,
			// Token: 0x04000129 RID: 297
			BACK = 14,
			// Token: 0x0400012A RID: 298
			TAB,
			// Token: 0x0400012B RID: 299
			CLEAR = 76,
			// Token: 0x0400012C RID: 300
			RETURN = 28,
			// Token: 0x0400012D RID: 301
			SHIFT = 42,
			// Token: 0x0400012E RID: 302
			CONTROL = 29,
			// Token: 0x0400012F RID: 303
			MENU = 56,
			// Token: 0x04000130 RID: 304
			PAUSE = 0,
			// Token: 0x04000131 RID: 305
			CAPITAL = 58,
			// Token: 0x04000132 RID: 306
			KANA = 0,
			// Token: 0x04000133 RID: 307
			HANGUL = 0,
			// Token: 0x04000134 RID: 308
			JUNJA = 0,
			// Token: 0x04000135 RID: 309
			FINAL = 0,
			// Token: 0x04000136 RID: 310
			HANJA = 0,
			// Token: 0x04000137 RID: 311
			KANJI = 0,
			// Token: 0x04000138 RID: 312
			ESCAPE,
			// Token: 0x04000139 RID: 313
			CONVERT = 0,
			// Token: 0x0400013A RID: 314
			NONCONVERT = 0,
			// Token: 0x0400013B RID: 315
			ACCEPT = 0,
			// Token: 0x0400013C RID: 316
			MODECHANGE = 0,
			// Token: 0x0400013D RID: 317
			SPACE = 57,
			// Token: 0x0400013E RID: 318
			PRIOR = 73,
			// Token: 0x0400013F RID: 319
			NEXT = 81,
			// Token: 0x04000140 RID: 320
			END = 79,
			// Token: 0x04000141 RID: 321
			HOME = 71,
			// Token: 0x04000142 RID: 322
			LEFT = 75,
			// Token: 0x04000143 RID: 323
			UP = 72,
			// Token: 0x04000144 RID: 324
			RIGHT = 77,
			// Token: 0x04000145 RID: 325
			DOWN = 80,
			// Token: 0x04000146 RID: 326
			SELECT = 0,
			// Token: 0x04000147 RID: 327
			PRINT = 0,
			// Token: 0x04000148 RID: 328
			EXECUTE = 0,
			// Token: 0x04000149 RID: 329
			SNAPSHOT = 84,
			// Token: 0x0400014A RID: 330
			INSERT = 82,
			// Token: 0x0400014B RID: 331
			DELETE,
			// Token: 0x0400014C RID: 332
			HELP = 99,
			// Token: 0x0400014D RID: 333
			KEY_0 = 11,
			// Token: 0x0400014E RID: 334
			KEY_1 = 2,
			// Token: 0x0400014F RID: 335
			KEY_2,
			// Token: 0x04000150 RID: 336
			KEY_3,
			// Token: 0x04000151 RID: 337
			KEY_4,
			// Token: 0x04000152 RID: 338
			KEY_5,
			// Token: 0x04000153 RID: 339
			KEY_6,
			// Token: 0x04000154 RID: 340
			KEY_7,
			// Token: 0x04000155 RID: 341
			KEY_8,
			// Token: 0x04000156 RID: 342
			KEY_9,
			// Token: 0x04000157 RID: 343
			KEY_A = 30,
			// Token: 0x04000158 RID: 344
			KEY_B = 48,
			// Token: 0x04000159 RID: 345
			KEY_C = 46,
			// Token: 0x0400015A RID: 346
			KEY_D = 32,
			// Token: 0x0400015B RID: 347
			KEY_E = 18,
			// Token: 0x0400015C RID: 348
			KEY_F = 33,
			// Token: 0x0400015D RID: 349
			KEY_G,
			// Token: 0x0400015E RID: 350
			KEY_H,
			// Token: 0x0400015F RID: 351
			KEY_I = 23,
			// Token: 0x04000160 RID: 352
			KEY_J = 36,
			// Token: 0x04000161 RID: 353
			KEY_K,
			// Token: 0x04000162 RID: 354
			KEY_L,
			// Token: 0x04000163 RID: 355
			KEY_M = 50,
			// Token: 0x04000164 RID: 356
			KEY_N = 49,
			// Token: 0x04000165 RID: 357
			KEY_O = 24,
			// Token: 0x04000166 RID: 358
			KEY_P,
			// Token: 0x04000167 RID: 359
			KEY_Q = 16,
			// Token: 0x04000168 RID: 360
			KEY_R = 19,
			// Token: 0x04000169 RID: 361
			KEY_S = 31,
			// Token: 0x0400016A RID: 362
			KEY_T = 20,
			// Token: 0x0400016B RID: 363
			KEY_U = 22,
			// Token: 0x0400016C RID: 364
			KEY_V = 47,
			// Token: 0x0400016D RID: 365
			KEY_W = 17,
			// Token: 0x0400016E RID: 366
			KEY_X = 45,
			// Token: 0x0400016F RID: 367
			KEY_Y = 21,
			// Token: 0x04000170 RID: 368
			KEY_Z = 44,
			// Token: 0x04000171 RID: 369
			LWIN = 91,
			// Token: 0x04000172 RID: 370
			RWIN,
			// Token: 0x04000173 RID: 371
			APPS,
			// Token: 0x04000174 RID: 372
			SLEEP = 95,
			// Token: 0x04000175 RID: 373
			NUMPAD0 = 82,
			// Token: 0x04000176 RID: 374
			NUMPAD1 = 79,
			// Token: 0x04000177 RID: 375
			NUMPAD2,
			// Token: 0x04000178 RID: 376
			NUMPAD3,
			// Token: 0x04000179 RID: 377
			NUMPAD4 = 75,
			// Token: 0x0400017A RID: 378
			NUMPAD5,
			// Token: 0x0400017B RID: 379
			NUMPAD6,
			// Token: 0x0400017C RID: 380
			NUMPAD7 = 71,
			// Token: 0x0400017D RID: 381
			NUMPAD8,
			// Token: 0x0400017E RID: 382
			NUMPAD9,
			// Token: 0x0400017F RID: 383
			MULTIPLY = 55,
			// Token: 0x04000180 RID: 384
			ADD = 78,
			// Token: 0x04000181 RID: 385
			SEPARATOR = 0,
			// Token: 0x04000182 RID: 386
			SUBTRACT = 74,
			// Token: 0x04000183 RID: 387
			DECIMAL = 83,
			// Token: 0x04000184 RID: 388
			DIVIDE = 53,
			// Token: 0x04000185 RID: 389
			F1 = 59,
			// Token: 0x04000186 RID: 390
			F2,
			// Token: 0x04000187 RID: 391
			F3,
			// Token: 0x04000188 RID: 392
			F4,
			// Token: 0x04000189 RID: 393
			F5,
			// Token: 0x0400018A RID: 394
			F6,
			// Token: 0x0400018B RID: 395
			F7,
			// Token: 0x0400018C RID: 396
			F8,
			// Token: 0x0400018D RID: 397
			F9,
			// Token: 0x0400018E RID: 398
			F10,
			// Token: 0x0400018F RID: 399
			F11 = 87,
			// Token: 0x04000190 RID: 400
			F12,
			// Token: 0x04000191 RID: 401
			F13 = 100,
			// Token: 0x04000192 RID: 402
			F14,
			// Token: 0x04000193 RID: 403
			F15,
			// Token: 0x04000194 RID: 404
			F16,
			// Token: 0x04000195 RID: 405
			F17,
			// Token: 0x04000196 RID: 406
			F18,
			// Token: 0x04000197 RID: 407
			F19,
			// Token: 0x04000198 RID: 408
			F20,
			// Token: 0x04000199 RID: 409
			F21,
			// Token: 0x0400019A RID: 410
			F22,
			// Token: 0x0400019B RID: 411
			F23,
			// Token: 0x0400019C RID: 412
			F24 = 118,
			// Token: 0x0400019D RID: 413
			NUMLOCK = 69,
			// Token: 0x0400019E RID: 414
			SCROLL,
			// Token: 0x0400019F RID: 415
			LSHIFT = 42,
			// Token: 0x040001A0 RID: 416
			RSHIFT = 54,
			// Token: 0x040001A1 RID: 417
			LCONTROL = 29,
			// Token: 0x040001A2 RID: 418
			RCONTROL = 29,
			// Token: 0x040001A3 RID: 419
			LMENU = 56,
			// Token: 0x040001A4 RID: 420
			RMENU = 56,
			// Token: 0x040001A5 RID: 421
			BROWSER_BACK = 106,
			// Token: 0x040001A6 RID: 422
			BROWSER_FORWARD = 105,
			// Token: 0x040001A7 RID: 423
			BROWSER_REFRESH = 103,
			// Token: 0x040001A8 RID: 424
			BROWSER_STOP,
			// Token: 0x040001A9 RID: 425
			BROWSER_SEARCH = 101,
			// Token: 0x040001AA RID: 426
			BROWSER_FAVORITES,
			// Token: 0x040001AB RID: 427
			BROWSER_HOME = 50,
			// Token: 0x040001AC RID: 428
			VOLUME_MUTE = 32,
			// Token: 0x040001AD RID: 429
			VOLUME_DOWN = 46,
			// Token: 0x040001AE RID: 430
			VOLUME_UP = 48,
			// Token: 0x040001AF RID: 431
			MEDIA_NEXT_TRACK = 25,
			// Token: 0x040001B0 RID: 432
			MEDIA_PREV_TRACK = 16,
			// Token: 0x040001B1 RID: 433
			MEDIA_STOP = 36,
			// Token: 0x040001B2 RID: 434
			MEDIA_PLAY_PAUSE = 34,
			// Token: 0x040001B3 RID: 435
			LAUNCH_MAIL = 108,
			// Token: 0x040001B4 RID: 436
			LAUNCH_MEDIA_SELECT,
			// Token: 0x040001B5 RID: 437
			LAUNCH_APP1 = 107,
			// Token: 0x040001B6 RID: 438
			LAUNCH_APP2 = 33,
			// Token: 0x040001B7 RID: 439
			OEM_1 = 39,
			// Token: 0x040001B8 RID: 440
			OEM_PLUS = 13,
			// Token: 0x040001B9 RID: 441
			OEM_COMMA = 51,
			// Token: 0x040001BA RID: 442
			OEM_MINUS = 12,
			// Token: 0x040001BB RID: 443
			OEM_PERIOD = 52,
			// Token: 0x040001BC RID: 444
			OEM_2,
			// Token: 0x040001BD RID: 445
			OEM_3 = 41,
			// Token: 0x040001BE RID: 446
			OEM_4 = 26,
			// Token: 0x040001BF RID: 447
			OEM_5 = 43,
			// Token: 0x040001C0 RID: 448
			OEM_6 = 27,
			// Token: 0x040001C1 RID: 449
			OEM_7 = 40,
			// Token: 0x040001C2 RID: 450
			OEM_8 = 0,
			// Token: 0x040001C3 RID: 451
			OEM_102 = 86,
			// Token: 0x040001C4 RID: 452
			PROCESSKEY = 0,
			// Token: 0x040001C5 RID: 453
			PACKET = 0,
			// Token: 0x040001C6 RID: 454
			ATTN = 0,
			// Token: 0x040001C7 RID: 455
			CRSEL = 0,
			// Token: 0x040001C8 RID: 456
			EXSEL = 0,
			// Token: 0x040001C9 RID: 457
			EREOF = 93,
			// Token: 0x040001CA RID: 458
			PLAY = 0,
			// Token: 0x040001CB RID: 459
			ZOOM = 98,
			// Token: 0x040001CC RID: 460
			NONAME = 0,
			// Token: 0x040001CD RID: 461
			PA1 = 0,
			// Token: 0x040001CE RID: 462
			OEM_CLEAR = 0
		}
	}
}
