using System.Diagnostics;
using Jcd.Primitives;
using SynthesizeComparers.Resources;

namespace SynthesizeComparers.Synthesizers.Test;

public class DecimalToNondecimalCompareTestSynthesizer : DecimalToNondecimalBaseSynthesizer
{
    #region Overrides of ComparisonMethodSynthesizerBase
    
    /// <inheritdoc />
    public override SynthesizerType SynthesizerType => SynthesizerType.CompareTest;

    /// <inheritdoc />
    public override string Synthesize(TypePairing typePairing)
    {
        // TODO: create and select appropriate unit test body templates
        if (!CanSynthesize(typePairing)) return string.Empty;
        var (smallerType, largerType) = GetSmallerAndLargerType(typePairing);
        var result= PrimitiveComparerTemplates.CompareUpcastToLarger
            .Replace("$smallerType$", smallerType.Name)
            .Replace("$largerType$", largerType.Name);
        Debug.WriteLine(result);
        return result;
    }

    #endregion
}