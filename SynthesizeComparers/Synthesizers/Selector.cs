using Jcd.Primitives;
using SynthesizeComparers.Synthesizers;

namespace SynthesizeComparers.Synthesizers;

public static class Selector
{
    public static IReadOnlyList<IComparisonMethodSynthesizer> EqualsImplementationSynthesizers = new IComparisonMethodSynthesizer[]
    {
        new Implementation.BooleanToNonbooleanEqualsSynthesizer(),
        new Implementation.SameSignedEqualsSynthesizer(),
        new Implementation.SignedIntToUnsignedIntEqualsSynthesizer(),
        new Implementation.NondecimalFloatingPointEqualsSynthesizer(),
        new Implementation.DecimalToNondecimalEqualsSynthesizer()
    };
    
    public static IReadOnlyList<IComparisonMethodSynthesizer> CompareImplementationSynthesizers = new IComparisonMethodSynthesizer[]
    {
        new Implementation.SameSignedCompareSynthesizer(),
        new Implementation.SignedIntToUnsignedIntCompareSynthesizer(),
        new Implementation.NondecimalFloatingPointCompareSynthesizer(),
        new Implementation.DecimalToNondecimalCompareSynthesizer()
    };

    public static IReadOnlyList<IComparisonMethodSynthesizer> EqualsTestSynthesizers = new IComparisonMethodSynthesizer[]
    {
        new Test.BooleanToNonbooleanEqualsTestSynthesizer(),
        new Test.SameSignedEqualsTestSynthesizer(),
        new Test.SignedIntToUnsignedIntEqualsTestSynthesizer(),
        new Test.NondecimalFloatingPointEqualsTestSynthesizer(),
        new Test.DecimalToNondecimalEqualsTestSynthesizer()
    };
    
    public static IReadOnlyList<IComparisonMethodSynthesizer> CompareTestSynthesizers = new IComparisonMethodSynthesizer[]
    {
        new Test.SameSignedCompareTestSynthesizer(),
        new Test.SignedIntToUnsignedIntCompareTestSynthesizer(),
        new Test.NondecimalFloatingPointCompareTestSynthesizer(),
        new Test.DecimalToNondecimalCompareTestSynthesizer()
    };
    
    
    public static IEnumerable<IComparisonMethodSynthesizer> GetImplementationSynthesizers(TypePairing typePairing)
        =>  (from eq in EqualsImplementationSynthesizers
                where eq.CanSynthesize(typePairing)
                select eq
                )
           .Union(from cmp in CompareImplementationSynthesizers
               where cmp.CanSynthesize(typePairing)
               select cmp
               );
    
    public static readonly IReadOnlyList<TypePairing> AllSynthesizablePairings =
            PrimitiveTypes.CrossProductOfNumericTypes
        // the pairings
        .OrderBy(x=> x.First == typeof(bool) ? -1 : 0)// sort booleans first
        .ThenBy(x=> x.First.GetExtendedTypeInfo().Size) // then sort by size. 
        .ThenBy(x=>x.First.GetExtendedTypeInfo().IsFloatingPoint ? 1 : 0) // sort the sort ints before floats
        .ThenBy(x=>x.First.GetExtendedTypeInfo().IsSigned ? 1 : 0) // then sort unsigned before signed
        // Exclude same type comparisons.
        .Where(x=>!x.AreSameType)
        // Ensure we only grab those where the larger data type is on the left, or the left is bool.
        .Where(x=>x.First.GetExtendedTypeInfo().Size >= x.Second.GetExtendedTypeInfo().Size 
                  || x.First==typeof(bool)
                  || (x.First.GetExtendedTypeInfo().Size >= x.Second.GetExtendedTypeInfo().Size && x.First == typeof(float)) // float && int32/uint32 are upcast to double. So this is safe.
                  )
        // ensure unique pairings now that we've prefiltered and sorted.
        .Distinct()
        // Exclude (u)long to double pairings. Those are lossy conversions an may throw an exception.
        .Where(x=>!(x.First == typeof(ulong) && x.Second == typeof(double)))
        .Where(x=>!(x.First == typeof(double) && x.Second == typeof(ulong)))
        .Where(x=>!(x.First == typeof(long) && x.Second == typeof(double)))
        .Where(x=>!(x.First == typeof(double) && x.Second == typeof(long)))
        // Exclude (u)long to float pairings. Those are lossy conversions an may throw an exception.
        .Where(x=>!(x.First == typeof(ulong) && x.Second == typeof(float)))
        .Where(x=>!(x.First == typeof(float) && x.Second == typeof(ulong)))
        .Where(x=>!(x.First == typeof(long) && x.Second == typeof(float)))
        .Where(x=>!(x.First == typeof(float) && x.Second == typeof(long)))
        // Exclude decimal to float/double pairings. Those are not guaranteed conversions. Some values may throw an exception.
        .Where(x=>!(x.First == typeof(decimal) && x.Second == typeof(double)))
        .Where(x=>!(x.First == typeof(double) && x.Second == typeof(decimal)))
        .Where(x=>!(x.First == typeof(decimal) && x.Second == typeof(float)))
        .Where(x=>!(x.First == typeof(float) && x.Second == typeof(decimal)))
        .ToArray();

}