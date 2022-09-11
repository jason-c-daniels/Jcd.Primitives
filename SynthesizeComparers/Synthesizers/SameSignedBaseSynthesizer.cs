using Jcd.Primitives;

namespace SynthesizeComparers.Synthesizers;

public abstract class SameSignedBaseSynthesizer : ComparisonMethodSynthesizerBase
{
    /// <inheritdoc />
    public override bool CanSynthesize(TypePairing typePairing)
    {
        if (typePairing.AreSameType) return false;
        if (IsEitherSideBool(typePairing)) return false;
        if (IsEitherSideFloatingPoint(typePairing)) return false;
        if (IsEitherSideDecimal(typePairing)) return false;
        var (exti1, exti2) = GetExtendedTypeInfo(typePairing);
        if (exti1.Size == exti2.Size) return false;
        return exti1.IsSigned == exti2.IsSigned;
    }
}