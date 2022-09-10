#### [Jcd.Primitives](index.md 'index')

## Jcd.Primitives Namespace

Provides TODO: A description of what this namespace provides.

| Classes | |
| :--- | :--- |
| [ExtendedTypeInfo](Jcd.Primitives.ExtendedTypeInfo.md 'Jcd.Primitives.ExtendedTypeInfo') | Contains some additional, sometimes sought after metadata about types. |
| [PrimitiveTypes](Jcd.Primitives.PrimitiveTypes.md 'Jcd.Primitives.PrimitiveTypes') | A helper class that provides some niche use case<br/>properties for primitive numeric types and boolean. |
| [TypeExtensions](Jcd.Primitives.TypeExtensions.md 'Jcd.Primitives.TypeExtensions') | A set of extension methods for Type that people seem to keep asking<br/>about/for on StackOverflow. |

| Structs | |
| :--- | :--- |
| [TypePairing](Jcd.Primitives.TypePairing.md 'Jcd.Primitives.TypePairing') | Represents a unique pairing of two types. |

| Interfaces | |
| :--- | :--- |
| [IDisjointComparer&lt;T1,T2&gt;](Jcd.Primitives.IDisjointComparer_T1,T2_.md 'Jcd.Primitives.IDisjointComparer<T1,T2>') | Defines methods to support the comparison of two items of differing<br/>types, which don't support IEquatable<T1> AND IEquatable<T2><br/><remarks><br/>An inability to implement IEquatable&lt;T1&gt; AND IEquatable&lt;T2&gt;<br/>on the same containing type is actually pretty common as<br/>the "may unify..." compiler error message happens when the compiler<br/>thinks there's a slight hint of a chance that T1 and T2 COULD become<br/>the same data type.<br/><br/>Of course for IEquatable, and IComparable that's often perfectly<br/>fine, not necessarily true of other operations tho.<br/></remarks> |
| [IDisjointEqualityComparer&lt;T1,T2&gt;](Jcd.Primitives.IDisjointEqualityComparer_T1,T2_.md 'Jcd.Primitives.IDisjointEqualityComparer<T1,T2>') | Defines methods to support the comparison of two items of differing<br/>types for equality, which don't support IEquatable<T1> AND<br/>IEquatable<T2><br/><remarks><br/>An inability to implement IEquatable&lt;T1&gt; AND IEquatable&lt;T2&gt;<br/>on the same containing type is actually pretty common as<br/>the "may unify..." compiler error message happens when the compiler<br/>thinks there's a slight hint of a chance that T1 and T2 COULD become<br/>the same data type.<br/><br/>Of course for IEquatable, and IComparable that's often perfectly<br/>fine, not necessarily true of other operations tho.<br/></remarks> |
