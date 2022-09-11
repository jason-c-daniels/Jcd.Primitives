using Jcd.Primitives;

namespace SynthesizeComparers.Synthesizers;

public abstract class DecimalToNondecimalBaseSynthesizer : ComparisonMethodSynthesizerBase
{
    private static Type GetNondecimalType(TypePairing typePairing)
    {
        var nondecimalType = typePairing.First == typeof(decimal)
            ? typePairing.Second
            : typePairing.First;
        return nondecimalType;
    }

    #region Overrides of ComparisonMethodSynthesizerBase

    /// <inheritdoc />
    public override bool CanSynthesize(TypePairing typePairing)
    {
        if (typePairing.AreSameType) return false;
        if (IsEitherSideBool(typePairing)) return false;
        if (!IsEitherSideDecimal(typePairing)) return false;
        var nondecimalType = GetNondecimalType(typePairing);
        return (nondecimalType != typeof(double) && nondecimalType != typeof(float)); // prohibit float to decimal and double to decimal to prevent unwanted exceptions.
    }
    
    #endregion
}