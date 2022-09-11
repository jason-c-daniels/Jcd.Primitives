#### [Jcd.Primitives](index.md 'index')
### [Jcd.Primitives](Jcd.Primitives.md 'Jcd.Primitives').[PrimitiveComparer](Jcd.Primitives.PrimitiveComparer.md 'Jcd.Primitives.PrimitiveComparer')

## PrimitiveComparer.Compare(uint, decimal) Method

Compares a UInt32 to a Decimal

```csharp
public static int Compare(uint x, decimal y);
```
#### Parameters

<a name='Jcd.Primitives.PrimitiveComparer.Compare(uint,decimal).x'></a>

`x` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The first item to compare

<a name='Jcd.Primitives.PrimitiveComparer.Compare(uint,decimal).y'></a>

`y` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The second item to compare

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
*  0 when x == y  
* -1 when x lt; y  
*  1 when x gt; y