#### [Jcd.Primitives](index.md 'index')
### [Jcd.Primitives](Jcd.Primitives.md 'Jcd.Primitives')

## TypePairing Struct

Represents a unique pairing of two types.

```csharp
public readonly struct TypePairing :
System.IEquatable<Jcd.Primitives.TypePairing>
```

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[TypePairing](Jcd.Primitives.TypePairing.md 'Jcd.Primitives.TypePairing')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

### Remarks
A pairing is considered identical for x and y if:  
                  x.First==y.First && x.Second==y.Second  
             -- OR --  
                  x.First==y.Second && x.Second==y.First  
              
             To help with other operations, the hashcode is computed such that it's the same for any T1 and T2  
             regardless if T1 or T2 are first or second.

| Constructors | |
| :--- | :--- |
| [TypePairing(Type, Type)](Jcd.Primitives.TypePairing.TypePairing(System.Type,System.Type).md 'Jcd.Primitives.TypePairing.TypePairing(System.Type, System.Type)') | Constructs an instance of TypePairing from two instances of Type. |

| Fields | |
| :--- | :--- |
| [FormatString](Jcd.Primitives.TypePairing.FormatString.md 'Jcd.Primitives.TypePairing.FormatString') | The format string for a TypePairing.<br/>* {0} is the type name of First.<br/>* {1} is the type name of Second. |

| Properties | |
| :--- | :--- |
| [AreSameType](Jcd.Primitives.TypePairing.AreSameType.md 'Jcd.Primitives.TypePairing.AreSameType') | Indicates if the pairing is an identity pairing. |
| [First](Jcd.Primitives.TypePairing.First.md 'Jcd.Primitives.TypePairing.First') | The first type in the pairing. |
| [Second](Jcd.Primitives.TypePairing.Second.md 'Jcd.Primitives.TypePairing.Second') | The second type in the pairing. |

| Methods | |
| :--- | :--- |
| [GetHashCode()](Jcd.Primitives.TypePairing.GetHashCode().md 'Jcd.Primitives.TypePairing.GetHashCode()') | Returns the hash code for this instance. |
| [ToString()](Jcd.Primitives.TypePairing.ToString().md 'Jcd.Primitives.TypePairing.ToString()') | Returns the fully qualified type name of this instance. |
