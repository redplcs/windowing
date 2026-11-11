namespace Redplcs.Windowing;

/// <summary>
/// Provides data for the <see cref="Window.KeyDown"/> and <see cref="Window.KeyUp"/> events.
/// </summary>
public readonly struct KeyEventArgs
{
    internal KeyEventArgs(PhysicalKey physicalKey, int scanCode, KeyModifiers modifiers, bool isRepeat)
    {
        (PhysicalKey, ScanCode, Modifiers, IsRepeat) = (physicalKey, scanCode, modifiers, isRepeat);
    }
 
    /// <summary>Gets the key, identified by its position on the keyboard.</summary>
    /// <value>
    /// The key, or <see cref="PhysicalKey.Unknown"/> if the key is not in the enumeration.
    /// Unknown keys can be told apart by <see cref="ScanCode"/>.
    /// </value>
    public PhysicalKey PhysicalKey { get; }
 
    /// <summary>Gets the raw key code of the platform.</summary>
    /// <value>The evdev code on Linux and the scan code on Windows. The values of different platforms do not match.</value>
    public int ScanCode { get; }
 
    /// <summary>Gets the modifier keys that are held down right after the event.</summary>
    /// <value>
    /// The modifiers. When a Shift key is pressed, <see cref="KeyModifiers.Shift"/> is already set;
    /// when it is released, the flag is already cleared.
    /// </value>
    public KeyModifiers Modifiers { get; }
 
    /// <summary>Gets a value indicating whether the event is a repeat of a key that is held down.</summary>
    /// <value><see langword="true"/> for a repeated <see cref="Window.KeyDown"/>; otherwise, <see langword="false"/>.</value>
    public bool IsRepeat { get; }
}