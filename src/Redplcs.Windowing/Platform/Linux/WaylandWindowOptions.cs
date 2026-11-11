using System.Runtime.Versioning;

namespace Redplcs.Windowing.Platform.Linux;

/// <summary>
/// Contains the window creation parameters that are specific to Wayland.
/// </summary>
[SupportedOSPlatform("linux")]
public sealed class WaylandWindowOptions
{
    internal WaylandWindowOptions() {}
    
    /// <summary>
    /// Gets or sets the application identifier (<c>app_id</c>) of the window.
    /// </summary>
    /// <value>
    /// The identifier, passed to the compositor as is, or <see langword="null"/> to leave it unset.
    /// The default is <see langword="null"/>.
    /// </value>
    public string? AppId { get; set; }
}