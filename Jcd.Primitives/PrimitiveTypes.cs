using System;
using System.Collections.Generic;
using System.Linq;
// ReSharper disable MemberCanBePrivate.Global

namespace Jcd.Primitives;

/// <summary>
/// A helper class that provides some niche use case
/// properties for primitive numeric types and boolean.
/// </summary>
public static class PrimitiveTypes
{
    /// <summary>
    /// Returns the full set of CLR verifiable numeric types and boolean.
    /// (i.e. nint and nuint cannot be included as certain operations
    /// such as sizeof() are not supported outside of an unsafe context)
    /// </summary>
    public static readonly IReadOnlyList<Type> NumericTypesAndBoolean =new []
    {
        typeof(bool),
        typeof(byte),
        typeof(sbyte),
        typeof(short),
        typeof(ushort),
        typeof(int),
        typeof(uint),
        typeof(float),
        typeof(long),
        typeof(ulong),
        typeof(double),
        typeof(decimal)
    };

    /// <summary>
    /// Gets the cross product of all values in NumericTypesAndBoolean as <c>TypePairing</c> instances.
    /// </summary>
    public static readonly IReadOnlyList<TypePairing> CrossProductOfAllNumericTypesAndBoolean =
        NumericTypesAndBoolean
            .SelectMany(
                // ReSharper disable once UnusedParameter.Local
                 t1 => NumericTypesAndBoolean, 
                (t1, t2) => new TypePairing(t1, t2)
            )
        .ToArray();
}