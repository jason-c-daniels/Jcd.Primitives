#### [Jcd.Primitives](index.md 'index')
### [Jcd.Primitives](Jcd.Primitives.md 'Jcd.Primitives')

## PrimitiveTypes Class

A helper class that provides some niche use case  
properties for primitive numeric types and boolean.

```csharp
public static class PrimitiveTypes
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; PrimitiveTypes

| Fields | |
| :--- | :--- |
| [CrossProductOfAllNumericTypesAndBoolean](Jcd.Primitives.PrimitiveTypes.CrossProductOfAllNumericTypesAndBoolean.md 'Jcd.Primitives.PrimitiveTypes.CrossProductOfAllNumericTypesAndBoolean') | Gets the cross product of all values in NumericTypesAndBoolean as `TypePairing` instances. |
| [NumericTypesAndBoolean](Jcd.Primitives.PrimitiveTypes.NumericTypesAndBoolean.md 'Jcd.Primitives.PrimitiveTypes.NumericTypesAndBoolean') | Returns the full set of CLR verifiable numeric types and boolean.<br/>(i.e. nint and nuint cannot be included as certain operations<br/>such as sizeof() are not supported outside of an unsafe context) |
