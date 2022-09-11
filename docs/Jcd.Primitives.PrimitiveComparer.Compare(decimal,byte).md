#### [Jcd.Primitives](index.md 'index')
### [Jcd.Primitives](Jcd.Primitives.md 'Jcd.Primitives').[PrimitiveComparer](Jcd.Primitives.PrimitiveComparer.md 'Jcd.Primitives.PrimitiveComparer')

## PrimitiveComparer.Compare(decimal, byte) Method

Compares a Decimal to a Byte

```csharp
public static int Compare(decimal x, byte y);
```
#### Parameters

<a name='Jcd.Primitives.PrimitiveComparer.Compare(decimal,byte).x'></a>

`x` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The first item to compare

<a name='Jcd.Primitives.PrimitiveComparer.Compare(decimal,byte).y'></a>

`y` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The second item to compare

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
*  0 when x == y  
* -1 when x lt; y  
*  1 when x gt; y