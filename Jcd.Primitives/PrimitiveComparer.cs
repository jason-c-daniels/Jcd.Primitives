using System;
// ReSharper disable CompareOfFloatsByEqualityOperator
// ReSharper disable RedundantCast

namespace Jcd.Primitives;

/// <summary>
/// A primitive type comparer. Intended for use with GenericPrimitiveTypeComparer.
/// </summary>
public static class PrimitiveComparer
{
    #region [Boolean and Byte Comparisons]

    /// <summary>
    /// Checks a Boolean and a Byte for equality
    /// Zero converts to false and non-zero to true.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Boolean x, Byte y)
    {
         var y1 = y != 0;
         return x == y1;
    }

    /// <summary>
    /// Checks a Byte and a Boolean for equality
    /// Zero converts to false and non-zero to true.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Byte x, Boolean y)
    {
         var x1 = x != 0;
         return x1 == y;
    }
    #endregion // [Boolean and Byte Comparisons]

    #region [Boolean and SByte Comparisons]

    /// <summary>
    /// Checks a Boolean and a SByte for equality
    /// Zero converts to false and non-zero to true.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Boolean x, SByte y)
    {
         var y1 = y != 0;
         return x == y1;
    }

    /// <summary>
    /// Checks a SByte and a Boolean for equality
    /// Zero converts to false and non-zero to true.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(SByte x, Boolean y)
    {
         var x1 = x != 0;
         return x1 == y;
    }
    #endregion // [Boolean and SByte Comparisons]

    #region [Boolean and Int16 Comparisons]

    /// <summary>
    /// Checks a Boolean and a Int16 for equality
    /// Zero converts to false and non-zero to true.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Boolean x, Int16 y)
    {
         var y1 = y != 0;
         return x == y1;
    }

    /// <summary>
    /// Checks a Int16 and a Boolean for equality
    /// Zero converts to false and non-zero to true.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int16 x, Boolean y)
    {
         var x1 = x != 0;
         return x1 == y;
    }
    #endregion // [Boolean and Int16 Comparisons]

    #region [Boolean and UInt16 Comparisons]

    /// <summary>
    /// Checks a Boolean and a UInt16 for equality
    /// Zero converts to false and non-zero to true.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Boolean x, UInt16 y)
    {
         var y1 = y != 0;
         return x == y1;
    }

    /// <summary>
    /// Checks a UInt16 and a Boolean for equality
    /// Zero converts to false and non-zero to true.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt16 x, Boolean y)
    {
         var x1 = x != 0;
         return x1 == y;
    }
    #endregion // [Boolean and UInt16 Comparisons]

    #region [Boolean and Int32 Comparisons]

    /// <summary>
    /// Checks a Boolean and a Int32 for equality
    /// Zero converts to false and non-zero to true.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Boolean x, Int32 y)
    {
         var y1 = y != 0;
         return x == y1;
    }

    /// <summary>
    /// Checks a Int32 and a Boolean for equality
    /// Zero converts to false and non-zero to true.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int32 x, Boolean y)
    {
         var x1 = x != 0;
         return x1 == y;
    }
    #endregion // [Boolean and Int32 Comparisons]

    #region [Boolean and UInt32 Comparisons]

    /// <summary>
    /// Checks a Boolean and a UInt32 for equality
    /// Zero converts to false and non-zero to true.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Boolean x, UInt32 y)
    {
         var y1 = y != 0;
         return x == y1;
    }

    /// <summary>
    /// Checks a UInt32 and a Boolean for equality
    /// Zero converts to false and non-zero to true.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt32 x, Boolean y)
    {
         var x1 = x != 0;
         return x1 == y;
    }
    #endregion // [Boolean and UInt32 Comparisons]

    #region [Boolean and Single Comparisons]

    /// <summary>
    /// Checks a Boolean and a Single for equality
    /// Zero converts to false and non-zero to true.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Boolean x, Single y)
    {
         var y1 = y != 0;
         return x == y1;
    }

    /// <summary>
    /// Checks a Single and a Boolean for equality
    /// Zero converts to false and non-zero to true.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Single x, Boolean y)
    {
         var x1 = x != 0;
         return x1 == y;
    }
    #endregion // [Boolean and Single Comparisons]

    #region [Boolean and Int64 Comparisons]

