namespace Redplcs.Windowing;

/// <summary>Identifies a key by its position on the keyboard, not by the character it produces.</summary>
/// <remarks>
/// <para>
/// The names follow a US QWERTY keyboard. <see cref="Z"/> is the key in the position of Z on that keyboard;
/// on a German layout the same key is labeled Y.
/// </para>
/// <para>The numeric values are the key codes of the USB HID usage tables.</para>
/// </remarks>
public enum PhysicalKey
{
    /// <summary>A key that is not in this enumeration.</summary>
    Unknown = 0,
 
    /// <summary>The key in the position of A on a US QWERTY keyboard.</summary>
    A = 4,
 
    /// <summary>The key in the position of B on a US QWERTY keyboard.</summary>
    B = 5,
 
    /// <summary>The key in the position of C on a US QWERTY keyboard.</summary>
    C = 6,
 
    /// <summary>The key in the position of D on a US QWERTY keyboard.</summary>
    D = 7,
 
    /// <summary>The key in the position of E on a US QWERTY keyboard.</summary>
    E = 8,
 
    /// <summary>The key in the position of F on a US QWERTY keyboard.</summary>
    F = 9,
 
    /// <summary>The key in the position of G on a US QWERTY keyboard.</summary>
    G = 10,
 
    /// <summary>The key in the position of H on a US QWERTY keyboard.</summary>
    H = 11,
 
    /// <summary>The key in the position of I on a US QWERTY keyboard.</summary>
    I = 12,
 
    /// <summary>The key in the position of J on a US QWERTY keyboard.</summary>
    J = 13,
 
    /// <summary>The key in the position of K on a US QWERTY keyboard.</summary>
    K = 14,
 
    /// <summary>The key in the position of L on a US QWERTY keyboard.</summary>
    L = 15,
 
    /// <summary>The key in the position of M on a US QWERTY keyboard.</summary>
    M = 16,
 
    /// <summary>The key in the position of N on a US QWERTY keyboard.</summary>
    N = 17,
 
    /// <summary>The key in the position of O on a US QWERTY keyboard.</summary>
    O = 18,
 
    /// <summary>The key in the position of P on a US QWERTY keyboard.</summary>
    P = 19,
 
    /// <summary>The key in the position of Q on a US QWERTY keyboard.</summary>
    Q = 20,
 
    /// <summary>The key in the position of R on a US QWERTY keyboard.</summary>
    R = 21,
 
    /// <summary>The key in the position of S on a US QWERTY keyboard.</summary>
    S = 22,
 
    /// <summary>The key in the position of T on a US QWERTY keyboard.</summary>
    T = 23,
 
    /// <summary>The key in the position of U on a US QWERTY keyboard.</summary>
    U = 24,
 
    /// <summary>The key in the position of V on a US QWERTY keyboard.</summary>
    V = 25,
 
    /// <summary>The key in the position of W on a US QWERTY keyboard.</summary>
    W = 26,
 
    /// <summary>The key in the position of X on a US QWERTY keyboard.</summary>
    X = 27,
 
    /// <summary>The key in the position of Y on a US QWERTY keyboard.</summary>
    Y = 28,
 
    /// <summary>The key in the position of Z on a US QWERTY keyboard.</summary>
    Z = 29,
 
    /// <summary>The 1 key of the main digit row.</summary>
    Digit1 = 30,
 
    /// <summary>The 2 key of the main digit row.</summary>
    Digit2 = 31,
 
    /// <summary>The 3 key of the main digit row.</summary>
    Digit3 = 32,
 
    /// <summary>The 4 key of the main digit row.</summary>
    Digit4 = 33,
 
    /// <summary>The 5 key of the main digit row.</summary>
    Digit5 = 34,
 
    /// <summary>The 6 key of the main digit row.</summary>
    Digit6 = 35,
 
    /// <summary>The 7 key of the main digit row.</summary>
    Digit7 = 36,
 
    /// <summary>The 8 key of the main digit row.</summary>
    Digit8 = 37,
 
    /// <summary>The 9 key of the main digit row.</summary>
    Digit9 = 38,
 
    /// <summary>The 0 key of the main digit row.</summary>
    Digit0 = 39,
 
    /// <summary>The main Enter key.</summary>
    Enter = 40,
 
    /// <summary>The Escape key.</summary>
    Escape = 41,
 
    /// <summary>The Backspace key.</summary>
    Backspace = 42,
 
    /// <summary>The Tab key.</summary>
    Tab = 43,
 
    /// <summary>The space bar.</summary>
    Space = 44,
 
    /// <summary>The key in the position of the hyphen-minus (-) on a US QWERTY keyboard.</summary>
    Minus = 45,
 
    /// <summary>The key in the position of the equals sign (=) on a US QWERTY keyboard.</summary>
    Equal = 46,
 
    /// <summary>The key in the position of the left square bracket ([) on a US QWERTY keyboard.</summary>
    LeftBracket = 47,
 
    /// <summary>The key in the position of the right square bracket (]) on a US QWERTY keyboard.</summary>
    RightBracket = 48,
 
    /// <summary>The key in the position of the backslash (\) on a US QWERTY keyboard.</summary>
    Backslash = 49,
 
    /// <summary>The key in the position of the semicolon (;) on a US QWERTY keyboard.</summary>
    Semicolon = 51,
 
    /// <summary>The key in the position of the apostrophe (') on a US QWERTY keyboard.</summary>
    Quote = 52,
 
    /// <summary>The key in the position of the grave accent (`) on a US QWERTY keyboard.</summary>
    Backquote = 53,
 
    /// <summary>The key in the position of the comma (,) on a US QWERTY keyboard.</summary>
    Comma = 54,
 
