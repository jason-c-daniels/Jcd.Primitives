#### [Jcd.Primitives](index.md 'index')
### [Jcd.Primitives](Jcd.Primitives.md 'Jcd.Primitives').[IDisjointComparer&lt;T1,T2&gt;](Jcd.Primitives.IDisjointComparer_T1,T2_.md 'Jcd.Primitives.IDisjointComparer<T1,T2>')

## IDisjointComparer<T1,T2>.Compare(T2, T1) Method

Compares an instance of T1 to an instance of T2.

```csharp
int Compare(T2 x, T1 y);
```
#### Parameters

<a name='Jcd.Primitives.IDisjointComparer_T1,T2_.Compare(T2,T1).x'></a>

`x` [T2](Jcd.Primitives.IDisjointComparer_T1,T2_.md#Jcd.Primitives.IDisjointComparer_T1,T2_.T2 'Jcd.Primitives.IDisjointComparer<T1,T2>.T2')

The first item to compare

<a name='Jcd.Primitives.IDisjointComparer_T1,T2_.Compare(T2,T1).y'></a>

`y` [T1](Jcd.Primitives.IDisjointComparer_T1,T2_.md#Jcd.Primitives.IDisjointComparer_T1,T2_.T1 'Jcd.Primitives.IDisjointComparer<T1,T2>.T1')

The second item to compare

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
*  0 when x == y  
* -1 when x lt; y  
*  1 when x gt; y