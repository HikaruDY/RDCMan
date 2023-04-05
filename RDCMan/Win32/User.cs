using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Win32
{
	public class User
	{
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool TrackMouseEvent(ref Structs.TRACKMOUSEEVENT lpEventTrack);

		[DllImport("user32.dll")]
		public static extern short GetAsyncKeyState(int vkey);

		[DllImport("user32.dll")]
		public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

		[DllImport("user32.dll")]
		public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr handle, int wMsg, int wParam, int lParam);

		[DllImport("user32.dll")]
		public static extern IntPtr GetWindow(IntPtr handle, uint wCmd);

		[DllImport("user32.dll")]
		public static extern bool SetForegroundWindow(IntPtr handle);

		[DllImport("user32.dll")]
		public static extern bool GetCaretPos(out Point pt);

		[DllImport("user32.dll")]
		public static extern bool SetCaretPos(int x, int y);

		[DllImport("user32.dll")]
		public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		[DllImport("user32.dll")]
		public static extern int GetDlgCtrlID(IntPtr hwndCtl);

		[DllImport("user32.dll")]
		public static extern int ScrollWindowEx(IntPtr hWnd, int dx, int dy, IntPtr prcScroll, IntPtr prcClip, IntPtr hrgnUpdate, IntPtr prcUpdate, uint flags);

		[DllImport("user32.dll")]
		public static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray)] [In] User.INPUT[] pInputs, int cbSize);

		public const uint INPUT_KEYBOARD = 1U;

		public struct INPUT
		{
			public static int Size
			{
				get
				{
					return Marshal.SizeOf(typeof(User.INPUT));
				}
			}

			public uint type;

			public User.InputUnion U;
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct InputUnion
		{
			[FieldOffset(0)]
			public User.MOUSEINPUT mi;

			[FieldOffset(0)]
			public User.KEYBDINPUT ki;
		}

		public struct MOUSEINPUT
		{
			public int dx;

			public int dy;

			public User.MouseEventDataXButtons mouseData;

			public User.MOUSEEVENTF dwFlags;

			public uint time;

			public UIntPtr dwExtraInfo;
		}

		[Flags]
		public enum MouseEventDataXButtons : uint
		{
			Nothing = 0U,
			XBUTTON1 = 1U,
			XBUTTON2 = 2U
		}

		[Flags]
		public enum MOUSEEVENTF : uint
		{
			ABSOLUTE = 32768U,
			HWHEEL = 4096U,
			MOVE = 1U,
			MOVE_NOCOALESCE = 8192U,
			LEFTDOWN = 2U,
			LEFTUP = 4U,
			RIGHTDOWN = 8U,
			RIGHTUP = 16U,
			MIDDLEDOWN = 32U,
			MIDDLEUP = 64U,
			VIRTUALDESK = 16384U,
			WHEEL = 2048U,
			XDOWN = 128U,
			XUP = 256U
		}

		public struct KEYBDINPUT
		{
			public User.VirtualKeyShort wVk;

			public User.ScanCodeShort wScan;

			public User.KEYEVENTF dwFlags;

			public int time;

			public UIntPtr dwExtraInfo;
		}

		[Flags]
		public enum KEYEVENTF : uint
		{
			EXTENDEDKEY = 1U,
			KEYUP = 2U,
			SCANCODE = 8U,
			UNICODE = 4U
		}

		public enum VirtualKeyShort : short
		{
			LBUTTON = 1,
			RBUTTON,
			CANCEL,
			MBUTTON,
			XBUTTON1,
			XBUTTON2,
			BACK = 8,
			TAB,
			CLEAR = 12,
			RETURN,
			SHIFT = 16,
			CONTROL,
			MENU,
			PAUSE,
			CAPITAL,
			KANA,
			HANGUL = 21,
			JUNJA = 23,
			FINAL,
			HANJA,
			KANJI = 25,
			ESCAPE = 27,
			CONVERT,
			NONCONVERT,
			ACCEPT,
			MODECHANGE,
			SPACE,
			PRIOR,
			NEXT,
			END,
			HOME,
			LEFT,
			UP,
			RIGHT,
			DOWN,
			SELECT,
			PRINT,
			EXECUTE,
			SNAPSHOT,
			INSERT,
			DELETE,
			HELP,
			KEY_0,
			KEY_1,
			KEY_2,
			KEY_3,
			KEY_4,
			KEY_5,
			KEY_6,
			KEY_7,
			KEY_8,
			KEY_9,
			KEY_A = 65,
			KEY_B,
			KEY_C,
			KEY_D,
			KEY_E,
			KEY_F,
			KEY_G,
			KEY_H,
			KEY_I,
			KEY_J,
			KEY_K,
			KEY_L,
			KEY_M,
			KEY_N,
			KEY_O,
			KEY_P,
			KEY_Q,
			KEY_R,
			KEY_S,
			KEY_T,
			KEY_U,
			KEY_V,
			KEY_W,
			KEY_X,
			KEY_Y,
			KEY_Z,
			LWIN,
			RWIN,
			APPS,
			SLEEP = 95,
			NUMPAD0,
			NUMPAD1,
			NUMPAD2,
			NUMPAD3,
			NUMPAD4,
			NUMPAD5,
			NUMPAD6,
			NUMPAD7,
			NUMPAD8,
			NUMPAD9,
			MULTIPLY,
			ADD,
			SEPARATOR,
			SUBTRACT,
			DECIMAL,
			DIVIDE,
			F1,
			F2,
			F3,
			F4,
			F5,
			F6,
			F7,
			F8,
			F9,
			F10,
			F11,
			F12,
			F13,
			F14,
			F15,
			F16,
			F17,
			F18,
			F19,
			F20,
			F21,
			F22,
			F23,
			F24,
			NUMLOCK = 144,
			SCROLL,
			LSHIFT = 160,
			RSHIFT,
			LCONTROL,
			RCONTROL,
			LMENU,
			RMENU,
			BROWSER_BACK,
			BROWSER_FORWARD,
			BROWSER_REFRESH,
			BROWSER_STOP,
			BROWSER_SEARCH,
			BROWSER_FAVORITES,
			BROWSER_HOME,
			VOLUME_MUTE,
			VOLUME_DOWN,
			VOLUME_UP,
			MEDIA_NEXT_TRACK,
			MEDIA_PREV_TRACK,
			MEDIA_STOP,
			MEDIA_PLAY_PAUSE,
			LAUNCH_MAIL,
			LAUNCH_MEDIA_SELECT,
			LAUNCH_APP1,
			LAUNCH_APP2,
			OEM_1 = 186,
			OEM_PLUS,
			OEM_COMMA,
			OEM_MINUS,
			OEM_PERIOD,
			OEM_2,
			OEM_3,
			OEM_4 = 219,
			OEM_5,
			OEM_6,
			OEM_7,
			OEM_8,
			OEM_102 = 226,
			PROCESSKEY = 229,
			PACKET = 231,
			ATTN = 246,
			CRSEL,
			EXSEL,
			EREOF,
			PLAY,
			ZOOM,
			NONAME,
			PA1,
			OEM_CLEAR
		}

		public enum ScanCodeShort : short
		{
			LBUTTON,
			RBUTTON = 0,
			CANCEL = 70,
			MBUTTON = 0,
			XBUTTON1 = 0,
			XBUTTON2 = 0,
			BACK = 14,
			TAB,
			CLEAR = 76,
			RETURN = 28,
			SHIFT = 42,
			CONTROL = 29,
			MENU = 56,
			PAUSE = 0,
			CAPITAL = 58,
			KANA = 0,
			HANGUL = 0,
			JUNJA = 0,
			FINAL = 0,
			HANJA = 0,
			KANJI = 0,
			ESCAPE,
			CONVERT = 0,
			NONCONVERT = 0,
			ACCEPT = 0,
			MODECHANGE = 0,
			SPACE = 57,
			PRIOR = 73,
			NEXT = 81,
			END = 79,
			HOME = 71,
			LEFT = 75,
			UP = 72,
			RIGHT = 77,
			DOWN = 80,
			SELECT = 0,
			PRINT = 0,
			EXECUTE = 0,
			SNAPSHOT = 84,
			INSERT = 82,
			DELETE,
			HELP = 99,
			KEY_0 = 11,
			KEY_1 = 2,
			KEY_2,
			KEY_3,
			KEY_4,
			KEY_5,
			KEY_6,
			KEY_7,
			KEY_8,
			KEY_9,
			KEY_A = 30,
			KEY_B = 48,
			KEY_C = 46,
			KEY_D = 32,
			KEY_E = 18,
			KEY_F = 33,
			KEY_G,
			KEY_H,
			KEY_I = 23,
			KEY_J = 36,
			KEY_K,
			KEY_L,
			KEY_M = 50,
			KEY_N = 49,
			KEY_O = 24,
			KEY_P,
			KEY_Q = 16,
			KEY_R = 19,
			KEY_S = 31,
			KEY_T = 20,
			KEY_U = 22,
			KEY_V = 47,
			KEY_W = 17,
			KEY_X = 45,
			KEY_Y = 21,
			KEY_Z = 44,
			LWIN = 91,
			RWIN,
			APPS,
			SLEEP = 95,
			NUMPAD0 = 82,
			NUMPAD1 = 79,
			NUMPAD2,
			NUMPAD3,
			NUMPAD4 = 75,
			NUMPAD5,
			NUMPAD6,
			NUMPAD7 = 71,
			NUMPAD8,
			NUMPAD9,
			MULTIPLY = 55,
			ADD = 78,
			SEPARATOR = 0,
			SUBTRACT = 74,
			DECIMAL = 83,
			DIVIDE = 53,
			F1 = 59,
			F2,
			F3,
			F4,
			F5,
			F6,
			F7,
			F8,
			F9,
			F10,
			F11 = 87,
			F12,
			F13 = 100,
			F14,
			F15,
			F16,
			F17,
			F18,
			F19,
			F20,
			F21,
			F22,
			F23,
			F24 = 118,
			NUMLOCK = 69,
			SCROLL,
			LSHIFT = 42,
			RSHIFT = 54,
			LCONTROL = 29,
			RCONTROL = 29,
			LMENU = 56,
			RMENU = 56,
			BROWSER_BACK = 106,
			BROWSER_FORWARD = 105,
			BROWSER_REFRESH = 103,
			BROWSER_STOP,
			BROWSER_SEARCH = 101,
			BROWSER_FAVORITES,
			BROWSER_HOME = 50,
			VOLUME_MUTE = 32,
			VOLUME_DOWN = 46,
			VOLUME_UP = 48,
			MEDIA_NEXT_TRACK = 25,
			MEDIA_PREV_TRACK = 16,
			MEDIA_STOP = 36,
			MEDIA_PLAY_PAUSE = 34,
			LAUNCH_MAIL = 108,
			LAUNCH_MEDIA_SELECT,
			LAUNCH_APP1 = 107,
			LAUNCH_APP2 = 33,
			OEM_1 = 39,
			OEM_PLUS = 13,
			OEM_COMMA = 51,
			OEM_MINUS = 12,
			OEM_PERIOD = 52,
			OEM_2,
			OEM_3 = 41,
			OEM_4 = 26,
			OEM_5 = 43,
			OEM_6 = 27,
			OEM_7 = 40,
			OEM_8 = 0,
			OEM_102 = 86,
			PROCESSKEY = 0,
			PACKET = 0,
			ATTN = 0,
			CRSEL = 0,
			EXSEL = 0,
			EREOF = 93,
			PLAY = 0,
			ZOOM = 98,
			NONAME = 0,
			PA1 = 0,
			OEM_CLEAR = 0
		}
	}
}
