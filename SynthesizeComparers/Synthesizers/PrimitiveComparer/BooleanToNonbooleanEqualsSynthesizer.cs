using Jcd.Primitives;
using SynthesizeComparers.Resources;

namespace SynthesizeComparers.Synthesizers.PrimitiveComparer;

public class BooleanToNonbooleanEqualsSynthesizer : BooleanToNonbooleanBaseSynthesizer
{
    #region Implementation of IComparisonMethodSynthesizer

    /// <inheritdoc />
    public override SynthesizerType SynthesizerType => SynthesizerType.EqualsImplementation;

    /// <inheritdoc />
    public override string Synthesize(TypePairing typePairing)
    {
        var nonbooleanType = (typePairing.First == typeof(bool)) ? typePairing.Second : typePairing.First;
        return CanSynthesize(typePairing) 
            ? PrimitiveComparerTemplates.EqualsBooleanToNonboolean
                .Replace("$nonbooleanType$",nonbooleanType.Name) 
            : string.Empty;
    }

    #endregion
}