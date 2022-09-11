using Jcd.Primitives;
using SynthesizeComparers.Resources;

namespace SynthesizeComparers.Synthesizers.Test;

public class SignedIntToUnsignedIntCompareTestSynthesizer : SignedIntToUnsignedIntBaseSynthesizer
{
    #region Implementation of IComparisonMethodSynthesizer
    
    /// <inheritdoc />
    public override SynthesizerType SynthesizerType => SynthesizerType.CompareTest;
    
    /// <inheritdoc />
    public  override string Synthesize(TypePairing typePairing)
    {
        // TODO: create and select appropriate unit test body templates
        if (!CanSynthesize(typePairing)) return string.Empty;
        var (exti1, exti2) = GetExtendedTypeInfo(typePairing);
        if (exti1.Size != exti2.Size)
        {
            var (smallerType, largerType) = GetSmallerAndLargerType(typePairing);

            if (smallerType.IsSigned())
                return PrimitiveComparerTemplates.CompareSmallerSignedToLargerUnsigned
                    .Replace("$signedType$", smallerType.Name)
                    .Replace("$unsignedType$", largerType.Name);

            return PrimitiveComparerTemplates.CompareSmallerUnsignedToLargerSigned
                .Replace("$unsignedType$", smallerType.Name)
                .Replace("$signedType$", largerType.Name);
        }

        var signedType = exti1.IsSigned ? exti1.Type : exti2.Type;
        var unsignedType = exti1.IsSigned ? exti2.Type : exti1.Type;
        return PrimitiveComparerTemplates.CompareSameSizeUnsignedToSigned
            .Replace("$unsignedType$", unsignedType.Name)
            .Replace("$signedType$", signedType.Name);
    }

    #endregion
}