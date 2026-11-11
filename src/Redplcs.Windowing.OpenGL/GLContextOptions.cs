namespace Redplcs.Windowing.OpenGL;

/// <summary>Specifies how an OpenGL context is created.</summary>
/// <remarks>
/// The values are read by <see cref="GLContext.Create(Window, GLContextOptions?)"/> during the call.
/// </remarks>
public sealed class GLContextOptions
{
    /// <summary>Initializes a new instance of the <see cref="GLContextOptions"/> class with the default values.</summary>
    public GLContextOptions() {}
    
    /// <summary>Gets or sets the minimum OpenGL version of the context.</summary>
    /// <value>
    /// The minimum version. Only the major and the minor numbers are used. The default is 3.3.
    /// </value>
    /// <remarks>The driver may create a context of a newer, compatible version.</remarks>
    /// <exception cref="ArgumentNullException">The value is <see langword="null"/>.</exception>
    public Version Version
    {
        get;
        set
        {
            ArgumentNullException.ThrowIfNull(value);
            field = value;
        }
    } = new(3, 3);
    
    /// <summary>Gets or sets the OpenGL profile of the context.</summary>
    /// <value>The profile. The default is <see cref="GLProfile.Core"/>.</value>
    /// <remarks>Versions below 3.2 have no profiles, so the value is ignored for them.</remarks>
    /// <exception cref="ArgumentOutOfRangeException">The value is not a defined profile.</exception>
    public GLProfile Profile
    {
        get;
        set
        {
            ArgumentOutOfRangeException.ThrowIfNotDefined(value);
            field = value;
        }
    } = GLProfile.Core;
}