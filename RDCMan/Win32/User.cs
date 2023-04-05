using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Win32
{
	// Token: 0x02000008 RID: 8
	public class User
	{
		// Token: 0x06000014 RID: 20
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool TrackMouseEvent(ref Structs.TRACKMOUSEEVENT lpEventTrack);

		// Token: 0x06000015 RID: 21
		[DllImport("user32.dll")]
		public static extern short GetAsyncKeyState(int vkey);

		// Token: 0x06000016 RID: 22
		[DllImport("user32.dll")]
		public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

		// Token: 0x06000017 RID: 23
		[DllImport("user32.dll")]
		public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		// Token: 0x06000018 RID: 24
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr handle, int wMsg, int wParam, int lParam);

		// Token: 0x06000019 RID: 25
		[DllImport("user32.dll")]
		public static extern IntPtr GetWindow(IntPtr handle, uint wCmd);

		// Token: 0x0600001A RID: 26
		[DllImport("user32.dll")]
		public static extern bool SetForegroundWindow(IntPtr handle);

		// Token: 0x0600001B RID: 27
		[DllImport("user32.dll")]
		public static extern bool GetCaretPos(out Point pt);

		// Token: 0x0600001C RID: 28
		[DllImport("user32.dll")]
		public static extern bool SetCaretPos(int x, int y);

		// Token: 0x0600001D RID: 29
		[DllImport("user32.dll")]
		public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

		// Token: 0x0600001E RID: 30
		[DllImport("user32.dll", SetLastError = true)]
		public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

		// Token: 0x0600001F RID: 31
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x06000020 RID: 32
		[DllImport("user32.dll")]
		public static extern int GetDlgCtrlID(IntPtr hwndCtl);

		// Token: 0x06000021 RID: 33
		[DllImport("user32.dll")]
		public static extern int ScrollWindowEx(IntPtr hWnd, int dx, int dy, IntPtr prcScroll, IntPtr prcClip, IntPtr hrgnUpdate, IntPtr prcUpdate, uint flags);

		// Token: 0x06000022 RID: 34
		[DllImport("user32.dll")]
		public static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray)] [In] User.INPUT[] pInputs, int cbSize);

		// Token: 0x0400002C RID: 44
		public const uint INPUT_KEYBOARD = 1U;

		// Token: 0x02000221 RID: 545
		public struct INPUT
		{
			// Token: 0x17002136 RID: 8502
			// (get) Token: 0x060055AB RID: 21931 RVA: 0x0005C9AC File Offset: 0x0005ABAC
			public static int Size
			{
				get
				{
					return Marshal.SizeOf(typeof(User.INPUT));
				}
			}

			// Token: 0x0400083E RID: 2110
			public uint type;

			// Token: 0x0400083F RID: 2111
			public User.InputUnion U;
		}

		// Token: 0x02000222 RID: 546
		[StructLayout(LayoutKind.Explicit)]
		public struct InputUnion
		{
			// Token: 0x04000840 RID: 2112
			[FieldOffset(0)]
			public User.MOUSEINPUT mi;

			// Token: 0x04000841 RID: 2113
			[FieldOffset(0)]
			public User.KEYBDINPUT ki;
		}

		// Token: 0x02000223 RID: 547
		public struct MOUSEINPUT
		{
			// Token: 0x04000842 RID: 2114
			public int dx;

			// Token: 0x04000843 RID: 2115
			public int dy;

			// Token: 0x04000844 RID: 2116
			public User.MouseEventDataXButtons mouseData;

			// Token: 0x04000845 RID: 2117
			public User.MOUSEEVENTF dwFlags;

			// Token: 0x04000846 RID: 2118
			public uint time;

			// Token: 0x04000847 RID: 2119
			public UIntPtr dwExtraInfo;
		}

		// Token: 0x02000224 RID: 548
		[Flags]
		public enum MouseEventDataXButtons : uint
		{
			// Token: 0x04000849 RID: 2121
			Nothing = 0U,
			// Token: 0x0400084A RID: 2122
			XBUTTON1 = 1U,
			// Token: 0x0400084B RID: 2123
			XBUTTON2 = 2U
		}

		// Token: 0x02000225 RID: 549
		[Flags]
		public enum MOUSEEVENTF : uint
		{
			// Token: 0x0400084D RID: 2125
			ABSOLUTE = 32768U,
			// Token: 0x0400084E RID: 2126
			HWHEEL = 4096U,
			// Token: 0x0400084F RID: 2127
			MOVE = 1U,
			// Token: 0x04000850 RID: 2128
			MOVE_NOCOALESCE = 8192U,
			// Token: 0x04000851 RID: 2129
			LEFTDOWN = 2U,
			// Token: 0x04000852 RID: 2130
			LEFTUP = 4U,
			// Token: 0x04000853 RID: 2131
			RIGHTDOWN = 8U,
			// Token: 0x04000854 RID: 2132
			RIGHTUP = 16U,
			// Token: 0x04000855 RID: 2133
			MIDDLEDOWN = 32U,
			// Token: 0x04000856 RID: 2134
			MIDDLEUP = 64U,
			// Token: 0x04000857 RID: 2135
			VIRTUALDESK = 16384U,
			// Token: 0x04000858 RID: 2136
			WHEEL = 2048U,
			// Token: 0x04000859 RID: 2137
			XDOWN = 128U,
			// Token: 0x0400085A RID: 2138
			XUP = 256U
		}

		// Token: 0x02000226 RID: 550
		public struct KEYBDINPUT
		{
			// Token: 0x0400085B RID: 2139
			public User.VirtualKeyShort wVk;

			// Token: 0x0400085C RID: 2140
			public User.ScanCodeShort wScan;

			// Token: 0x0400085D RID: 2141
			public User.KEYEVENTF dwFlags;

			// Token: 0x0400085E RID: 2142
			public int time;

			// Token: 0x0400085F RID: 2143
			public UIntPtr dwExtraInfo;
		}

		// Token: 0x02000227 RID: 551
		[Flags]
		public enum KEYEVENTF : uint
		{
			// Token: 0x04000861 RID: 2145
			EXTENDEDKEY = 1U,
			// Token: 0x04000862 RID: 2146
			KEYUP = 2U,
			// Token: 0x04000863 RID: 2147
			SCANCODE = 8U,
			// Token: 0x04000864 RID: 2148
			UNICODE = 4U
		}

		// Token: 0x02000228 RID: 552
		public enum VirtualKeyShort : short
		{
			// Token: 0x04000866 RID: 2150
			LBUTTON = 1,
			// Token: 0x04000867 RID: 2151
			RBUTTON,
			// Token: 0x04000868 RID: 2152
			CANCEL,
			// Token: 0x04000869 RID: 2153
			MBUTTON,
			// Token: 0x0400086A RID: 2154
			XBUTTON1,
			// Token: 0x0400086B RID: 2155
			XBUTTON2,
			// Token: 0x0400086C RID: 2156
			BACK = 8,
			// Token: 0x0400086D RID: 2157
			TAB,
			// Token: 0x0400086E RID: 2158
			CLEAR = 12,
			// Token: 0x0400086F RID: 2159
			RETURN,
			// Token: 0x04000870 RID: 2160
			SHIFT = 16,
			// Token: 0x04000871 RID: 2161
			CONTROL,
			// Token: 0x04000872 RID: 2162
			MENU,
			// Token: 0x04000873 RID: 2163
			PAUSE,
			// Token: 0x04000874 RID: 2164
			CAPITAL,
			// Token: 0x04000875 RID: 2165
			KANA,
			// Token: 0x04000876 RID: 2166
			HANGUL = 21,
			// Token: 0x04000877 RID: 2167
			JUNJA = 23,
			// Token: 0x04000878 RID: 2168
			FINAL,
			// Token: 0x04000879 RID: 2169
			HANJA,
			// Token: 0x0400087A RID: 2170
			KANJI = 25,
			// Token: 0x0400087B RID: 2171
			ESCAPE = 27,
			// Token: 0x0400087C RID: 2172
			CONVERT,
			// Token: 0x0400087D RID: 2173
			NONCONVERT,
			// Token: 0x0400087E RID: 2174
			ACCEPT,
			// Token: 0x0400087F RID: 2175
			MODECHANGE,
			// Token: 0x04000880 RID: 2176
			SPACE,
			// Token: 0x04000881 RID: 2177
			PRIOR,
			// Token: 0x04000882 RID: 2178
			NEXT,
			// Token: 0x04000883 RID: 2179
			END,
			// Token: 0x04000884 RID: 2180
			HOME,
			// Token: 0x04000885 RID: 2181
			LEFT,
			// Token: 0x04000886 RID: 2182
			UP,
			// Token: 0x04000887 RID: 2183
			RIGHT,
			// Token: 0x04000888 RID: 2184
			DOWN,
			// Token: 0x04000889 RID: 2185
			SELECT,
			// Token: 0x0400088A RID: 2186
			PRINT,
			// Token: 0x0400088B RID: 2187
			EXECUTE,
			// Token: 0x0400088C RID: 2188
			SNAPSHOT,
			// Token: 0x0400088D RID: 2189
			INSERT,
			// Token: 0x0400088E RID: 2190
			DELETE,
			// Token: 0x0400088F RID: 2191
			HELP,
			// Token: 0x04000890 RID: 2192
			KEY_0,
			// Token: 0x04000891 RID: 2193
			KEY_1,
			// Token: 0x04000892 RID: 2194
			KEY_2,
			// Token: 0x04000893 RID: 2195
			KEY_3,
			// Token: 0x04000894 RID: 2196
			KEY_4,
			// Token: 0x04000895 RID: 2197
			KEY_5,
			// Token: 0x04000896 RID: 2198
			KEY_6,
			// Token: 0x04000897 RID: 2199
			KEY_7,
			// Token: 0x04000898 RID: 2200
			KEY_8,
			// Token: 0x04000899 RID: 2201
			KEY_9,
			// Token: 0x0400089A RID: 2202
			KEY_A = 65,
			// Token: 0x0400089B RID: 2203
			KEY_B,
			// Token: 0x0400089C RID: 2204
			KEY_C,
			// Token: 0x0400089D RID: 2205
			KEY_D,
			// Token: 0x0400089E RID: 2206
			KEY_E,
			// Token: 0x0400089F RID: 2207
			KEY_F,
			// Token: 0x040008A0 RID: 2208
			KEY_G,
			// Token: 0x040008A1 RID: 2209
			KEY_H,
			// Token: 0x040008A2 RID: 2210
			KEY_I,
			// Token: 0x040008A3 RID: 2211
			KEY_J,
			// Token: 0x040008A4 RID: 2212
			KEY_K,
			// Token: 0x040008A5 RID: 2213
			KEY_L,
			// Token: 0x040008A6 RID: 2214
			KEY_M,
			// Token: 0x040008A7 RID: 2215
			KEY_N,
			// Token: 0x040008A8 RID: 2216
			KEY_O,
			// Token: 0x040008A9 RID: 2217
			KEY_P,
			// Token: 0x040008AA RID: 2218
			KEY_Q,
			// Token: 0x040008AB RID: 2219
			KEY_R,
			// Token: 0x040008AC RID: 2220
			KEY_S,
			// Token: 0x040008AD RID: 2221
			KEY_T,
			// Token: 0x040008AE RID: 2222
			KEY_U,
			// Token: 0x040008AF RID: 2223
			KEY_V,
			// Token: 0x040008B0 RID: 2224
			KEY_W,
			// Token: 0x040008B1 RID: 2225
			KEY_X,
			// Token: 0x040008B2 RID: 2226
			KEY_Y,
			// Token: 0x040008B3 RID: 2227
			KEY_Z,
			// Token: 0x040008B4 RID: 2228
			LWIN,
			// Token: 0x040008B5 RID: 2229
			RWIN,
			// Token: 0x040008B6 RID: 2230
			APPS,
			// Token: 0x040008B7 RID: 2231
			SLEEP = 95,
			// Token: 0x040008B8 RID: 2232
			NUMPAD0,
			// Token: 0x040008B9 RID: 2233
			NUMPAD1,
			// Token: 0x040008BA RID: 2234
			NUMPAD2,
			// Token: 0x040008BB RID: 2235
			NUMPAD3,
			// Token: 0x040008BC RID: 2236
			NUMPAD4,
			// Token: 0x040008BD RID: 2237
			NUMPAD5,
			// Token: 0x040008BE RID: 2238
			NUMPAD6,
			// Token: 0x040008BF RID: 2239
			NUMPAD7,
			// Token: 0x040008C0 RID: 2240
			NUMPAD8,
			// Token: 0x040008C1 RID: 2241
			NUMPAD9,
			// Token: 0x040008C2 RID: 2242
			MULTIPLY,
			// Token: 0x040008C3 RID: 2243
			ADD,
			// Token: 0x040008C4 RID: 2244
			SEPARATOR,
			// Token: 0x040008C5 RID: 2245
			SUBTRACT,
			// Token: 0x040008C6 RID: 2246
			DECIMAL,
			// Token: 0x040008C7 RID: 2247
			DIVIDE,
			// Token: 0x040008C8 RID: 2248
			F1,
			// Token: 0x040008C9 RID: 2249
			F2,
			// Token: 0x040008CA RID: 2250
			F3,
			// Token: 0x040008CB RID: 2251
			F4,
			// Token: 0x040008CC RID: 2252
			F5,
			// Token: 0x040008CD RID: 2253
			F6,
			// Token: 0x040008CE RID: 2254
			F7,
			// Token: 0x040008CF RID: 2255
			F8,
			// Token: 0x040008D0 RID: 2256
			F9,
			// Token: 0x040008D1 RID: 2257
			F10,
			// Token: 0x040008D2 RID: 2258
			F11,
			// Token: 0x040008D3 RID: 2259
			F12,
			// Token: 0x040008D4 RID: 2260
			F13,
			// Token: 0x040008D5 RID: 2261
			F14,
			// Token: 0x040008D6 RID: 2262
			F15,
			// Token: 0x040008D7 RID: 2263
			F16,
			// Token: 0x040008D8 RID: 2264
			F17,
			// Token: 0x040008D9 RID: 2265
			F18,
			// Token: 0x040008DA RID: 2266
			F19,
			// Token: 0x040008DB RID: 2267
			F20,
			// Token: 0x040008DC RID: 2268
			F21,
			// Token: 0x040008DD RID: 2269
			F22,
			// Token: 0x040008DE RID: 2270
			F23,
			// Token: 0x040008DF RID: 2271
			F24,
			// Token: 0x040008E0 RID: 2272
			NUMLOCK = 144,
			// Token: 0x040008E1 RID: 2273
			SCROLL,
			// Token: 0x040008E2 RID: 2274
			LSHIFT = 160,
			// Token: 0x040008E3 RID: 2275
			RSHIFT,
			// Token: 0x040008E4 RID: 2276
			LCONTROL,
			// Token: 0x040008E5 RID: 2277
			RCONTROL,
			// Token: 0x040008E6 RID: 2278
			LMENU,
			// Token: 0x040008E7 RID: 2279
			RMENU,
			// Token: 0x040008E8 RID: 2280
			BROWSER_BACK,
			// Token: 0x040008E9 RID: 2281
			BROWSER_FORWARD,
			// Token: 0x040008EA RID: 2282
			BROWSER_REFRESH,
			// Token: 0x040008EB RID: 2283
			BROWSER_STOP,
			// Token: 0x040008EC RID: 2284
			BROWSER_SEARCH,
			// Token: 0x040008ED RID: 2285
			BROWSER_FAVORITES,
			// Token: 0x040008EE RID: 2286
			BROWSER_HOME,
			// Token: 0x040008EF RID: 2287
			VOLUME_MUTE,
			// Token: 0x040008F0 RID: 2288
			VOLUME_DOWN,
			// Token: 0x040008F1 RID: 2289
			VOLUME_UP,
			// Token: 0x040008F2 RID: 2290
			MEDIA_NEXT_TRACK,
			// Token: 0x040008F3 RID: 2291
			MEDIA_PREV_TRACK,
			// Token: 0x040008F4 RID: 2292
			MEDIA_STOP,
			// Token: 0x040008F5 RID: 2293
			MEDIA_PLAY_PAUSE,
			// Token: 0x040008F6 RID: 2294
			LAUNCH_MAIL,
			// Token: 0x040008F7 RID: 2295
			LAUNCH_MEDIA_SELECT,
			// Token: 0x040008F8 RID: 2296
			LAUNCH_APP1,
			// Token: 0x040008F9 RID: 2297
			LAUNCH_APP2,
			// Token: 0x040008FA RID: 2298
			OEM_1 = 186,
			// Token: 0x040008FB RID: 2299
			OEM_PLUS,
			// Token: 0x040008FC RID: 2300
			OEM_COMMA,
			// Token: 0x040008FD RID: 2301
			OEM_MINUS,
			// Token: 0x040008FE RID: 2302
			OEM_PERIOD,
			// Token: 0x040008FF RID: 2303
			OEM_2,
			// Token: 0x04000900 RID: 2304
			OEM_3,
			// Token: 0x04000901 RID: 2305
			OEM_4 = 219,
			// Token: 0x04000902 RID: 2306
			OEM_5,
			// Token: 0x04000903 RID: 2307
			OEM_6,
			// Token: 0x04000904 RID: 2308
			OEM_7,
			// Token: 0x04000905 RID: 2309
			OEM_8,
			// Token: 0x04000906 RID: 2310
			OEM_102 = 226,
			// Token: 0x04000907 RID: 2311
			PROCESSKEY = 229,
			// Token: 0x04000908 RID: 2312
			PACKET = 231,
			// Token: 0x04000909 RID: 2313
			ATTN = 246,
			// Token: 0x0400090A RID: 2314
			CRSEL,
			// Token: 0x0400090B RID: 2315
			EXSEL,
			// Token: 0x0400090C RID: 2316
			EREOF,
			// Token: 0x0400090D RID: 2317
			PLAY,
			// Token: 0x0400090E RID: 2318
			ZOOM,
			// Token: 0x0400090F RID: 2319
			NONAME,
			// Token: 0x04000910 RID: 2320
			PA1,
			// Token: 0x04000911 RID: 2321
			OEM_CLEAR
		}

		// Token: 0x02000229 RID: 553
		public enum ScanCodeShort : short
		{
			// Token: 0x04000913 RID: 2323
			LBUTTON,
			// Token: 0x04000914 RID: 2324
			RBUTTON = 0,
			// Token: 0x04000915 RID: 2325
			CANCEL = 70,
			// Token: 0x04000916 RID: 2326
			MBUTTON = 0,
			// Token: 0x04000917 RID: 2327
			XBUTTON1 = 0,
			// Token: 0x04000918 RID: 2328
			XBUTTON2 = 0,
			// Token: 0x04000919 RID: 2329
			BACK = 14,
			// Token: 0x0400091A RID: 2330
			TAB,
			// Token: 0x0400091B RID: 2331
			CLEAR = 76,
			// Token: 0x0400091C RID: 2332
			RETURN = 28,
			// Token: 0x0400091D RID: 2333
			SHIFT = 42,
			// Token: 0x0400091E RID: 2334
			CONTROL = 29,
			// Token: 0x0400091F RID: 2335
			MENU = 56,
			// Token: 0x04000920 RID: 2336
			PAUSE = 0,
			// Token: 0x04000921 RID: 2337
			CAPITAL = 58,
			// Token: 0x04000922 RID: 2338
			KANA = 0,
			// Token: 0x04000923 RID: 2339
			HANGUL = 0,
			// Token: 0x04000924 RID: 2340
			JUNJA = 0,
			// Token: 0x04000925 RID: 2341
			FINAL = 0,
			// Token: 0x04000926 RID: 2342
			HANJA = 0,
			// Token: 0x04000927 RID: 2343
			KANJI = 0,
			// Token: 0x04000928 RID: 2344
			ESCAPE,
			// Token: 0x04000929 RID: 2345
			CONVERT = 0,
			// Token: 0x0400092A RID: 2346
			NONCONVERT = 0,
			// Token: 0x0400092B RID: 2347
			ACCEPT = 0,
			// Token: 0x0400092C RID: 2348
			MODECHANGE = 0,
			// Token: 0x0400092D RID: 2349
			SPACE = 57,
			// Token: 0x0400092E RID: 2350
			PRIOR = 73,
			// Token: 0x0400092F RID: 2351
			NEXT = 81,
			// Token: 0x04000930 RID: 2352
			END = 79,
			// Token: 0x04000931 RID: 2353
			HOME = 71,
			// Token: 0x04000932 RID: 2354
			LEFT = 75,
			// Token: 0x04000933 RID: 2355
			UP = 72,
			// Token: 0x04000934 RID: 2356
			RIGHT = 77,
			// Token: 0x04000935 RID: 2357
			DOWN = 80,
			// Token: 0x04000936 RID: 2358
			SELECT = 0,
			// Token: 0x04000937 RID: 2359
			PRINT = 0,
			// Token: 0x04000938 RID: 2360
			EXECUTE = 0,
			// Token: 0x04000939 RID: 2361
			SNAPSHOT = 84,
			// Token: 0x0400093A RID: 2362
			INSERT = 82,
			// Token: 0x0400093B RID: 2363
			DELETE,
			// Token: 0x0400093C RID: 2364
			HELP = 99,
			// Token: 0x0400093D RID: 2365
			KEY_0 = 11,
			// Token: 0x0400093E RID: 2366
			KEY_1 = 2,
			// Token: 0x0400093F RID: 2367
			KEY_2,
			// Token: 0x04000940 RID: 2368
			KEY_3,
			// Token: 0x04000941 RID: 2369
			KEY_4,
			// Token: 0x04000942 RID: 2370
			KEY_5,
			// Token: 0x04000943 RID: 2371
			KEY_6,
			// Token: 0x04000944 RID: 2372
			KEY_7,
			// Token: 0x04000945 RID: 2373
			KEY_8,
			// Token: 0x04000946 RID: 2374
			KEY_9,
			// Token: 0x04000947 RID: 2375
			KEY_A = 30,
			// Token: 0x04000948 RID: 2376
			KEY_B = 48,
			// Token: 0x04000949 RID: 2377
			KEY_C = 46,
			// Token: 0x0400094A RID: 2378
			KEY_D = 32,
			// Token: 0x0400094B RID: 2379
			KEY_E = 18,
			// Token: 0x0400094C RID: 2380
			KEY_F = 33,
			// Token: 0x0400094D RID: 2381
			KEY_G,
			// Token: 0x0400094E RID: 2382
			KEY_H,
			// Token: 0x0400094F RID: 2383
			KEY_I = 23,
			// Token: 0x04000950 RID: 2384
			KEY_J = 36,
			// Token: 0x04000951 RID: 2385
			KEY_K,
			// Token: 0x04000952 RID: 2386
			KEY_L,
			// Token: 0x04000953 RID: 2387
			KEY_M = 50,
			// Token: 0x04000954 RID: 2388
			KEY_N = 49,
			// Token: 0x04000955 RID: 2389
			KEY_O = 24,
			// Token: 0x04000956 RID: 2390
			KEY_P,
			// Token: 0x04000957 RID: 2391
			KEY_Q = 16,
			// Token: 0x04000958 RID: 2392
			KEY_R = 19,
			// Token: 0x04000959 RID: 2393
			KEY_S = 31,
			// Token: 0x0400095A RID: 2394
			KEY_T = 20,
			// Token: 0x0400095B RID: 2395
			KEY_U = 22,
			// Token: 0x0400095C RID: 2396
			KEY_V = 47,
			// Token: 0x0400095D RID: 2397
			KEY_W = 17,
			// Token: 0x0400095E RID: 2398
			KEY_X = 45,
			// Token: 0x0400095F RID: 2399
			KEY_Y = 21,
			// Token: 0x04000960 RID: 2400
			KEY_Z = 44,
			// Token: 0x04000961 RID: 2401
			LWIN = 91,
			// Token: 0x04000962 RID: 2402
			RWIN,
			// Token: 0x04000963 RID: 2403
			APPS,
			// Token: 0x04000964 RID: 2404
			SLEEP = 95,
			// Token: 0x04000965 RID: 2405
			NUMPAD0 = 82,
			// Token: 0x04000966 RID: 2406
			NUMPAD1 = 79,
			// Token: 0x04000967 RID: 2407
			NUMPAD2,
			// Token: 0x04000968 RID: 2408
			NUMPAD3,
			// Token: 0x04000969 RID: 2409
			NUMPAD4 = 75,
			// Token: 0x0400096A RID: 2410
			NUMPAD5,
			// Token: 0x0400096B RID: 2411
			NUMPAD6,
			// Token: 0x0400096C RID: 2412
			NUMPAD7 = 71,
			// Token: 0x0400096D RID: 2413
			NUMPAD8,
			// Token: 0x0400096E RID: 2414
			NUMPAD9,
			// Token: 0x0400096F RID: 2415
			MULTIPLY = 55,
			// Token: 0x04000970 RID: 2416
			ADD = 78,
			// Token: 0x04000971 RID: 2417
			SEPARATOR = 0,
			// Token: 0x04000972 RID: 2418
			SUBTRACT = 74,
			// Token: 0x04000973 RID: 2419
			DECIMAL = 83,
			// Token: 0x04000974 RID: 2420
			DIVIDE = 53,
			// Token: 0x04000975 RID: 2421
			F1 = 59,
			// Token: 0x04000976 RID: 2422
			F2,
			// Token: 0x04000977 RID: 2423
			F3,
			// Token: 0x04000978 RID: 2424
			F4,
			// Token: 0x04000979 RID: 2425
			F5,
			// Token: 0x0400097A RID: 2426
			F6,
			// Token: 0x0400097B RID: 2427
			F7,
			// Token: 0x0400097C RID: 2428
			F8,
			// Token: 0x0400097D RID: 2429
			F9,
			// Token: 0x0400097E RID: 2430
			F10,
			// Token: 0x0400097F RID: 2431
			F11 = 87,
			// Token: 0x04000980 RID: 2432
			F12,
			// Token: 0x04000981 RID: 2433
			F13 = 100,
			// Token: 0x04000982 RID: 2434
			F14,
			// Token: 0x04000983 RID: 2435
			F15,
			// Token: 0x04000984 RID: 2436
			F16,
			// Token: 0x04000985 RID: 2437
			F17,
			// Token: 0x04000986 RID: 2438
			F18,
			// Token: 0x04000987 RID: 2439
			F19,
			// Token: 0x04000988 RID: 2440
			F20,
			// Token: 0x04000989 RID: 2441
			F21,
			// Token: 0x0400098A RID: 2442
			F22,
			// Token: 0x0400098B RID: 2443
			F23,
			// Token: 0x0400098C RID: 2444
			F24 = 118,
			// Token: 0x0400098D RID: 2445
			NUMLOCK = 69,
			// Token: 0x0400098E RID: 2446
			SCROLL,
			// Token: 0x0400098F RID: 2447
			LSHIFT = 42,
			// Token: 0x04000990 RID: 2448
			RSHIFT = 54,
			// Token: 0x04000991 RID: 2449
			LCONTROL = 29,
			// Token: 0x04000992 RID: 2450
			RCONTROL = 29,
			// Token: 0x04000993 RID: 2451
			LMENU = 56,
			// Token: 0x04000994 RID: 2452
			RMENU = 56,
			// Token: 0x04000995 RID: 2453
			BROWSER_BACK = 106,
			// Token: 0x04000996 RID: 2454
			BROWSER_FORWARD = 105,
			// Token: 0x04000997 RID: 2455
			BROWSER_REFRESH = 103,
			// Token: 0x04000998 RID: 2456
			BROWSER_STOP,
			// Token: 0x04000999 RID: 2457
			BROWSER_SEARCH = 101,
			// Token: 0x0400099A RID: 2458
			BROWSER_FAVORITES,
			// Token: 0x0400099B RID: 2459
			BROWSER_HOME = 50,
			// Token: 0x0400099C RID: 2460
			VOLUME_MUTE = 32,
			// Token: 0x0400099D RID: 2461
			VOLUME_DOWN = 46,
			// Token: 0x0400099E RID: 2462
			VOLUME_UP = 48,
			// Token: 0x0400099F RID: 2463
			MEDIA_NEXT_TRACK = 25,
			// Token: 0x040009A0 RID: 2464
			MEDIA_PREV_TRACK = 16,
			// Token: 0x040009A1 RID: 2465
			MEDIA_STOP = 36,
			// Token: 0x040009A2 RID: 2466
			MEDIA_PLAY_PAUSE = 34,
			// Token: 0x040009A3 RID: 2467
			LAUNCH_MAIL = 108,
			// Token: 0x040009A4 RID: 2468
			LAUNCH_MEDIA_SELECT,
			// Token: 0x040009A5 RID: 2469
			LAUNCH_APP1 = 107,
			// Token: 0x040009A6 RID: 2470
			LAUNCH_APP2 = 33,
			// Token: 0x040009A7 RID: 2471
			OEM_1 = 39,
			// Token: 0x040009A8 RID: 2472
			OEM_PLUS = 13,
			// Token: 0x040009A9 RID: 2473
			OEM_COMMA = 51,
			// Token: 0x040009AA RID: 2474
			OEM_MINUS = 12,
			// Token: 0x040009AB RID: 2475
			OEM_PERIOD = 52,
			// Token: 0x040009AC RID: 2476
			OEM_2,
			// Token: 0x040009AD RID: 2477
			OEM_3 = 41,
			// Token: 0x040009AE RID: 2478
			OEM_4 = 26,
			// Token: 0x040009AF RID: 2479
			OEM_5 = 43,
			// Token: 0x040009B0 RID: 2480
			OEM_6 = 27,
			// Token: 0x040009B1 RID: 2481
			OEM_7 = 40,
			// Token: 0x040009B2 RID: 2482
			OEM_8 = 0,
			// Token: 0x040009B3 RID: 2483
			OEM_102 = 86,
			// Token: 0x040009B4 RID: 2484
			PROCESSKEY = 0,
			// Token: 0x040009B5 RID: 2485
			PACKET = 0,
			// Token: 0x040009B6 RID: 2486
			ATTN = 0,
			// Token: 0x040009B7 RID: 2487
			CRSEL = 0,
			// Token: 0x040009B8 RID: 2488
			EXSEL = 0,
			// Token: 0x040009B9 RID: 2489
			EREOF = 93,
			// Token: 0x040009BA RID: 2490
			PLAY = 0,
			// Token: 0x040009BB RID: 2491
			ZOOM = 98,
			// Token: 0x040009BC RID: 2492
			NONAME = 0,
			// Token: 0x040009BD RID: 2493
			PA1 = 0,
			// Token: 0x040009BE RID: 2494
			OEM_CLEAR = 0
		}
	}
}