    /// <summary>
    /// Checks a Boolean and a Int64 for equality
    /// Zero converts to false and non-zero to true.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Boolean x, Int64 y)
    {
         var y1 = y != 0;
         return x == y1;
    }

    /// <summary>
    /// Checks a Int64 and a Boolean for equality
    /// Zero converts to false and non-zero to true.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int64 x, Boolean y)
    {
         var x1 = x != 0;
         return x1 == y;
    }
    #endregion // [Boolean and Int64 Comparisons]

    #region [Boolean and UInt64 Comparisons]

    /// <summary>
    /// Checks a Boolean and a UInt64 for equality
    /// Zero converts to false and non-zero to true.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Boolean x, UInt64 y)
    {
         var y1 = y != 0;
         return x == y1;
    }

    /// <summary>
    /// Checks a UInt64 and a Boolean for equality
    /// Zero converts to false and non-zero to true.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt64 x, Boolean y)
    {
         var x1 = x != 0;
         return x1 == y;
    }
    #endregion // [Boolean and UInt64 Comparisons]

    #region [Boolean and Double Comparisons]

    /// <summary>
    /// Checks a Boolean and a Double for equality
    /// Zero converts to false and non-zero to true.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Boolean x, Double y)
    {
         var y1 = y != 0;
         return x == y1;
    }

    /// <summary>
    /// Checks a Double and a Boolean for equality
    /// Zero converts to false and non-zero to true.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Double x, Boolean y)
    {
         var x1 = x != 0;
         return x1 == y;
    }
    #endregion // [Boolean and Double Comparisons]

    #region [Boolean and Decimal Comparisons]

    /// <summary>
    /// Checks a Boolean and a Decimal for equality
    /// Zero converts to false and non-zero to true.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Boolean x, Decimal y)
    {
         var y1 = y != 0;
         return x == y1;
    }

