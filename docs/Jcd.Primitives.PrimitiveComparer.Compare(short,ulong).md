#### [Jcd.Primitives](index.md 'index')
### [Jcd.Primitives](Jcd.Primitives.md 'Jcd.Primitives').[PrimitiveComparer](Jcd.Primitives.PrimitiveComparer.md 'Jcd.Primitives.PrimitiveComparer')

## PrimitiveComparer.Compare(short, ulong) Method

Compares a Int16 to a UInt64

```csharp
public static int Compare(short x, ulong y);
```
#### Parameters

<a name='Jcd.Primitives.PrimitiveComparer.Compare(short,ulong).x'></a>

`x` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The first item to compare

<a name='Jcd.Primitives.PrimitiveComparer.Compare(short,ulong).y'></a>

`y` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The second item to compare

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
*  0 when x == y  
* -1 when x lt; y  
*  1 when x gt; y