using Jcd.Primitives;
using SynthesizeComparers.Resources;

namespace SynthesizeComparers.Synthesizers.PrimitiveComparer;

public class NondecimalFloatingPointEqualsSynthesizer : NondecimalFloatingPointBaseSynthesizer
{
    #region Overrides of ComparisonMethodSynthesizerBase
    
    /// <inheritdoc />
    public override SynthesizerType SynthesizerType => SynthesizerType.EqualsImplementation;

    /// <inheritdoc />
    public override string Synthesize(TypePairing typePairing)
    {
        if (!CanSynthesize(typePairing)) return string.Empty;
        var (exti1, exti2) = GetExtendedTypeInfo(typePairing);
        // if double-float comparison, upcast to larger.
        if (exti1.IsFloatingPoint && exti2.IsFloatingPoint)
        {
            var (smallerType, largerType) = GetSmallerAndLargerType(typePairing);
            return PrimitiveComparerTemplates.EqualsUpcastToLarger
                .Replace("$smallerType$", smallerType.Name)
                .Replace("$largerType$", largerType.Name);
        }

        var extiFloatingPoint = exti1.IsFloatingPoint ? exti1 : exti2;
        var extiNonfloatingPoint = exti1.IsFloatingPoint ? exti2 : exti1;
        // upcast any non-floating point that's smaller than the float/double, to that type, then compare 
        if (extiFloatingPoint.Size > extiNonfloatingPoint.Size)
        {
            return PrimitiveComparerTemplates.EqualsUpcastToLarger
                .Replace("$smallerType$", extiNonfloatingPoint.Type.Name)
                .Replace("$largerType$", extiFloatingPoint.Type.Name);
        }
        
        // convert both the (U)Int32 and the float to a double then compare.
        if (extiFloatingPoint.Size == extiNonfloatingPoint.Size && extiFloatingPoint.Type == typeof(float))
        {
            return PrimitiveComparerTemplates.EqualsUpcastBoth
                    .Replace("$firstType$", extiFloatingPoint.Type.Name)
                    .Replace("$secondType$", extiNonfloatingPoint.Type.Name)
                    .Replace("$upcastType$", nameof(Double))
                ;
        }

        return string.Empty;
    }

    #endregion
}