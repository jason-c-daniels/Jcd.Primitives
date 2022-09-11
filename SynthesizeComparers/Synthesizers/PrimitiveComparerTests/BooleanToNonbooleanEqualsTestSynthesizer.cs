using Jcd.Primitives;
using SynthesizeComparers.Resources;

namespace SynthesizeComparers.Synthesizers.PrimitiveComparerTests;

public class BooleanToNonbooleanEqualsTestSynthesizer : BooleanToNonbooleanBaseSynthesizer
{
    #region Implementation of IComparisonMethodSynthesizer
    
    /// <inheritdoc />
    public override SynthesizerType SynthesizerType => SynthesizerType.EqualsTest;

    /// <inheritdoc />
    public override string Synthesize(TypePairing typePairing)
    {
        // TODO: create and select appropriate unit test body templates
        var nonbooleanType = (typePairing.First == typeof(bool)) ? typePairing.Second : typePairing.First;
        return CanSynthesize(typePairing) 
            ? PrimitiveComparerTemplates.EqualsBooleanToNonboolean
                .Replace("$nonbooleanType$",nonbooleanType.Name) 
            : string.Empty;
    }

    #endregion
}