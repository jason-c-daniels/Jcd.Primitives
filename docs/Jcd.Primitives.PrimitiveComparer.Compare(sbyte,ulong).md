#### [Jcd.Primitives](index.md 'index')
### [Jcd.Primitives](Jcd.Primitives.md 'Jcd.Primitives').[PrimitiveComparer](Jcd.Primitives.PrimitiveComparer.md 'Jcd.Primitives.PrimitiveComparer')

## PrimitiveComparer.Compare(sbyte, ulong) Method

Compares a SByte to a UInt64

```csharp
public static int Compare(sbyte x, ulong y);
```
#### Parameters

<a name='Jcd.Primitives.PrimitiveComparer.Compare(sbyte,ulong).x'></a>

`x` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The first item to compare

<a name='Jcd.Primitives.PrimitiveComparer.Compare(sbyte,ulong).y'></a>

`y` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The second item to compare

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
*  0 when x == y  
* -1 when x lt; y  
*  1 when x gt; y