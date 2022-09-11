using Jcd.Primitives;

namespace SynthesizeComparers.Synthesizers;

public abstract class NondecimalFloatingPointBaseSynthesizer : ComparisonMethodSynthesizerBase
{
    #region Overrides of ComparisonMethodSynthesizerBase

    /// <inheritdoc />
    public override bool CanSynthesize(TypePairing typePairing)
    {
        if (typePairing.AreSameType) return false;
        if (IsEitherSideBool(typePairing)) return false;
        if (IsEitherSideDecimal(typePairing)) return false;
        return IsEitherSideFloatingPoint(typePairing);
    }

    #endregion
}