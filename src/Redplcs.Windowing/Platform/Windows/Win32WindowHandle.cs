using System.Runtime.Versioning;

namespace Redplcs.Windowing.Platform.Windows;

/// <summary>
/// Contains the native handles of a Win32 window.
/// </summary>
[SupportedOSPlatform("windows")]
public sealed class Win32WindowHandle : WindowHandle
{
    internal Win32WindowHandle(nint hwnd, nint hinstance)
    {
        (Hwnd, Hinstance) = (hwnd, hinstance);
    }
    
    /// <summary>Gets the window handle (<c>HWND</c>).</summary>
    /// <value>The handle. It is valid until the window is disposed.</value>
    public nint Hwnd { get; }
 
    /// <summary>Gets the handle of the module the window belongs to (<c>HINSTANCE</c>).</summary>
    /// <value>The handle. It is valid until the process exits.</value>
    public nint Hinstance { get; }
}