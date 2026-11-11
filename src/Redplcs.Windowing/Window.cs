using System.Drawing;

namespace Redplcs.Windowing;

/// <summary>Represents a top-level window.</summary>
/// <remarks>
/// <para>
/// A window is created by <see cref="WindowingSystem.CreateWindow(WindowOptions?)"/> and lives no longer than
/// its connection. Its members must be used only from the connection thread; a call from any other thread
/// throws <see cref="InvalidOperationException"/>.
/// </para>
/// <para>
/// Events are raised on the connection thread, and the sender is the window. Properties show the last known state.
/// </para>
/// <para>
/// All sizes and coordinates are in pixels unless the name of a member contains <c>Logical</c>.
/// </para>
/// <para>After <see cref="Dispose"/> every member except <see cref="Dispose"/> throws <see cref="ObjectDisposedException"/>.</para>
/// </remarks>
public sealed class Window : IDisposable
{
    private Window() {}
    
// TODO: The events are raised by the backends, which do not exist yet.
#pragma warning disable CS0067
    
    /// <summary>Occurs when the size of the content area or the scale has changed.</summary>
    /// <remarks>
    /// <para>
    /// The event is raised when at least one of <see cref="Size"/>, <see cref="LogicalSize"/> and <see cref="Scale"/>
    /// has changed. Several changes in a row are merged into one event that carries the latest state,
    /// the same state the properties of the window show.
    /// </para>
    /// <para>The event is not raised after the window is created, and is not raised when the window is minimized.</para>
    /// <para>On Win32 it is also raised while the user is dragging the frame.</para>
    /// <para>The next frame the application presents must have the new <see cref="Size"/>.</para>
    /// </remarks>
    public event EventHandler<ResizedEventArgs>? Resized;

    /// <summary>Occurs when the user or the system asks to close the window.</summary>
    /// <remarks>
    /// <para>The request comes from the close button, a keyboard shortcut such as Alt+F4, or a compositor command.</para>
    /// <para>
    /// The library never closes the window itself. To close it, call <see cref="Dispose"/>, which is allowed
    /// inside the handler. If the handler does not, the request is cancelled.
    /// </para>
    /// <para>If nobody is subscribed to the event, the request is ignored.</para>
    /// </remarks>
    public event EventHandler? CloseRequested;
        
    /// <summary>Occurs when the window should be redrawn.</summary>
    /// <remarks>
    /// <para>
    /// The event follows a call to <see cref="RequestRedraw"/>. It can also be raised without a request,
    /// when the system asks to redraw the window.
    /// </para>
    /// <para>
    /// On Wayland the event is raised when the compositor is ready for the next frame; it is not raised while
    /// the window is hidden. On Win32 it is raised the next time events are processed, including while the user
    /// is moving the window; it is not raised while the window is minimized, and the request is kept.
    /// </para>
    /// <para>
    /// When both <see cref="Resized"/> and this event are pending, <see cref="Resized"/> is raised first.
    /// The event is raised at most once per window per call of <see cref="WindowingSystem.PumpEvents"/> or
    /// <see cref="WindowingSystem.WaitEvents()"/>.
    /// </para>
    /// <para>Use the event only for drawing: it may not be raised for an arbitrarily long time.</para>
    /// </remarks>
    public event EventHandler? RedrawRequested;
    
    /// <summary>Occurs when a key is pressed, and repeatedly while it is held down.</summary>
    /// <remarks>
    /// <para>The event is raised for the window that has keyboard focus.</para>
    /// <para>Keys that are already down when the window gains focus do not raise the event.</para>
    /// <para>The event carries no characters. Text input is a separate event.</para>
    /// </remarks>
    public event EventHandler<KeyEventArgs>? KeyDown;
    
    /// <summary>Occurs when a key is released.</summary>
    /// <remarks>
    /// When the window loses keyboard focus, the event is raised for every key that is still down,
    /// so that keys do not stay pressed in the state of the application.
    /// </remarks>
    public event EventHandler<KeyEventArgs>? KeyUp;
    
    /// <summary>Occurs when the mouse pointer moves over the content area.</summary>
    /// <remarks>
    /// While a mouse button is held down, the window where it was pressed keeps receiving this event even when
    /// the pointer leaves the window. The coordinates are then outside the bounds of the window.
    /// </remarks>
    public event EventHandler<MouseMoveEventArgs>? MouseMove;
    
    /// <summary>Occurs when a mouse button is pressed.</summary>
    /// <remarks>The library does not detect double clicks: two ordinary presses are reported.</remarks>
    public event EventHandler<MouseButtonEventArgs>? MouseDown;
 
    /// <summary>Occurs when a mouse button is released.</summary>
    /// <remarks>The event is delivered to the window where the button was pressed, even if the pointer has left it.</remarks>
    public event EventHandler<MouseButtonEventArgs>? MouseUp;
    
    /// <summary>Occurs when the mouse wheel is rotated or a touchpad is scrolled.</summary>
    /// <remarks>Vertical and horizontal scrolling are reported by one event.</remarks>
    public event EventHandler<MouseWheelEventArgs>? MouseWheel;
 