    /// <summary>The key in the position of the period (.) on a US QWERTY keyboard.</summary>
    Period = 55,
 
    /// <summary>The key in the position of the slash (/) on a US QWERTY keyboard.</summary>
    Slash = 56,
 
    /// <summary>The Caps Lock key.</summary>
    CapsLock = 57,
 
    /// <summary>The F1 key.</summary>
    F1 = 58,
 
    /// <summary>The F2 key.</summary>
    F2 = 59,
 
    /// <summary>The F3 key.</summary>
    F3 = 60,
 
    /// <summary>The F4 key.</summary>
    F4 = 61,
 
    /// <summary>The F5 key.</summary>
    F5 = 62,
 
    /// <summary>The F6 key.</summary>
    F6 = 63,
 
    /// <summary>The F7 key.</summary>
    F7 = 64,
 
    /// <summary>The F8 key.</summary>
    F8 = 65,
 
    /// <summary>The F9 key.</summary>
    F9 = 66,
 
    /// <summary>The F10 key.</summary>
    F10 = 67,
 
    /// <summary>The F11 key.</summary>
    F11 = 68,
 
    /// <summary>The F12 key.</summary>
    F12 = 69,
 
    /// <summary>The Print Screen key.</summary>
    PrintScreen = 70,
 
    /// <summary>The Scroll Lock key.</summary>
    ScrollLock = 71,
 
    /// <summary>The Pause key.</summary>
    Pause = 72,
 
    /// <summary>The Insert key.</summary>
    Insert = 73,
 
    /// <summary>The Home key.</summary>
    Home = 74,
 
    /// <summary>The Page Up key.</summary>
    PageUp = 75,
 
    /// <summary>The Delete key.</summary>
    Delete = 76,
 
    /// <summary>The End key.</summary>
    End = 77,
 
    /// <summary>The Page Down key.</summary>
    PageDown = 78,
 
    /// <summary>The right arrow key.</summary>
    RightArrow = 79,
 
    /// <summary>The left arrow key.</summary>
    LeftArrow = 80,
 
    /// <summary>The down arrow key.</summary>
    DownArrow = 81,
 
    /// <summary>The up arrow key.</summary>
    UpArrow = 82,
 
    /// <summary>The Num Lock key.</summary>
    NumLock = 83,
 
    /// <summary>The divide key of the numeric keypad.</summary>
    NumpadDivide = 84,
 
    /// <summary>The multiply key of the numeric keypad.</summary>
    NumpadMultiply = 85,
 
    /// <summary>The subtract key of the numeric keypad.</summary>
    NumpadSubtract = 86,
 
    /// <summary>The add key of the numeric keypad.</summary>
    NumpadAdd = 87,
 
    /// <summary>The Enter key of the numeric keypad.</summary>
    NumpadEnter = 88,
 
    /// <summary>The 1 key of the numeric keypad.</summary>
    Numpad1 = 89,
 
    /// <summary>The 2 key of the numeric keypad.</summary>
    Numpad2 = 90,
 
    /// <summary>The 3 key of the numeric keypad.</summary>
    Numpad3 = 91,
 
    /// <summary>The 4 key of the numeric keypad.</summary>
    Numpad4 = 92,
 
    /// <summary>The 5 key of the numeric keypad.</summary>
    Numpad5 = 93,
 
    /// <summary>The 6 key of the numeric keypad.</summary>
    Numpad6 = 94,
 
    /// <summary>The 7 key of the numeric keypad.</summary>
    Numpad7 = 95,
 
    /// <summary>The 8 key of the numeric keypad.</summary>
    Numpad8 = 96,
 
    /// <summary>The 9 key of the numeric keypad.</summary>
    Numpad9 = 97,
 
    /// <summary>The 0 key of the numeric keypad.</summary>
    Numpad0 = 98,
 
    /// <summary>The decimal separator key of the numeric keypad.</summary>
    NumpadDecimal = 99,
 
    /// <summary>The additional key of ISO keyboards, located between the left Shift key and Z.</summary>
    Oem102 = 100,
 
    /// <summary>The Applications key, which opens a context menu.</summary>
    Applications = 101,
 
    /// <summary>The F13 key.</summary>
    F13 = 104,
 
    /// <summary>The F14 key.</summary>
    F14 = 105,
 
    /// <summary>The F15 key.</summary>
    F15 = 106,
 
    /// <summary>The F16 key.</summary>
    F16 = 107,
 
    /// <summary>The F17 key.</summary>
    F17 = 108,
 
    /// <summary>The F18 key.</summary>
    F18 = 109,
 
    /// <summary>The F19 key.</summary>
    F19 = 110,
 
    /// <summary>The F20 key.</summary>
    F20 = 111,
 
    /// <summary>The F21 key.</summary>
    F21 = 112,
 
    /// <summary>The F22 key.</summary>
    F22 = 113,
 
    /// <summary>The F23 key.</summary>
    F23 = 114,
 
    /// <summary>The F24 key.</summary>
    F24 = 115,
 
    /// <summary>The left Control key.</summary>
    LeftControl = 224,
 
    /// <summary>The left Shift key.</summary>
    LeftShift = 225,
 
    /// <summary>The left Alt key.</summary>
    LeftAlt = 226,
 
    /// <summary>The left Super key: the Windows key or the Command key.</summary>
    LeftSuper = 227,
 
    /// <summary>The right Control key.</summary>
    RightControl = 228,
 
    /// <summary>The right Shift key.</summary>
    RightShift = 229,
 
    /// <summary>The right Alt key.</summary>
    RightAlt = 230,
 
    /// <summary>The right Super key: the Windows key or the Command key.</summary>
    RightSuper = 231,
}