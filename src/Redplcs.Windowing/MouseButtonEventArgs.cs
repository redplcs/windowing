using System.Drawing;

namespace Redplcs.Windowing;

/// <summary>
/// Provides data for the <see cref="Window.MouseDown"/> and <see cref="Window.MouseUp"/> events.
/// </summary>
public readonly struct MouseButtonEventArgs
{
    internal MouseButtonEventArgs(MouseButton button, PointF position, KeyModifiers modifiers)
    {
        (Button, Position, Modifiers) = (button, position, modifiers);
    }
 
    /// <summary>Gets the button that was pressed or released.</summary>
    /// <value>The button.</value>
    public MouseButton Button { get; }
 
    /// <summary>Gets the position of the pointer, in pixels.</summary>
    /// <value>
    /// The position relative to the top-left corner of the content area; the Y axis points down.
    /// The coordinates can be fractional.
    /// </value>
    public PointF Position { get; }
 
    /// <summary>Gets the modifier keys that are held down.</summary>
    /// <value>
    /// The modifiers. On Wayland they are known only while the window has keyboard focus;
    /// without focus the value is <see cref="KeyModifiers.None"/>.
    /// </value>
    public KeyModifiers Modifiers { get; }
}