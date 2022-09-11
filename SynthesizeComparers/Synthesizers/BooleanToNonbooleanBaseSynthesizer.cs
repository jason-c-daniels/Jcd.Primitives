using Jcd.Primitives;

namespace SynthesizeComparers.Synthesizers;

public abstract class BooleanToNonbooleanBaseSynthesizer : ComparisonMethodSynthesizerBase
{
    #region Implementation of IComparisonMethodSynthesizer

    /// <inheritdoc />
    public override bool CanSynthesize(TypePairing typePairing) =>
        IsEitherSideBool(typePairing) && !typePairing.AreSameType;
    
    #endregion
}