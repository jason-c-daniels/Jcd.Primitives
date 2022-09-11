using Jcd.Primitives;
using SynthesizeComparers.Resources;

namespace SynthesizeComparers.Synthesizers.PrimitiveComparerTests;

public class DecimalToNondecimalEqualsTestSynthesizer : DecimalToNondecimalBaseSynthesizer
{
    #region Overrides of ComparisonMethodSynthesizerBase
    
    /// <inheritdoc />
    public override SynthesizerType SynthesizerType => SynthesizerType.EqualsTest;

    /// <inheritdoc />
    public override string Synthesize(TypePairing typePairing)
    {
        // TODO: create and select appropriate unit test body templates
        if (!CanSynthesize(typePairing)) return string.Empty;
        var (smallerType, largerType) = GetSmallerAndLargerType(typePairing);
        return PrimitiveComparerTemplates.EqualsUpcastToLarger
            .Replace("$smallerType$", smallerType.Name)
            .Replace("$largerType$", largerType.Name);
    }

    #endregion
}