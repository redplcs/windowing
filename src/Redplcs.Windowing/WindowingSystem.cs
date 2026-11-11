using System.ComponentModel;

namespace Redplcs.Windowing;

/// <summary>
/// A connection to the windowing system of the current platform, together with its event loop.
/// </summary>
/// <remarks>
/// <para>
/// A thread can have one live connection at a time. The connection and its windows must be used only
/// from the thread that called <see cref="Connect"/>; a call from any other thread throws
/// <see cref="InvalidOperationException"/>. The only member that is exempt is <see cref="Wake"/>.
/// </para>
/// <para>
/// Event handlers are invoked on the connection thread, one at a time and in queue order, from inside
/// <see cref="PumpEvents"/> and <see cref="WaitEvents()"/>.
/// </para>
/// <para>
/// After <see cref="Dispose"/> every member except <see cref="Wake"/> and <see cref="Dispose"/> throws
/// <see cref="ObjectDisposedException"/>.
/// </para>
/// </remarks>
public sealed class WindowingSystem : IDisposable
{
    private WindowingSystem() {}

    /// <summary>Connects the calling thread to the windowing system.</summary>
    /// <returns>A connection that is bound to the calling thread.</returns>
    /// <remarks>
    /// After the connection is disposed, the thread can connect again.
    /// </remarks>
    /// <exception cref="InvalidOperationException">The calling thread already has a live connection.</exception>
    /// <exception cref="PlatformNotSupportedException">
    /// The windowing system is unavailable: the operating system is not supported, a required system library
    /// is missing (its name is in the message), or no display server is running.
    /// </exception>
    /// <exception cref="Win32Exception">A native call failed.</exception>
    public static WindowingSystem Connect() => throw new NotImplementedException();
    
    /// <summary>Creates a window on this connection.</summary>
    /// <param name="options">
    /// The options of the window, or <see langword="null"/> to use the defaults. The values are read during
    /// the call: changing <paramref name="options"/> afterwards does not affect the window.
    /// </param>
    /// <returns>The new window. It is shown as soon as it is created.</returns>
    /// <remarks>
    /// <para>
    /// The requested size is a hint. The system may choose a different one (a tiling compositor, for example),
    /// so read the actual size from the window after it is created.
    /// </para>
    /// <para>On Wayland the window appears on screen only after its first frame has been presented.</para>
    /// <para>This method can be called from an event handler.</para>
    /// </remarks>
    /// <exception cref="InvalidOperationException">The method is called from a thread other than the connection thread.</exception>
    /// <exception cref="ObjectDisposedException">The connection has been disposed.</exception>
    /// <exception cref="Win32Exception">A native call failed.</exception>
    public Window CreateWindow(WindowOptions? options = null) => throw new NotImplementedException();
    
    /// <summary>
    /// Processes the pending events and invokes their handlers without waiting for new events.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The method reads everything the operating system has available and returns when the queue is empty.
    /// An event caused by a handler (a handler resized a window, for example) may be delivered by the same call.
    /// </para>
    /// <para><see cref="Window.RedrawRequested"/> is raised at most once per window per call.</para>
    /// <para>
    /// On Win32 the method does not return while the system runs a modal loop (the user is moving or resizing
    /// a window). Handlers keep being invoked during that time.
    /// </para>
    /// <para>
    /// An exception thrown by a handler is rethrown from this call with its original stack trace. No other handler
    /// is invoked before that, and the events that were not delivered wait for the next call. Inside a modal
    /// loop the exception is rethrown after the loop ends.
    /// </para>
    /// </remarks>
    /// <exception cref="InvalidOperationException">
    /// The method is called from an event handler, or from a thread other than the connection thread.
    /// </exception>
    /// <exception cref="ObjectDisposedException">The connection has been disposed.</exception>
    /// <exception cref="IOException">The connection to the windowing system is lost. The connection can only be disposed after that.</exception>
    public void PumpEvents() => throw new NotImplementedException();
    
