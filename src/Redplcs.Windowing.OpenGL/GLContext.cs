using System.ComponentModel;

namespace Redplcs.Windowing.OpenGL;

/// <summary>Represents an OpenGL context together with the drawing surface of a window.</summary>
/// <remarks>
/// <para>A window can have one context at a time.</para>
/// <para>The context must be used only from the connection thread of its window.</para>
/// <para>
/// The format of the default framebuffer is fixed: 8 bits per channel of RGBA color, a 24-bit depth buffer,
/// an 8-bit stencil buffer, double buffering.
/// </para>
/// <para>
/// The context must be disposed before its window. After the window is disposed, <see cref="MakeCurrent"/> and
/// <see cref="SwapBuffers"/> throw <see cref="ObjectDisposedException"/>.
/// </para>
/// </remarks>
public sealed class GLContext : IDisposable
{
    private GLContext() {}
    
    /// <summary>Creates an OpenGL context for a window.</summary>
    /// <param name="window">The window to render to.</param>
    /// <param name="options">
    /// The options of the context, or <see langword="null"/> to use the defaults. The values are read during the call.
    /// </param>
    /// <returns>The new context. It is not made current.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="window"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException">
    /// <paramref name="window"/> already has a context, or the method is called from a thread other than
    /// the connection thread of the window.
    /// </exception>
    /// <exception cref="ObjectDisposedException"><paramref name="window"/> has been disposed.</exception>
    /// <exception cref="PlatformNotSupportedException">
    /// The driver does not support the requested version or profile, a system library the module needs is missing
    /// (its name is in the message), or <paramref name="window"/> has no native handles.
    /// </exception>
    /// <exception cref="Win32Exception">A native call failed.</exception>
    public static GLContext Create(Window window, GLContextOptions? options = null) => throw new NotImplementedException();
    
    /// <summary>Makes the context current on the calling thread.</summary>
    /// <remarks>When several windows are rendered from one thread, call the method at the start of each redraw handler.</remarks>
    /// <exception cref="InvalidOperationException">The method is called from a thread other than the connection thread of the window.</exception>
    /// <exception cref="ObjectDisposedException">The context or its window has been disposed.</exception>
    public void MakeCurrent() => throw new NotImplementedException();
    
    /// <summary>Presents the rendered frame.</summary>
    /// <remarks>
    /// <para>The method calls <see cref="Window.NotifyPresenting"/> itself.</para>
    /// <para>It does not block while the window is hidden.</para>
    /// <para>
    /// On Win32 the frame rate is limited by vertical synchronization with an interval of 1.
    /// On Wayland it is limited by <see cref="Window.RedrawRequested"/>.
    /// </para>
    /// <para>
    /// After <see cref="Window.Resized"/> the surface already has the new size: the module follows the event itself,
    /// and the application only has to update the viewport.
    /// </para>
    /// </remarks>
    /// <exception cref="InvalidOperationException">The context is not current on the calling thread.</exception>
    /// <exception cref="ObjectDisposedException">The context or its window has been disposed.</exception>
    public void SwapBuffers() => throw new NotImplementedException();
    
    /// <summary>Gets the address of an OpenGL function.</summary>
    /// <param name="name">The name of the function, for example <c>glClear</c>.</param>
    /// <returns>The address of the function, or 0 if the function is not available.</returns>
    /// <remarks>The method works for every function, including the OpenGL 1.1 functions on Windows.</remarks>
    /// <exception cref="ArgumentNullException"><paramref name="name"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException">The context is not current on the calling thread.</exception>
    /// <exception cref="ObjectDisposedException">The context has been disposed.</exception>
    public nint GetProcAddress(string name) => throw new NotImplementedException();
    
    /// <summary>Destroys the context and its drawing surface.</summary>
    /// <remarks>
    /// If the context is current, it is released first. Calling the method more than once has no effect.
    /// </remarks>
    public void Dispose() => throw new NotImplementedException();
}