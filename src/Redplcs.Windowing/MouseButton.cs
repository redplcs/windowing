namespace Redplcs.Windowing;

/// <summary>
/// Specifies a mouse button.
/// </summary>
public enum MouseButton
{
    /// <summary>
    /// The primary button. If the user swapped the buttons in the system settings, the system swaps them before the event reaches the application.
    /// </summary>
    Left = 0,
    
    /// <summary>
    /// The middle button, usually the wheel.
    /// </summary>
    Middle = 1,
 
    /// <summary>
    /// The secondary button.
    /// </summary>
    Right = 2,
 
    /// <summary>
    /// The first side button, usually "back".
    /// </summary>
    Back = 3,
 
    /// <summary>
    /// The second side button, usually "forward".
    /// </summary>
    Forward = 4,
}