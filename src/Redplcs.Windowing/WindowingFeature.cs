namespace Redplcs.Windowing;

/// <summary>
/// Identifies a feature whose availability is known only at run time.
/// </summary>
/// <remarks>
/// Use <see cref="WindowingSystem.IsSupported(WindowingFeature)"/> to check a feature.
/// </remarks>
public enum WindowingFeature
{
    /// <summary>
    /// The system draws the frame and the title bar of a window.
    /// On Win32 this is always supported. On Wayland it is supported when the compositor implements the
    /// xdg-decoration protocol; otherwise a window has no frame and the user cannot move or resize it with the mouse.
    /// </summary>
    SystemDecorations = 0,
}