    /// <summary>Occurs when the mouse pointer enters the content area.</summary>
    /// <remarks>The event is immediately followed by <see cref="MouseMove"/> with the coordinates.</remarks>
    public event EventHandler? MouseEnter;
 
    /// <summary>Occurs when the mouse pointer leaves the content area.</summary>
    /// <remarks>While a mouse button is held down, the event is postponed until the button is released.</remarks>
    public event EventHandler? MouseLeave;
    
#pragma warning restore CS0067
    
    /// <summary>Gets or sets the title of the window.</summary>
    /// <value>The title.</value>
    /// <exception cref="ArgumentNullException">The value is <see langword="null"/>.</exception>
    public string Title
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
    
    /// <summary>Gets the size of the content area, in pixels.</summary>
    /// <value>The size the application must render its frames at. It is always positive, also for a minimized window.</value>
    /// <remarks>
    /// <para>The size does not include the frame and the title bar.</para>
    /// <para>
    /// It equals <see cref="LogicalSize"/> multiplied by <see cref="Scale"/> and rounded to integers.
    /// The three values always describe one state and change together.
    /// </para>
    /// </remarks>
    public Size Size => throw new NotImplementedException();
    
    /// <summary>Gets the size of the content area, in DPI-independent units.</summary>
    /// <value>The same size as <see cref="Size"/>, in logical units.</value>
    /// <remarks>Store this value to restore the size of the window later: on a monitor with another DPI the window gets the same visible size.</remarks>
    public SizeF LogicalSize => throw new NotImplementedException();
    
    /// <summary>Gets the number of pixels per logical unit.</summary>
    /// <value>
    /// The scale. It is 1.0 until the system reports another value. On Windows it is the DPI of the monitor
    /// divided by 96 and can be fractional.
    /// </value>
    public double Scale => throw new NotImplementedException();
    
    /// <summary>Gets the native handles of the window.</summary>
    /// <value>
    /// An object that is specific to the windowing system, or <see langword="null"/> if the window has no native handles.
    /// </value>
    /// <remarks>
    /// <para>
    /// Every windowing system has its own class derived from <see cref="WindowHandle"/>. New ones can be added,
    /// so code that reads the handles must handle an unknown kind.
    /// </para>
    /// <para>
    /// The property returns the same object on every call. The object is immutable: it can be passed to another
    /// thread and used for rendering there.
    /// </para>
    /// <para>
    /// The handles of the window are valid until <see cref="Dispose"/>. A surface of a graphics API must be destroyed
    /// before the window. After <see cref="Dispose"/> the values in an object obtained earlier are invalid,
    /// and there is no way to check that.
    /// </para>
    /// <para>The application must not destroy the native objects or replace their window procedure or listeners.</para>
    /// </remarks>
    public WindowHandle? Handle => throw new NotImplementedException();
    
    /// <summary>Asks the system to change the size of the content area.</summary>
    /// <param name="logicalSize">The requested size, in DPI-independent units.</param>
    /// <remarks>
    /// <para>The size is a hint: a maximized or a tiled window does not accept it.</para>
    /// <para>The properties of the window do not change at once. The new size arrives with <see cref="Resized"/>.</para>
    /// <para>To request an exact size in pixels, divide the pixels by <see cref="Scale"/>.</para>
    /// </remarks>
    /// <exception cref="ArgumentOutOfRangeException">The width or the height is not positive or is not finite.</exception>
    public void Resize(SizeF logicalSize) => throw new NotImplementedException();
    
    /// <summary>Requests one <see cref="RedrawRequested"/> event.</summary>
    /// <remarks>
    /// The request is one-shot. Calling the method again before the event is raised adds nothing.
    /// The method can be called both inside and outside an event handler.
    /// </remarks>
    public void RequestRedraw() => throw new NotImplementedException();
 
    /// <summary>Tells the window that the application is about to present a frame.</summary>
    /// <remarks>
    /// <para>
    /// Call the method right before presenting (<c>Present</c> in Direct3D, <c>vkQueuePresentKHR</c> in Vulkan),
    /// and only when a frame is really going to be presented. The OpenGL module calls it from
    /// <c>GLContext.SwapBuffers</c>, so it is called by hand only by code that presents with another API.
    /// </para>
    /// <para>On Win32 the method does nothing.</para>
    /// <para>
    /// If it is not called on Wayland, <see cref="RedrawRequested"/> is raised at once, without a frame rate limit,
    /// and a Vulkan swapchain in FIFO mode may block while the window is hidden.
    /// </para>
    /// </remarks>
    public void NotifyPresenting() => throw new NotImplementedException();
    
    /// <summary>Destroys the window.</summary>
    /// <remarks>
    /// <para>No events of the window are raised after that.</para>
    /// <para>The method can be called from an event handler of the same window. Calling it more than once has no effect.</para>
    /// <para>Windows the application did not destroy are destroyed by <see cref="WindowingSystem.Dispose"/>.</para>
    /// </remarks>
    public void Dispose() => throw new NotImplementedException();
}