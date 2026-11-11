namespace Redplcs.Windowing;

/// <summary>
/// The base class of the native handles of a window. Every windowing system has its own derived class.
/// </summary>
/// <remarks>
/// Only the library declares derived classes. The set can grow, so code that reads the handles
/// must handle an unknown kind.
/// </remarks>
public abstract class WindowHandle
{
    private protected WindowHandle() {}
}