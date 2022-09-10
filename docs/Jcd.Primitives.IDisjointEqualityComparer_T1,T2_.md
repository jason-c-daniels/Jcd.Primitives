#### [Jcd.Primitives](index.md 'index')
### [Jcd.Primitives](Jcd.Primitives.md 'Jcd.Primitives')

## IDisjointEqualityComparer<T1,T2> Interface

Defines methods to support the comparison of two items of differing  
types for equality, which don't support IEquatable<T1> AND  
IEquatable<T2>  
<remarks>  
An inability to implement IEquatable&lt;T1&gt; AND IEquatable&lt;T2&gt;  
on the same containing type is actually pretty common as  
the "may unify..." compiler error message happens when the compiler  
thinks there's a slight hint of a chance that T1 and T2 COULD become  
the same data type.  
  
Of course for IEquatable, and IComparable that's often perfectly  
fine, not necessarily true of other operations tho.  
</remarks>

```csharp
public interface IDisjointEqualityComparer<in T1,in T2>
```
#### Type parameters

<a name='Jcd.Primitives.IDisjointEqualityComparer_T1,T2_.T1'></a>

`T1`

The first data type.

<a name='Jcd.Primitives.IDisjointEqualityComparer_T1,T2_.T2'></a>

`T2`

The second data type.

| Methods | |
| :--- | :--- |
| [Equals(T1, T2)](Jcd.Primitives.IDisjointEqualityComparer_T1,T2_.Equals(T1,T2).md 'Jcd.Primitives.IDisjointEqualityComparer<T1,T2>.Equals(T1, T2)') | Compares an instance of T1 to an instance of T2. |
| [Equals(T2, T1)](Jcd.Primitives.IDisjointEqualityComparer_T1,T2_.Equals(T2,T1).md 'Jcd.Primitives.IDisjointEqualityComparer<T1,T2>.Equals(T2, T1)') | Compares an instance of T1 to an instance of T2. |
