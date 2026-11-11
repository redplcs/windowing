using System.Runtime.Versioning;

namespace Redplcs.Windowing.Platform.Windows;

/// <summary>
/// Contains the window creation parameters that are specific to Win32.
/// </summary>
[SupportedOSPlatform("windows")]
public sealed class Win32WindowOptions
{
    internal Win32WindowOptions() {}
    
    /// <summary>
    /// Gets or sets the class style flags (<c>CS_*</c>) that are added to the window class.
    /// </summary>
    /// <value>A bitwise combination of class style values. The default is 0.</value>
    /// <remarks>The library always registers the window class with <c>CS_OWNDC</c>.</remarks>
    public int ClassStyle { get; set; }
}