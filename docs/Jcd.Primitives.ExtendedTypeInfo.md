#### [Jcd.Primitives](index.md 'index')
### [Jcd.Primitives](Jcd.Primitives.md 'Jcd.Primitives')

## ExtendedTypeInfo Class

Contains some additional, sometimes sought after metadata about types.

```csharp
public class ExtendedTypeInfo :
System.IEquatable<Jcd.Primitives.ExtendedTypeInfo>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ExtendedTypeInfo

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[ExtendedTypeInfo](Jcd.Primitives.ExtendedTypeInfo.md 'Jcd.Primitives.ExtendedTypeInfo')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [ExtendedTypeInfo(Type)](Jcd.Primitives.ExtendedTypeInfo.ExtendedTypeInfo(System.Type).md 'Jcd.Primitives.ExtendedTypeInfo.ExtendedTypeInfo(System.Type)') | Constructs a new ExtendedTypeInfo instance from an existing type. |

| Properties | |
| :--- | :--- |
| [IsFloatingPoint](Jcd.Primitives.ExtendedTypeInfo.IsFloatingPoint.md 'Jcd.Primitives.ExtendedTypeInfo.IsFloatingPoint') | Indicates if the type is float,double, or decimal. |
| [IsPrimitiveStructOrEnum](Jcd.Primitives.ExtendedTypeInfo.IsPrimitiveStructOrEnum.md 'Jcd.Primitives.ExtendedTypeInfo.IsPrimitiveStructOrEnum') | Indicates if a type is a primitive struct or primitive enum. |
| [IsSigned](Jcd.Primitives.ExtendedTypeInfo.IsSigned.md 'Jcd.Primitives.ExtendedTypeInfo.IsSigned') | Indicates if the type is signed. |
| [IsUserDefinedStructOrEnum](Jcd.Primitives.ExtendedTypeInfo.IsUserDefinedStructOrEnum.md 'Jcd.Primitives.ExtendedTypeInfo.IsUserDefinedStructOrEnum') | Indicates if a type is a user defined struct or user defined enum. |
| [Size](Jcd.Primitives.ExtendedTypeInfo.Size.md 'Jcd.Primitives.ExtendedTypeInfo.Size') | The size of the type in bytes. |
| [Type](Jcd.Primitives.ExtendedTypeInfo.Type.md 'Jcd.Primitives.ExtendedTypeInfo.Type') | The core type. |
