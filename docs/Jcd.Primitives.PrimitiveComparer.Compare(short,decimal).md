#### [Jcd.Primitives](index.md 'index')
### [Jcd.Primitives](Jcd.Primitives.md 'Jcd.Primitives').[PrimitiveComparer](Jcd.Primitives.PrimitiveComparer.md 'Jcd.Primitives.PrimitiveComparer')

## PrimitiveComparer.Compare(short, decimal) Method

Compares a Int16 to a Decimal

```csharp
public static int Compare(short x, decimal y);
```
#### Parameters

<a name='Jcd.Primitives.PrimitiveComparer.Compare(short,decimal).x'></a>

`x` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The first item to compare

<a name='Jcd.Primitives.PrimitiveComparer.Compare(short,decimal).y'></a>

`y` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The second item to compare

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
*  0 when x == y  
* -1 when x lt; y  
*  1 when x gt; y