    /// <summary>
    /// Checks a Decimal and a Boolean for equality
    /// Zero converts to false and non-zero to true.
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Decimal x, Boolean y)
    {
         var x1 = x != 0;
         return x1 == y;
    }
    #endregion // [Boolean and Decimal Comparisons]

    #region [Byte and SByte Comparisons]

    /// <summary>
    /// Checks a SByte and a Byte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(SByte x, Byte y)
    {
        if ( x < 0 || y > SByte.MaxValue) return false;
        return ((Byte)x).Equals(y);
    }

    /// <summary>
    /// Checks a Byte and a SByte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Byte x, SByte y)
    {
        if ( y < 0 || x > SByte.MaxValue) return false;
        return x.Equals((Byte)y);
    }

    /// <summary>
    /// Compares a SByte to a Byte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(SByte x, Byte y)
    {
        if (x < 0) return -1;
        if (y > SByte.MaxValue) return -1;
        return ((Byte)x).CompareTo(y);
    }

    /// <summary>
    /// Compares a Byte to a SByte 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Byte x, SByte y)
    {
        if (y < 0) return 1;
        if (x > SByte.MaxValue) return 1;
        return x.CompareTo((Byte)y);
    }

    #endregion // [Byte and SByte Comparisons]

    #region [UInt16 and Byte Comparisons]

    /// <summary>
    /// Checks a UInt16 and a Byte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt16 x, Byte y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a Byte and a UInt16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Byte x, UInt16 y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a UInt16 to a Byte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt16 x, Byte y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a Byte to a UInt16 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Byte x, UInt16 y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [UInt16 and Byte Comparisons]

    #region [UInt16 and SByte Comparisons]

    /// <summary>
    /// Checks a SByte and a UInt16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(SByte x, UInt16 y)
    {
		if (x < 0 || y > (UInt16)SByte.MaxValue) return false;
		return ((UInt16)x) == y;
    }

    /// <summary>
    /// Checks a UInt16 and a SByte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt16 x, SByte y)
    {
		if (y < 0 || x > (UInt16)SByte.MaxValue) return false;
		return x == (UInt16)y;
    }

    /// <summary>
    /// Compares a SByte to a UInt16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(SByte x, UInt16 y)
    {
		if (x < 0) return -1;
		if (y > (UInt16)SByte.MaxValue) return -1;
		return ((UInt16)x).CompareTo(y);
    }

    /// <summary>
    /// Compares a UInt16 to a SByte 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt16 x, SByte y)
    {
		if (y < 0) return 1;
		if (x > (UInt16)SByte.MaxValue) return 1;
		return x.CompareTo((UInt16)y);
    }
    #endregion // [UInt16 and SByte Comparisons]

    #region [UInt16 and Int16 Comparisons]

    /// <summary>
    /// Checks a Int16 and a UInt16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int16 x, UInt16 y)
    {
        if ( x < 0 || y > Int16.MaxValue) return false;
        return ((UInt16)x).Equals(y);
    }

    /// <summary>
    /// Checks a UInt16 and a Int16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt16 x, Int16 y)
    {
        if ( y < 0 || x > Int16.MaxValue) return false;
        return x.Equals((UInt16)y);
    }

    /// <summary>
    /// Compares a Int16 to a UInt16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int16 x, UInt16 y)
    {
        if (x < 0) return -1;
        if (y > Int16.MaxValue) return -1;
        return ((UInt16)x).CompareTo(y);
    }

    /// <summary>
    /// Compares a UInt16 to a Int16 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt16 x, Int16 y)
    {
        if (y < 0) return 1;
        if (x > Int16.MaxValue) return 1;
        return x.CompareTo((UInt16)y);
    }

    #endregion // [UInt16 and Int16 Comparisons]

    #region [Int16 and Byte Comparisons]

    /// <summary>
    /// Checks a Int16 and a Byte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int16 x, Byte y)
    {
		if (x < 0) return false;
		return x == y;
    }

    /// <summary>
    /// Checks a Byte and a Int16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Byte x, Int16 y)
    {
		if (y < 0) return false;
		return x == y;
    }

    /// <summary>
    /// Compares a Int16 to a Byte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int16 x, Byte y)
    {
		return x < 0 ? -1 : x.CompareTo(y);
    }

    /// <summary>
    /// Compares a Byte to a Int16 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Byte x, Int16 y)
    {
		return y < 0 ? 1 : ((Int16)x).CompareTo(y);
    }
    #endregion // [Int16 and Byte Comparisons]

    #region [Int16 and SByte Comparisons]

    /// <summary>
    /// Checks a Int16 and a SByte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int16 x, SByte y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a SByte and a Int16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(SByte x, Int16 y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a Int16 to a SByte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int16 x, SByte y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a SByte to a Int16 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(SByte x, Int16 y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [Int16 and SByte Comparisons]

    #region [UInt32 and Byte Comparisons]

    /// <summary>
    /// Checks a UInt32 and a Byte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt32 x, Byte y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a Byte and a UInt32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Byte x, UInt32 y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a UInt32 to a Byte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt32 x, Byte y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a Byte to a UInt32 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Byte x, UInt32 y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [UInt32 and Byte Comparisons]

    #region [UInt32 and SByte Comparisons]

    /// <summary>
    /// Checks a SByte and a UInt32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(SByte x, UInt32 y)
    {
		if (x < 0 || y > (UInt32)SByte.MaxValue) return false;
		return ((UInt32)x) == y;
    }

    /// <summary>
    /// Checks a UInt32 and a SByte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt32 x, SByte y)
    {
		if (y < 0 || x > (UInt32)SByte.MaxValue) return false;
		return x == (UInt32)y;
    }

    /// <summary>
    /// Compares a SByte to a UInt32
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(SByte x, UInt32 y)
    {
		if (x < 0) return -1;
		if (y > (UInt32)SByte.MaxValue) return -1;
		return ((UInt32)x).CompareTo(y);
    }

    /// <summary>
    /// Compares a UInt32 to a SByte 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt32 x, SByte y)
    {
		if (y < 0) return 1;
		if (x > (UInt32)SByte.MaxValue) return 1;
		return x.CompareTo((UInt32)y);
    }
    #endregion // [UInt32 and SByte Comparisons]

    #region [UInt32 and Int16 Comparisons]

    /// <summary>
    /// Checks a Int16 and a UInt32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int16 x, UInt32 y)
    {
		if (x < 0 || y > (UInt32)Int16.MaxValue) return false;
		return ((UInt32)x) == y;
    }

    /// <summary>
    /// Checks a UInt32 and a Int16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt32 x, Int16 y)
    {
		if (y < 0 || x > (UInt32)Int16.MaxValue) return false;
		return x == (UInt32)y;
    }

    /// <summary>
    /// Compares a Int16 to a UInt32
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int16 x, UInt32 y)
    {
		if (x < 0) return -1;
		if (y > (UInt32)Int16.MaxValue) return -1;
		return ((UInt32)x).CompareTo(y);
    }

    /// <summary>
    /// Compares a UInt32 to a Int16 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt32 x, Int16 y)
    {
		if (y < 0) return 1;
		if (x > (UInt32)Int16.MaxValue) return 1;
		return x.CompareTo((UInt32)y);
    }
    #endregion // [UInt32 and Int16 Comparisons]

    #region [UInt32 and UInt16 Comparisons]

    /// <summary>
    /// Checks a UInt32 and a UInt16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt32 x, UInt16 y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a UInt16 and a UInt32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt16 x, UInt32 y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a UInt32 to a UInt16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt32 x, UInt16 y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a UInt16 to a UInt32 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt16 x, UInt32 y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [UInt32 and UInt16 Comparisons]

    #region [UInt32 and Int32 Comparisons]

    /// <summary>
    /// Checks a Int32 and a UInt32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int32 x, UInt32 y)
    {
        if ( x < 0 || y > Int32.MaxValue) return false;
        return ((UInt32)x).Equals(y);
    }

    /// <summary>
    /// Checks a UInt32 and a Int32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt32 x, Int32 y)
    {
        if ( y < 0 || x > Int32.MaxValue) return false;
        return x.Equals((UInt32)y);
    }

    /// <summary>
    /// Compares a Int32 to a UInt32
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int32 x, UInt32 y)
    {
        if (x < 0) return -1;
        if (y > Int32.MaxValue) return -1;
        return ((UInt32)x).CompareTo(y);
    }

    /// <summary>
    /// Compares a UInt32 to a Int32 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt32 x, Int32 y)
    {
        if (y < 0) return 1;
        if (x > Int32.MaxValue) return 1;
        return x.CompareTo((UInt32)y);
    }

    #endregion // [UInt32 and Int32 Comparisons]

    #region [UInt32 and Single Comparisons]

    /// <summary>
    /// Checks a Single and a UInt32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Single x, UInt32 y)
    {
         var y1=(Single)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a UInt32 and a Single for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt32 x, Single y)
    {
         var x1=(Single)x;
         return x1.Equals(y);
    }

    /// <summary>
    /// Compares a Single to a UInt32
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Single x, UInt32 y)
    {
         var x1=(Double)x;
         var y1=(Double)y;
         return x1.CompareTo(y1);
    }

    /// <summary>
    /// Compares a UInt32 to a Single 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt32 x, Single y)
    {
         var x1=(Double)x;
         var y1=(Double)y;
         return x1.CompareTo(y1);
    }
    #endregion // [UInt32 and Single Comparisons]

    #region [Int32 and Byte Comparisons]

    /// <summary>
    /// Checks a Int32 and a Byte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int32 x, Byte y)
    {
		if (x < 0) return false;
		return x == y;
    }

    /// <summary>
    /// Checks a Byte and a Int32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Byte x, Int32 y)
    {
		if (y < 0) return false;
		return x == y;
    }

    /// <summary>
    /// Compares a Int32 to a Byte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int32 x, Byte y)
    {
		return x < 0 ? -1 : x.CompareTo(y);
    }

    /// <summary>
    /// Compares a Byte to a Int32 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Byte x, Int32 y)
    {
		return y < 0 ? 1 : ((Int32)x).CompareTo(y);
    }
    #endregion // [Int32 and Byte Comparisons]

    #region [Int32 and SByte Comparisons]

    /// <summary>
    /// Checks a Int32 and a SByte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int32 x, SByte y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a SByte and a Int32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(SByte x, Int32 y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a Int32 to a SByte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int32 x, SByte y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a SByte to a Int32 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(SByte x, Int32 y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [Int32 and SByte Comparisons]

    #region [Int32 and Int16 Comparisons]

    /// <summary>
    /// Checks a Int32 and a Int16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int32 x, Int16 y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a Int16 and a Int32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int16 x, Int32 y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a Int32 to a Int16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int32 x, Int16 y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a Int16 to a Int32 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int16 x, Int32 y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [Int32 and Int16 Comparisons]

    #region [Int32 and UInt16 Comparisons]

    /// <summary>
    /// Checks a Int32 and a UInt16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int32 x, UInt16 y)
    {
		if (x < 0) return false;
		return x == y;
    }

    /// <summary>
    /// Checks a UInt16 and a Int32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt16 x, Int32 y)
    {
		if (y < 0) return false;
		return x == y;
    }

    /// <summary>
    /// Compares a Int32 to a UInt16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int32 x, UInt16 y)
    {
		return x < 0 ? -1 : x.CompareTo(y);
    }

    /// <summary>
    /// Compares a UInt16 to a Int32 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt16 x, Int32 y)
    {
		return y < 0 ? 1 : ((Int32)x).CompareTo(y);
    }
    #endregion // [Int32 and UInt16 Comparisons]

    #region [Int32 and Single Comparisons]

    /// <summary>
    /// Checks a Single and a Int32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Single x, Int32 y)
    {
         var y1=(Single)y;
         return x.Equals(y1);
    }

    /// <summary>
    /// Checks a Int32 and a Single for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int32 x, Single y)
    {
         var x1=(Single)x;
         return x1.Equals(y);
    }

    /// <summary>
    /// Compares a Single to a Int32
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Single x, Int32 y)
    {
         var x1=(Double)x;
         var y1=(Double)y;
         return x1.CompareTo(y1);
    }

    /// <summary>
    /// Compares a Int32 to a Single 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int32 x, Single y)
    {
         var x1=(Double)x;
         var y1=(Double)y;
         return x1.CompareTo(y1);
    }
    #endregion // [Int32 and Single Comparisons]

    #region [Single and Byte Comparisons]

    /// <summary>
    /// Checks a Single and a Byte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Single x, Byte y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a Byte and a Single for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Byte x, Single y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a Single to a Byte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Single x, Byte y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a Byte to a Single 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Byte x, Single y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [Single and Byte Comparisons]

    #region [Single and SByte Comparisons]

    /// <summary>
    /// Checks a Single and a SByte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Single x, SByte y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a SByte and a Single for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(SByte x, Single y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a Single to a SByte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Single x, SByte y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a SByte to a Single 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(SByte x, Single y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [Single and SByte Comparisons]

    #region [Single and Int16 Comparisons]

    /// <summary>
    /// Checks a Single and a Int16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Single x, Int16 y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a Int16 and a Single for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int16 x, Single y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a Single to a Int16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Single x, Int16 y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a Int16 to a Single 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int16 x, Single y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [Single and Int16 Comparisons]

    #region [Single and UInt16 Comparisons]

    /// <summary>
    /// Checks a Single and a UInt16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Single x, UInt16 y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a UInt16 and a Single for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt16 x, Single y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a Single to a UInt16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Single x, UInt16 y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a UInt16 to a Single 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt16 x, Single y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [Single and UInt16 Comparisons]

    #region [UInt64 and Byte Comparisons]

    /// <summary>
    /// Checks a UInt64 and a Byte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt64 x, Byte y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a Byte and a UInt64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Byte x, UInt64 y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a UInt64 to a Byte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt64 x, Byte y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a Byte to a UInt64 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Byte x, UInt64 y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [UInt64 and Byte Comparisons]

    #region [UInt64 and SByte Comparisons]

    /// <summary>
    /// Checks a SByte and a UInt64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(SByte x, UInt64 y)
    {
		if (x < 0 || y > (UInt64)SByte.MaxValue) return false;
		return ((UInt64)x) == y;
    }

    /// <summary>
    /// Checks a UInt64 and a SByte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt64 x, SByte y)
    {
		if (y < 0 || x > (UInt64)SByte.MaxValue) return false;
		return x == (UInt64)y;
    }

    /// <summary>
    /// Compares a SByte to a UInt64
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(SByte x, UInt64 y)
    {
		if (x < 0) return -1;
		if (y > (UInt64)SByte.MaxValue) return -1;
		return ((UInt64)x).CompareTo(y);
    }

    /// <summary>
    /// Compares a UInt64 to a SByte 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt64 x, SByte y)
    {
		if (y < 0) return 1;
		if (x > (UInt64)SByte.MaxValue) return 1;
		return x.CompareTo((UInt64)y);
    }
    #endregion // [UInt64 and SByte Comparisons]

    #region [UInt64 and Int16 Comparisons]

    /// <summary>
    /// Checks a Int16 and a UInt64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int16 x, UInt64 y)
    {
		if (x < 0 || y > (UInt64)Int16.MaxValue) return false;
		return ((UInt64)x) == y;
    }

    /// <summary>
    /// Checks a UInt64 and a Int16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt64 x, Int16 y)
    {
		if (y < 0 || x > (UInt64)Int16.MaxValue) return false;
		return x == (UInt64)y;
    }

    /// <summary>
    /// Compares a Int16 to a UInt64
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int16 x, UInt64 y)
    {
		if (x < 0) return -1;
		if (y > (UInt64)Int16.MaxValue) return -1;
		return ((UInt64)x).CompareTo(y);
    }

    /// <summary>
    /// Compares a UInt64 to a Int16 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt64 x, Int16 y)
    {
		if (y < 0) return 1;
		if (x > (UInt64)Int16.MaxValue) return 1;
		return x.CompareTo((UInt64)y);
    }
    #endregion // [UInt64 and Int16 Comparisons]

    #region [UInt64 and UInt16 Comparisons]

    /// <summary>
    /// Checks a UInt64 and a UInt16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt64 x, UInt16 y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a UInt16 and a UInt64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt16 x, UInt64 y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a UInt64 to a UInt16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt64 x, UInt16 y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a UInt16 to a UInt64 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt16 x, UInt64 y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [UInt64 and UInt16 Comparisons]

    #region [UInt64 and Int32 Comparisons]

    /// <summary>
    /// Checks a Int32 and a UInt64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int32 x, UInt64 y)
    {
		if (x < 0 || y > (UInt64)Int32.MaxValue) return false;
		return ((UInt64)x) == y;
    }

    /// <summary>
    /// Checks a UInt64 and a Int32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt64 x, Int32 y)
    {
		if (y < 0 || x > (UInt64)Int32.MaxValue) return false;
		return x == (UInt64)y;
    }

    /// <summary>
    /// Compares a Int32 to a UInt64
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int32 x, UInt64 y)
    {
		if (x < 0) return -1;
		if (y > (UInt64)Int32.MaxValue) return -1;
		return ((UInt64)x).CompareTo(y);
    }

    /// <summary>
    /// Compares a UInt64 to a Int32 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt64 x, Int32 y)
    {
		if (y < 0) return 1;
		if (x > (UInt64)Int32.MaxValue) return 1;
		return x.CompareTo((UInt64)y);
    }
    #endregion // [UInt64 and Int32 Comparisons]

    #region [UInt64 and UInt32 Comparisons]

    /// <summary>
    /// Checks a UInt64 and a UInt32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt64 x, UInt32 y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a UInt32 and a UInt64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt32 x, UInt64 y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a UInt64 to a UInt32
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt64 x, UInt32 y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a UInt32 to a UInt64 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt32 x, UInt64 y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [UInt64 and UInt32 Comparisons]

    #region [UInt64 and Int64 Comparisons]

    /// <summary>
    /// Checks a Int64 and a UInt64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int64 x, UInt64 y)
    {
        if ( x < 0 || y > Int64.MaxValue) return false;
        return ((UInt64)x).Equals(y);
    }

    /// <summary>
    /// Checks a UInt64 and a Int64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt64 x, Int64 y)
    {
        if ( y < 0 || x > Int64.MaxValue) return false;
        return x.Equals((UInt64)y);
    }

    /// <summary>
    /// Compares a Int64 to a UInt64
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int64 x, UInt64 y)
    {
        if (x < 0) return -1;
        if (y > Int64.MaxValue) return -1;
        return ((UInt64)x).CompareTo(y);
    }

    /// <summary>
    /// Compares a UInt64 to a Int64 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt64 x, Int64 y)
    {
        if (y < 0) return 1;
        if (x > Int64.MaxValue) return 1;
        return x.CompareTo((UInt64)y);
    }

    #endregion // [UInt64 and Int64 Comparisons]

    #region [Int64 and Byte Comparisons]

    /// <summary>
    /// Checks a Int64 and a Byte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int64 x, Byte y)
    {
		if (x < 0) return false;
		return x == y;
    }

    /// <summary>
    /// Checks a Byte and a Int64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Byte x, Int64 y)
    {
		if (y < 0) return false;
		return x == y;
    }

    /// <summary>
    /// Compares a Int64 to a Byte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int64 x, Byte y)
    {
		return x < 0 ? -1 : x.CompareTo(y);
    }

    /// <summary>
    /// Compares a Byte to a Int64 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Byte x, Int64 y)
    {
		return y < 0 ? 1 : ((Int64)x).CompareTo(y);
    }
    #endregion // [Int64 and Byte Comparisons]

    #region [Int64 and SByte Comparisons]

    /// <summary>
    /// Checks a Int64 and a SByte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int64 x, SByte y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a SByte and a Int64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(SByte x, Int64 y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a Int64 to a SByte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int64 x, SByte y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a SByte to a Int64 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(SByte x, Int64 y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [Int64 and SByte Comparisons]

    #region [Int64 and Int16 Comparisons]

    /// <summary>
    /// Checks a Int64 and a Int16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int64 x, Int16 y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a Int16 and a Int64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int16 x, Int64 y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a Int64 to a Int16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int64 x, Int16 y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a Int16 to a Int64 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int16 x, Int64 y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [Int64 and Int16 Comparisons]

    #region [Int64 and UInt16 Comparisons]

    /// <summary>
    /// Checks a Int64 and a UInt16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int64 x, UInt16 y)
    {
		if (x < 0) return false;
		return x == y;
    }

    /// <summary>
    /// Checks a UInt16 and a Int64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt16 x, Int64 y)
    {
		if (y < 0) return false;
		return x == y;
    }

    /// <summary>
    /// Compares a Int64 to a UInt16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int64 x, UInt16 y)
    {
		return x < 0 ? -1 : x.CompareTo(y);
    }

    /// <summary>
    /// Compares a UInt16 to a Int64 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt16 x, Int64 y)
    {
		return y < 0 ? 1 : ((Int64)x).CompareTo(y);
    }
    #endregion // [Int64 and UInt16 Comparisons]

    #region [Int64 and Int32 Comparisons]

    /// <summary>
    /// Checks a Int64 and a Int32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int64 x, Int32 y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a Int32 and a Int64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int32 x, Int64 y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a Int64 to a Int32
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int64 x, Int32 y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a Int32 to a Int64 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int32 x, Int64 y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [Int64 and Int32 Comparisons]

    #region [Int64 and UInt32 Comparisons]

    /// <summary>
    /// Checks a Int64 and a UInt32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int64 x, UInt32 y)
    {
		if (x < 0) return false;
		return x == y;
    }

    /// <summary>
    /// Checks a UInt32 and a Int64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt32 x, Int64 y)
    {
		if (y < 0) return false;
		return x == y;
    }

    /// <summary>
    /// Compares a Int64 to a UInt32
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int64 x, UInt32 y)
    {
		return x < 0 ? -1 : x.CompareTo(y);
    }

    /// <summary>
    /// Compares a UInt32 to a Int64 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt32 x, Int64 y)
    {
		return y < 0 ? 1 : ((Int64)x).CompareTo(y);
    }
    #endregion // [Int64 and UInt32 Comparisons]

    #region [Double and Byte Comparisons]

    /// <summary>
    /// Checks a Double and a Byte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Double x, Byte y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a Byte and a Double for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Byte x, Double y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a Double to a Byte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Double x, Byte y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a Byte to a Double 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Byte x, Double y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [Double and Byte Comparisons]

    #region [Double and SByte Comparisons]

    /// <summary>
    /// Checks a Double and a SByte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Double x, SByte y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a SByte and a Double for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(SByte x, Double y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a Double to a SByte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Double x, SByte y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a SByte to a Double 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(SByte x, Double y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [Double and SByte Comparisons]

    #region [Double and Int16 Comparisons]

    /// <summary>
    /// Checks a Double and a Int16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Double x, Int16 y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a Int16 and a Double for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int16 x, Double y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a Double to a Int16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Double x, Int16 y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a Int16 to a Double 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int16 x, Double y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [Double and Int16 Comparisons]

    #region [Double and UInt16 Comparisons]

    /// <summary>
    /// Checks a Double and a UInt16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Double x, UInt16 y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a UInt16 and a Double for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt16 x, Double y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a Double to a UInt16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Double x, UInt16 y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a UInt16 to a Double 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt16 x, Double y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [Double and UInt16 Comparisons]

    #region [Double and Int32 Comparisons]

    /// <summary>
    /// Checks a Double and a Int32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Double x, Int32 y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a Int32 and a Double for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int32 x, Double y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a Double to a Int32
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Double x, Int32 y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a Int32 to a Double 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int32 x, Double y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [Double and Int32 Comparisons]

    #region [Double and UInt32 Comparisons]

    /// <summary>
    /// Checks a Double and a UInt32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Double x, UInt32 y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a UInt32 and a Double for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt32 x, Double y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a Double to a UInt32
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Double x, UInt32 y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a UInt32 to a Double 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt32 x, Double y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [Double and UInt32 Comparisons]

    #region [Double and Single Comparisons]

    /// <summary>
    /// Checks a Double and a Single for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Double x, Single y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a Single and a Double for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Single x, Double y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a Double to a Single
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Double x, Single y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a Single to a Double 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Single x, Double y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [Double and Single Comparisons]

    #region [Decimal and Byte Comparisons]

    /// <summary>
    /// Checks a Decimal and a Byte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Decimal x, Byte y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a Byte and a Decimal for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Byte x, Decimal y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a Decimal to a Byte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Decimal x, Byte y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a Byte to a Decimal 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Byte x, Decimal y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [Decimal and Byte Comparisons]

    #region [Decimal and SByte Comparisons]

    /// <summary>
    /// Checks a Decimal and a SByte for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Decimal x, SByte y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a SByte and a Decimal for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(SByte x, Decimal y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a Decimal to a SByte
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Decimal x, SByte y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a SByte to a Decimal 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(SByte x, Decimal y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [Decimal and SByte Comparisons]

    #region [Decimal and Int16 Comparisons]

    /// <summary>
    /// Checks a Decimal and a Int16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Decimal x, Int16 y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a Int16 and a Decimal for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int16 x, Decimal y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a Decimal to a Int16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Decimal x, Int16 y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a Int16 to a Decimal 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int16 x, Decimal y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [Decimal and Int16 Comparisons]

    #region [Decimal and UInt16 Comparisons]

    /// <summary>
    /// Checks a Decimal and a UInt16 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Decimal x, UInt16 y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a UInt16 and a Decimal for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt16 x, Decimal y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a Decimal to a UInt16
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Decimal x, UInt16 y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a UInt16 to a Decimal 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt16 x, Decimal y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [Decimal and UInt16 Comparisons]

    #region [Decimal and Int32 Comparisons]

    /// <summary>
    /// Checks a Decimal and a Int32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Decimal x, Int32 y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a Int32 and a Decimal for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int32 x, Decimal y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a Decimal to a Int32
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Decimal x, Int32 y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a Int32 to a Decimal 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int32 x, Decimal y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [Decimal and Int32 Comparisons]

    #region [Decimal and UInt32 Comparisons]

    /// <summary>
    /// Checks a Decimal and a UInt32 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Decimal x, UInt32 y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a UInt32 and a Decimal for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt32 x, Decimal y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a Decimal to a UInt32
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Decimal x, UInt32 y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a UInt32 to a Decimal 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt32 x, Decimal y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [Decimal and UInt32 Comparisons]

    #region [Decimal and Int64 Comparisons]

    /// <summary>
    /// Checks a Decimal and a Int64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Decimal x, Int64 y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a Int64 and a Decimal for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Int64 x, Decimal y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a Decimal to a Int64
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Decimal x, Int64 y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a Int64 to a Decimal 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Int64 x, Decimal y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [Decimal and Int64 Comparisons]

    #region [Decimal and UInt64 Comparisons]

    /// <summary>
    /// Checks a Decimal and a UInt64 for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(Decimal x, UInt64 y)
    {
         return x == y;
    }

    /// <summary>
    /// Checks a UInt64 and a Decimal for equality
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  true when x == y
    /// *  false otherwise
    /// </returns>
    public static bool Equals(UInt64 x, Decimal y)
    {
         return x == y;
    }

    /// <summary>
    /// Compares a Decimal to a UInt64
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(Decimal x, UInt64 y)
    {
         return x.CompareTo(y);
    }

    /// <summary>
    /// Compares a UInt64 to a Decimal 
    /// </summary>
    /// <param name="x">The first item to compare</param>
    /// <param name="y">The second item to compare</param>
    /// <returns>
    /// *  0 when x == y
    /// * -1 when x lt; y
    /// *  1 when x gt; y
    /// </returns>
    public static int Compare(UInt64 x, Decimal y)
    {
         return y.CompareTo(x)*-1; // invert the result as x is on the left.
    }

    #endregion // [Decimal and UInt64 Comparisons]
}