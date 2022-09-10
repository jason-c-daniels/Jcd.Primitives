#### [Jcd.Primitives](index.md 'index')
### [Jcd.Primitives](Jcd.Primitives.md 'Jcd.Primitives').[TypeExtensions](Jcd.Primitives.TypeExtensions.md 'Jcd.Primitives.TypeExtensions')

## TypeExtensions.SizeOf(this Type) Method

Retrieves the sizeof(T) for a given primitive type (not enums).

```csharp
public static int SizeOf(this System.Type type);
```
#### Parameters

<a name='Jcd.Primitives.TypeExtensions.SizeOf(thisSystem.Type).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The primitive type to inspect

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
the result of sizeof(T) for primitive types. -1 for non-primitive types and enums.