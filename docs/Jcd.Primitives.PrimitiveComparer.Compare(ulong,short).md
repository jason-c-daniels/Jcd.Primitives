#### [Jcd.Primitives](index.md 'index')
### [Jcd.Primitives](Jcd.Primitives.md 'Jcd.Primitives').[PrimitiveComparer](Jcd.Primitives.PrimitiveComparer.md 'Jcd.Primitives.PrimitiveComparer')

## PrimitiveComparer.Compare(ulong, short) Method

Compares a UInt64 to a Int16

```csharp
public static int Compare(ulong x, short y);
```
#### Parameters

<a name='Jcd.Primitives.PrimitiveComparer.Compare(ulong,short).x'></a>

`x` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The first item to compare

<a name='Jcd.Primitives.PrimitiveComparer.Compare(ulong,short).y'></a>

`y` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The second item to compare

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
*  0 when x == y  
* -1 when x lt; y  
*  1 when x gt; y