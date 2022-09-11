using Jcd.Primitives;
using SynthesizeComparers.Resources;

namespace SynthesizeComparers.Synthesizers;

public class SameSignedCompareSynthesizer : SameSignedBaseSynthesizer
{
    #region Implementation of IComparisonMethodSynthesizer
    
    /// <inheritdoc />
    public  override string Synthesize(TypePairing typePairing)
    {
        if (!CanSynthesize(typePairing)) return string.Empty;
        var (smallerType, largerType) = GetSmallerAndLargerType(typePairing);
        return Templates.CompareUpcastToLarger
            .Replace("$smallerType$", smallerType.Name)
            .Replace("$largerType$", largerType.Name);
    }

    #endregion
}