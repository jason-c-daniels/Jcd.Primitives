#### [Jcd.Primitives](index.md 'index')
### [Jcd.Primitives](Jcd.Primitives.md 'Jcd.Primitives')

## TypeExtensions Class

A set of extension methods for Type that people seem to keep asking  
about/for on StackOverflow.

```csharp
public static class TypeExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; TypeExtensions

| Methods | |
| :--- | :--- |
| [GetExtendedTypeInfo(this Type)](Jcd.Primitives.TypeExtensions.GetExtendedTypeInfo(thisSystem.Type).md 'Jcd.Primitives.TypeExtensions.GetExtendedTypeInfo(this System.Type)') | Retrieves the extended type information for the provided type. |
| [IsFloatingPoint(this Type)](Jcd.Primitives.TypeExtensions.IsFloatingPoint(thisSystem.Type).md 'Jcd.Primitives.TypeExtensions.IsFloatingPoint(this System.Type)') | Determines if the provided type is a floating point or decimal type. |
| [IsPrimitiveStructOrEnum(this Type)](Jcd.Primitives.TypeExtensions.IsPrimitiveStructOrEnum(thisSystem.Type).md 'Jcd.Primitives.TypeExtensions.IsPrimitiveStructOrEnum(this System.Type)') | Determines if a type is a a primitive struct or primitive (built-in) enum |
| [IsSigned(this Type)](Jcd.Primitives.TypeExtensions.IsSigned(thisSystem.Type).md 'Jcd.Primitives.TypeExtensions.IsSigned(this System.Type)') | Determines if a value of the provided type can be negative. (i.e. is it signed) |
| [IsUserDefinedStructOrEnum(this Type)](Jcd.Primitives.TypeExtensions.IsUserDefinedStructOrEnum(thisSystem.Type).md 'Jcd.Primitives.TypeExtensions.IsUserDefinedStructOrEnum(this System.Type)') | Determines if a type is a user defined struct<br/>or user defined enum. |
| [SizeOf(this Type)](Jcd.Primitives.TypeExtensions.SizeOf(thisSystem.Type).md 'Jcd.Primitives.TypeExtensions.SizeOf(this System.Type)') | Retrieves the sizeof(T) for a given primitive type (not enums). |
