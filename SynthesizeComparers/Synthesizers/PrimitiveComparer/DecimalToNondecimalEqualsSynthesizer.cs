using Jcd.Primitives;
using SynthesizeComparers.Resources;

namespace SynthesizeComparers.Synthesizers.PrimitiveComparer;

public class DecimalToNondecimalEqualsSynthesizer : DecimalToNondecimalBaseSynthesizer
{
    #region Overrides of ComparisonMethodSynthesizerBase
    
    /// <inheritdoc />
    public override SynthesizerType SynthesizerType => SynthesizerType.EqualsImplementation;

    /// <inheritdoc />
    public override string Synthesize(TypePairing typePairing)
    {
        if (!CanSynthesize(typePairing)) return string.Empty;
        var (smallerType, largerType) = GetSmallerAndLargerType(typePairing);
        return PrimitiveComparerTemplates.EqualsUpcastToLarger
            .Replace("$smallerType$", smallerType.Name)
            .Replace("$largerType$", largerType.Name);
    }

    #endregion
}