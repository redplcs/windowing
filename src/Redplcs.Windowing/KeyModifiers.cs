namespace Redplcs.Windowing;

/// <summary>
/// Specifies the modifier keys that are held down.
/// </summary>
[Flags]
public enum KeyModifiers
{
    /// <summary>No modifier key is held down.</summary>
    None = 0,
 
    /// <summary>A Shift key.</summary>
    Shift = 1,
 
    /// <summary>A Control key.</summary>
    Control = 2,
 
    /// <summary>An Alt key.</summary>
    Alt = 4,
 
    /// <summary>A Super key: the Windows key or the Command key.</summary>
    Super = 8,
}