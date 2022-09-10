using System;

// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBePrivate.Global

namespace Jcd.Primitives;

/// <summary>
/// Represents a unique pairing of two types.
/// </summary>
/// <remarks>A pairing is considered identical for x and y if:
///      x.First==y.First &amp;&amp; x.Second==y.Second
/// -- OR --
///      x.First==y.Second &amp;&amp; x.Second==y.First
///
/// To help with other operations, the hashcode is computed such that it's the same for any T1 and T2
/// regardless if T1 or T2 are first or second.
/// </remarks>
public readonly struct TypePairing :
    IEquatable<TypePairing>
{
    /// <summary>
    ///  The first type in the pairing.
    /// </summary>
    public Type First { get; }
    
    /// <summary>
    /// The second type in the pairing.
    /// </summary>
    public Type Second { get; }
    
    /// <summary>
    /// Indicates if the pairing is an identity pairing. 
    /// </summary>
    public bool AreSameType => First == Second;

    /// <summary>
    /// Constructs an instance of TypePairing from two instances of Type.
    /// </summary>
    /// <param name="first"></param>
    /// <param name="second"></param>
    public TypePairing(Type first, Type second) => 
        (First,Second) =(first,second);
    
    /// <inheritdoc />
    public bool Equals(TypePairing other)
    {
        return (First == other.First  && Second == other.Second) ||
               (First == other.Second && Second == other.First)
            ;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        return (First.GetHashCode() ^ Second.GetHashCode()) ^ 397;
    }

    /// <summary>
    /// The format string for a TypePairing.
    /// * {0} is the type name of First.
    /// * {1} is the type name of Second.
    /// </summary>
    public const string FormatString = $"{nameof(TypePairing)}" +": {0}, {1}";
    
    /// <inheritdoc />
    public override string ToString()
    {
        return string.Format(FormatString, First.Name, Second.Name);
    }
}