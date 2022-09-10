// ReSharper disable UnusedType.Global
namespace Jcd.Primitives;

/// <summary>
/// Defines methods to support the comparison of two items of differing
/// types, which don't support IEquatable&lt;T1&gt; AND IEquatable&lt;T2&gt;
/// <remarks>
/// An inability to implement IEquatable&lt;T1&gt; AND IEquatable&lt;T2&gt;
/// on the same containing type is actually pretty common as
/// the "may unify..." compiler error message happens when the compiler
/// thinks there's a slight hint of a chance that T1 and T2 COULD become
/// the same data type.
/// 
/// Of course for IEquatable, and IComparable that's often perfectly
/// fine, not necessarily true of other operations tho.
/// </remarks>
/// </summary>
/// <typeparam name="T1">The first data type.</typeparam>
/// <typeparam name="T2">The second data type.</typeparam>
public interface IDisjointComparer<in T1, in T2>
{
    /// <summary>
    /// Compares an instance of T1 to an instance of T2.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    int Compare(T1 x, T2 y);
    
    /// <summary>
    /// Compares an instance of T1 to an instance of T2.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    int Compare(T2 x, T1 y);
}