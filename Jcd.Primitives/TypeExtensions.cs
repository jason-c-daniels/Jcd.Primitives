using System;

namespace Jcd.Primitives;

/// <summary>
/// A set of extension methods for Type that people seem to keep asking
/// about/for on StackOverflow. 
/// </summary>
public static class TypeExtensions
{
    /// <summary>
    /// Determines if a type is a user defined struct
    /// or user defined enum.
    /// </summary>
    /// <param name="type">the type to inspect</param>
    /// <returns>true if the type is a used defined struct or enum.</returns>
    public static bool IsUserDefinedStructOrEnum(this Type type) 
    {
        return type.IsValueType && !type.IsPrimitive;
    }
    
    /// <summary>
    /// Determines if a type is a a primitive struct or primitive (built-in) enum
    /// </summary>
    /// <param name="type">the type to inspect.</param>
    /// <returns>True if the type is a primitive struct or enum.</returns>
    public static bool IsPrimitiveStructOrEnum(this Type type) 
    {
        return type.IsValueType && type.IsPrimitive;
    }
    
    /// <summary>
    /// Retrieves the sizeof(T) for a given primitive type (not enums). 
    /// </summary>
    /// <param name="type">The primitive type to inspect</param>
    /// <returns>the result of sizeof(T) for primitive types. -1 for non-primitive types and enums.</returns>
    public static int SizeOf(this Type type)
    {
        if (type == typeof(bool)) return sizeof(bool);
        if (type == typeof(byte)) return sizeof(byte);
        if (type == typeof(sbyte)) return sizeof(sbyte);
        if (type == typeof(short)) return sizeof(short);
        if (type == typeof(ushort)) return sizeof(ushort);
        if (type == typeof(int)) return sizeof(int);
        if (type == typeof(uint)) return sizeof(uint);
        if (type == typeof(long)) return sizeof(long);
        if (type == typeof(ulong)) return sizeof(ulong);
        if (type == typeof(float)) return sizeof(float);
        if (type == typeof(double)) return sizeof(double);
        if (type == typeof(decimal)) return sizeof(decimal);
        return -1;
    }

    /// <summary>
    /// Determines if a value of the provided type can be negative. (i.e. is it signed)
    /// </summary>
    /// <param name="type">The type to inspect</param>
    /// <returns>True if it's a signed type.</returns>
    public static bool IsSigned(this Type type)
    {
        return    type == typeof(float)
               || type == typeof(decimal)
               || type == typeof(double)
               || type == typeof(sbyte)
               || type == typeof(short)
               || type == typeof(int)
               || type == typeof(long)
               || type == typeof(nint)
            ;
    }

    /// <summary>
    /// Determines if the provided type is a floating point or decimal type.
    /// </summary>
    /// <param name="type">the type to inspect</param>
    /// <returns>True if float,double or decimal. False otherwise.</returns>
    public static bool IsFloatingPoint(this Type type)
    {
        return    type == typeof(float)
               || type == typeof(double)
               || type == typeof(decimal)
            ;
    }

    /// <summary>
    /// Retrieves the extended type information for the provided type. 
    /// </summary>
    /// <param name="type">The type to act upon.</param>
    /// <returns>The extended type information.</returns>
    public static ExtendedTypeInfo GetExtendedTypeInfo(this Type type) => new (type);
}