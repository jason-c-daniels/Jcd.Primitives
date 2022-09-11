using Jcd.Primitives;
using SynthesizeComparers.Resources;

namespace SynthesizeComparers.Synthesizers.Implementation;

public class SignedIntToUnsignedIntEqualsSynthesizer : SignedIntToUnsignedIntBaseSynthesizer
{
    #region Implementation of IComparisonMethodSynthesizer
    
    /// <inheritdoc />
    public override SynthesizerType SynthesizerType => SynthesizerType.EqualsImplementation;
    
    /// <inheritdoc />
    public  override string Synthesize(TypePairing typePairing)
    {
        if (!CanSynthesize(typePairing)) return string.Empty;
        var (exti1, exti2) = GetExtendedTypeInfo(typePairing);
        if (exti1.Size != exti2.Size)
        {
            var (smallerType, largerType) = GetSmallerAndLargerType(typePairing);

            if (smallerType.IsSigned())
                return PrimitiveComparerTemplates.EqualsSmallerSignedToLargerUnsigned
                    .Replace("$signedType$", smallerType.Name)
                    .Replace("$unsignedType$", largerType.Name);

            return PrimitiveComparerTemplates.EqualsSmallerUnsignedToLargerSigned
                .Replace("$unsignedType$", smallerType.Name)
                .Replace("$signedType$", largerType.Name);
        }

        var signedType = exti1.IsSigned ? exti1.Type : exti2.Type;
        var unsignedType = exti1.IsSigned ? exti2.Type : exti1.Type;
        return PrimitiveComparerTemplates.EqualsSameSizeUnsignedToSigned
            .Replace("$unsignedType$", unsignedType.Name)
            .Replace("$signedType$", signedType.Name);
    }

    #endregion
}