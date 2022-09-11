using Jcd.Primitives;

namespace SynthesizeComparers.Synthesizers;

public abstract class ComparisonMethodSynthesizerBase : IComparisonMethodSynthesizer
{
    /// <inheritdoc />
    public abstract SynthesizerType SynthesizerType { get; }
    
    protected static (Type smallerType, Type largerType) GetSmallerAndLargerType(TypePairing typePairing)
    {
        var (exti1, exti2) = GetExtendedTypeInfo(typePairing);
        var smallerType = exti1.Size < exti2.Size ? exti1.Type : exti2.Type;
        var largerType = exti1.Size > exti2.Size ? exti1.Type : exti2.Type;
        return (smallerType, largerType);
    }
    
    protected static (ExtendedTypeInfo exti1, ExtendedTypeInfo exti2)
        GetExtendedTypeInfo(TypePairing typePairing) =>
        new(typePairing.First.GetExtendedTypeInfo(), typePairing.Second.GetExtendedTypeInfo());

    protected static bool IsEitherSideFloatingPoint(TypePairing typePairing)
    {
        var (exti1, exti2) = GetExtendedTypeInfo(typePairing);
        return exti1.IsFloatingPoint || exti2.IsFloatingPoint;
    }

    protected static bool IsEitherSideBool(TypePairing typePairing) =>
        typePairing.First == typeof(bool) || typePairing.Second == typeof(bool);
    
    protected static bool IsEitherSideDecimal(TypePairing typePairing) =>
        typePairing.First == typeof(decimal) || typePairing.Second == typeof(decimal);

    #region Implementation of IComparisonMethodSynthesizer

    /// <inheritdoc />
    public abstract bool CanSynthesize(TypePairing typePairing);

    /// <inheritdoc />
    public abstract string Synthesize(TypePairing typePairing);
    
    #endregion
}