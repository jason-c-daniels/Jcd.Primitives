#### [Jcd.Primitives](index.md 'index')
### [Jcd.Primitives](Jcd.Primitives.md 'Jcd.Primitives').[PrimitiveComparer](Jcd.Primitives.PrimitiveComparer.md 'Jcd.Primitives.PrimitiveComparer')

## PrimitiveComparer.Compare(long, decimal) Method

Compares a Int64 to a Decimal

```csharp
public static int Compare(long x, decimal y);
```
#### Parameters

<a name='Jcd.Primitives.PrimitiveComparer.Compare(long,decimal).x'></a>

`x` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The first item to compare

<a name='Jcd.Primitives.PrimitiveComparer.Compare(long,decimal).y'></a>

`y` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The second item to compare

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
*  0 when x == y  
* -1 when x lt; y  
*  1 when x gt; y