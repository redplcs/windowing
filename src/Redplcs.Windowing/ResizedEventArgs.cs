using System.Drawing;

namespace Redplcs.Windowing;

/// <summary>Provides data for the <see cref="Window.Resized"/> event.</summary>
public readonly struct ResizedEventArgs
{
    internal ResizedEventArgs(Size size, SizeF logicalSize, double scale)
    {
        (Size, LogicalSize, Scale) = (size, logicalSize, scale);
    }
 
    /// <summary>Gets the new size of the content area, in pixels.</summary>
    /// <value>The size, the same as <see cref="Window.Size"/>.</value>
    public Size Size { get; }
 
    /// <summary>Gets the new size of the content area, in DPI-independent units.</summary>
    /// <value>The size, the same as <see cref="Window.LogicalSize"/>.</value>
    public SizeF LogicalSize { get; }
 
    /// <summary>Gets the new number of pixels per logical unit.</summary>
    /// <value>The scale, the same as <see cref="Window.Scale"/>.</value>
    public double Scale { get; }
}