    /// <summary>
    /// Waits until there is something to process or <see cref="Wake"/> is called, then processes the pending events.
    /// </summary>
    /// <remarks>
    /// The wait ends when an operating system event arrives, an internal timer fires (key repeat, for example),
    /// or <see cref="Wake"/> is called. If a reason already exists, the method does not wait.
    /// It then does the same as <see cref="PumpEvents"/>.
    /// </remarks>
    /// <exception cref="InvalidOperationException">
    /// The method is called from an event handler, or from a thread other than the connection thread.
    /// </exception>
    /// <exception cref="ObjectDisposedException">The connection has been disposed.</exception>
    /// <exception cref="IOException">The connection to the windowing system is lost. The connection can only be disposed after that.</exception>
    public void WaitEvents() => throw new NotImplementedException();
    
    /// <summary>
    /// Waits until there is something to process, <see cref="Wake"/> is called, or the time-out elapses,
    /// then processes the pending events.
    /// </summary>
    /// <param name="timeout">
    /// The maximum time to wait. <see cref="System.Threading.Timeout.InfiniteTimeSpan"/> waits without a limit,
    /// <see cref="TimeSpan.Zero"/> does not wait.
    /// </param>
    /// <returns>
    /// <see langword="false"/> if the time-out elapsed before there was anything to process; otherwise, <see langword="true"/>.
    /// A return value of <see langword="true"/> does not guarantee that a handler was invoked: the wake-up may be internal.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="timeout"/> is negative and is not <see cref="System.Threading.Timeout.InfiniteTimeSpan"/>,
    /// or is greater than <see cref="int.MaxValue"/> milliseconds.
    /// </exception>
    /// <exception cref="InvalidOperationException">
    /// The method is called from an event handler, or from a thread other than the connection thread.
    /// </exception>
    /// <exception cref="ObjectDisposedException">The connection has been disposed.</exception>
    /// <exception cref="IOException">The connection to the windowing system is lost. The connection can only be disposed after that.</exception>
    public bool WaitEvents(TimeSpan timeout) => throw new NotImplementedException();
    
    /// <summary>Interrupts the current or the next wait of <see cref="WaitEvents()"/>.</summary>
    /// <remarks>
    /// <para>This method can be called from any thread. It does not block, does not allocate and does not throw.</para>
    /// <para>
    /// A call is never lost: if no wait is in progress, the next one returns immediately.
    /// Several calls in a row count as one.
    /// </para>
    /// <para>After <see cref="Dispose"/> the method does nothing.</para>
    /// </remarks>
    public void Wake() => throw new NotImplementedException();
    
    /// <summary>Determines whether a feature works on this connection.</summary>
    /// <param name="feature">The feature to check.</param>
    /// <returns><see langword="true"/> if the feature is supported; otherwise, <see langword="false"/>.</returns>
    /// <remarks>
    /// <para>The answer does not change while the connection is alive.</para>
    /// <para>
    /// Members that belong to an unsupported feature throw <see cref="PlatformNotSupportedException"/>.
    /// When a feature is a behavior rather than a member, the behavior is described by the feature value.
    /// </para>
    /// </remarks>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="feature"/> is not a defined value.</exception>
    /// <exception cref="InvalidOperationException">The method is called from a thread other than the connection thread.</exception>
    /// <exception cref="ObjectDisposedException">The connection has been disposed.</exception>
    public bool IsSupported(WindowingFeature feature) => throw new NotImplementedException();
    
    /// <summary>
    /// Destroys the windows that are still alive, discards the events that were not delivered and closes the connection.
    /// </summary>
    /// <remarks>Calling this method more than once has no effect.</remarks>
    /// <exception cref="InvalidOperationException">
    /// The method is called from an event handler, or from a thread other than the connection thread.
    /// </exception>
    public void Dispose() => throw new NotImplementedException();
}