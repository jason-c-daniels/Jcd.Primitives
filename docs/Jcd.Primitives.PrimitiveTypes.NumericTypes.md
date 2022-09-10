#### [Jcd.Primitives](index.md 'index')
### [Jcd.Primitives](Jcd.Primitives.md 'Jcd.Primitives').[PrimitiveTypes](Jcd.Primitives.PrimitiveTypes.md 'Jcd.Primitives.PrimitiveTypes')

## PrimitiveTypes.NumericTypes Field

Returns the full set of CLR verifiably safe numeric types and boolean.  
(i.e. nint and nuint cannot be included as certain operations  
such as sizeof() are not supported outside of an unsafe context)

```csharp
public static readonly IReadOnlyList<Type> NumericTypes;
```

#### Field Value
[System.Collections.Generic.IReadOnlyList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyList-1 'System.Collections.Generic.IReadOnlyList`1')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyList-1 'System.Collections.Generic.IReadOnlyList`1')