using System.Drawing;
using System.Runtime.Versioning;
using Redplcs.Windowing.Platform.Linux;
using Redplcs.Windowing.Platform.Windows;

namespace Redplcs.Windowing;

/// <summary>
/// Specifies how a window is created.
/// </summary>
/// <remarks>
/// The values are read by <see cref="WindowingSystem.CreateWindow(WindowOptions?)"/> during the call.
/// </remarks>
public sealed class WindowOptions
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WindowOptions"/> class with the default values.
    /// </summary>
    public WindowOptions() {}

    /// <summary>
    /// Gets or sets the title of the window.
    /// </summary>
    /// <value>The title. The default is an empty string.</value>
    /// <exception cref="ArgumentNullException">The value is <see langword="null"/>.</exception>
    public string Title
    {
        get;
        set
        {
            ArgumentNullException.ThrowIfNull(value);
            field = value;
        }
    } = string.Empty;
    
    /// <summary>
    /// Gets or sets the requested size of the content area, in DPI-independent units.
    /// </summary>
    /// <value>The requested size. The default is 800 by 600.</value>
    /// <remarks>
    /// The size is requested in logical units because the monitor, and therefore the scale, is not known
    /// before the window is created.
    /// </remarks>
    /// <exception cref="ArgumentOutOfRangeException">The width or the height is not positive or is not finite.</exception>
    public SizeF LogicalSize
    {
        get;
        set
        {
            ArgumentOutOfRangeException.ThrowIfNotFinite(value.Width, nameof(value));
            ArgumentOutOfRangeException.ThrowIfNotFinite(value.Height, nameof(value));
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value.Width, nameof(value));
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value.Height, nameof(value));
            field = value;
        }
    } = new(800, 600);

    /// <summary>
    /// Gets the creation parameters that are specific to Win32.
    /// </summary>
    /// <value>The Win32 section. It is created on first access.</value>
    /// <exception cref="PlatformNotSupportedException">The current operating system is not Windows.</exception>
    [SupportedOSPlatform("windows")]
    public Win32WindowOptions Win32 => OperatingSystem.IsWindows()
        ? field ??= new Win32WindowOptions()
        : throw new PlatformNotSupportedException();
    
    /// <summary>
    /// Gets the creation parameters that are specific to Wayland.
    /// </summary>
    /// <value>The Wayland section. It is created on first access.</value>
    /// <remarks>
    /// On Linux the sections of all its windowing systems are available at the same time;
    /// the library reads the section of the one it is connected to.
    /// </remarks>
    /// <exception cref="PlatformNotSupportedException">The current operating system is not Linux.</exception>
    [SupportedOSPlatform("linux")]
    public WaylandWindowOptions Wayland => OperatingSystem.IsLinux()
        ? field ??= new WaylandWindowOptions()
        : throw new PlatformNotSupportedException();
}