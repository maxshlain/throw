using System;

namespace ThrowIf;

public static class ThrowIf
{
    /// <summary>Throws an <see cref="ArgumentNullException"/> if <paramref name="argument"/> is null.</summary>
    /// <param name="argument">The reference type argument to validate as non-null.</param>
    /// <param name="paramName">The name of the parameter with which <paramref name="argument"/> corresponds.</param>
    public static void IsNull(
        //[NotNull] object? argument, 
        object? argument,

        //[CallerArgumentExpression("argument")]
        string? paramName = null
        )
    {
        if (argument is null)
        {
            throw new Exception();
        }
    }
}
