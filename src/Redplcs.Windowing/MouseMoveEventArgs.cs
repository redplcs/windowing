using System.Drawing;

namespace Redplcs.Windowing;

/// <summary>
/// Provides data for the <see cref="Window.MouseMove"/> event.
/// </summary>
public readonly struct MouseMoveEventArgs
{
    internal MouseMoveEventArgs(PointF position)
    {
        Position = position;
    }
 
    /// <summary>Gets the position of the pointer, in pixels.</summary>
    /// <value>
    /// The position relative to the top-left corner of the content area; the Y axis points down.
    /// The coordinates can be fractional.
    /// </value>
    public PointF Position { get; }
}