using System;
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedType.Global
#pragma warning disable CS8618

namespace Jcd.Primitives;

/// <summary>
/// Contains some additional, sometimes sought after metadata about types.
/// </summary>
public record ExtendedTypeInfo 
{
    /// <summary>
    /// Indicates if the type is signed.
    /// </summary>
    public bool IsSigned { get; }
    
    /// <summary>
    /// Indicates if the type is float,double, or decimal.
    /// </summary>
    public bool IsFloatingPoint { get; }
    
    /// <summary>
    /// The size of the type in bytes.
    /// </summary>
    public int Size { get; }
    
    /// <summary>
    /// The core type.
    /// </summary>
    public Type Type { get; }
    
    /// <summary>
    /// Indicates if a type is a primitive struct or primitive enum.
    /// </summary>
    public bool IsPrimitiveStructOrEnum { get; }
    
    /// <summary>
    /// Indicates if a type is a user defined struct or user defined enum.
    /// </summary>
    public bool IsUserDefinedStructOrEnum { get; }

    /// <summary>
    /// Constructs a new ExtendedTypeInfo instance from an existing type. 
    /// </summary>
    /// <param name="type">the type to inspect</param>
    public ExtendedTypeInfo(Type type) : this()
    {
        IsSigned = type.IsSigned();
        IsFloatingPoint = type.IsFloatingPoint();
        Size = type.SizeOf();
        Type = type;
        IsUserDefinedStructOrEnum = type.IsUserDefinedStructOrEnum();
        IsPrimitiveStructOrEnum = type.IsPrimitiveStructOrEnum();
    }

    private ExtendedTypeInfo() { }
}