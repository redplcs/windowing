using System.Drawing;

namespace Redplcs.Windowing;

/// <summary>
/// Provides data for the <see cref="Window.MouseWheel"/> event.
/// </summary>
public readonly struct MouseWheelEventArgs
{
    internal MouseWheelEventArgs(PointF delta, PointF position, KeyModifiers modifiers)
    {
        (Delta, Position, Modifiers) = (delta, position, modifiers);
    }
 
    /// <summary>Gets the scroll amount.</summary>
    /// <value>
    /// The amount, where 1 is one notch of an ordinary wheel. Smooth wheels and touchpads report fractions.
    /// A positive Y is a rotation away from the user, a positive X is a scroll to the right.
    /// </value>
    public PointF Delta { get; }
 
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