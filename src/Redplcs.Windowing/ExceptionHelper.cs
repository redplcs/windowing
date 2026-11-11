using System.Numerics;
using System.Runtime.CompilerServices;

namespace Redplcs.Windowing;

internal static class ExceptionHelper
{
    extension(ArgumentOutOfRangeException)
    {
        internal static void ThrowIfNotFinite<T>(T value, [CallerArgumentExpression("value")] string? paramName = null) where T : INumberBase<T>
        {
            if (T.IsFinite(value))
                return;
            throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be a finite value.");
        }
        
        internal static void ThrowIfNotDefined<T>(T value, [CallerArgumentExpression("value")] string? paramName = null) where T : struct, Enum
        {
            if (Enum.IsDefined(value))
                return;
            throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') is not defined in enum '{typeof(T)}'.");
        }
    }
}