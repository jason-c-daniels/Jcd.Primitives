#### [Jcd.Primitives](index.md 'index')
### [Jcd.Primitives](Jcd.Primitives.md 'Jcd.Primitives').[PrimitiveComparer](Jcd.Primitives.PrimitiveComparer.md 'Jcd.Primitives.PrimitiveComparer')

## PrimitiveComparer.Compare(decimal, uint) Method

Compares a Decimal to a UInt32

```csharp
public static int Compare(decimal x, uint y);
```
#### Parameters

<a name='Jcd.Primitives.PrimitiveComparer.Compare(decimal,uint).x'></a>

`x` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The first item to compare

<a name='Jcd.Primitives.PrimitiveComparer.Compare(decimal,uint).y'></a>

`y` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The second item to compare

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
*  0 when x == y  
* -1 when x lt; y  
*  1 when x gt; y