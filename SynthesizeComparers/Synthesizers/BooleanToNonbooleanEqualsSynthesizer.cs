using Jcd.Primitives;
using SynthesizeComparers.Resources;

namespace SynthesizeComparers.Synthesizers;

public class BooleanToNonbooleanEqualsSynthesizer : ComparisonMethodSynthesizerBase
{
    #region Implementation of IComparisonMethodSynthesizer

    /// <inheritdoc />
    public override bool CanSynthesize(TypePairing typePairing) =>
        IsEitherSideBool(typePairing) && !typePairing.AreSameType;

    /// <inheritdoc />
    public override string Synthesize(TypePairing typePairing)
    {
        var nonbooleanType = (typePairing.First == typeof(bool)) ? typePairing.Second : typePairing.First;
        return CanSynthesize(typePairing) 
            ? Templates.EqualsBooleanToNonboolean
                .Replace("$nonbooleanType$",nonbooleanType.Name) 
            : string.Empty;
    }

    #endregion
}