using System.Runtime.Versioning;

namespace Redplcs.Windowing.Platform.Linux;

/// <summary>
/// Contains the native handles of a Wayland window.
/// </summary>
[SupportedOSPlatform("linux")]
public sealed class WaylandWindowHandle : WindowHandle
{
    internal WaylandWindowHandle(nint display, nint surface)
    {
        (Display, Surface) = (display, surface);
    }
 
    /// <summary>Gets the connection to the compositor (<c>wl_display*</c>).</summary>
    /// <value>The pointer. It is valid until the <see cref="WindowingSystem"/> is disposed.</value>
    public nint Display { get; }
 
    /// <summary>Gets the surface of the window (<c>wl_surface*</c>).</summary>
    /// <value>The pointer. It is valid until the window is disposed.</value>
    public nint Surface { get; }
}