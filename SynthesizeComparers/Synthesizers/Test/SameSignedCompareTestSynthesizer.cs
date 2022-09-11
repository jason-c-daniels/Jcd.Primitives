using Jcd.Primitives;
using SynthesizeComparers.Resources;

namespace SynthesizeComparers.Synthesizers.Test;

public class SameSignedCompareTestSynthesizer : SameSignedBaseSynthesizer
{
    #region Implementation of IComparisonMethodSynthesizer
    
    /// <inheritdoc />
    public override SynthesizerType SynthesizerType => SynthesizerType.CompareTest;
    
    /// <inheritdoc />
    public  override string Synthesize(TypePairing typePairing)
    {
        // TODO: create and select appropriate unit test body templates
        if (!CanSynthesize(typePairing)) return string.Empty;
        var (smallerType, largerType) = GetSmallerAndLargerType(typePairing);
        return PrimitiveComparerTemplates.CompareUpcastToLarger
            .Replace("$smallerType$", smallerType.Name)
            .Replace("$largerType$", largerType.Name);
    }

    #endregion
}