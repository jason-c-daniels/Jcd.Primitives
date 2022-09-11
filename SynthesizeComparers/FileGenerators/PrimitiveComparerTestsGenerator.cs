using System.Text;
using SynthesizeComparers.Synthesizers;

namespace SynthesizeComparers.FileGenerators;

public static class PrimitiveComparerTestsGenerator
{
    public static void Generate(string rootNamespace, string primitiveComparerTypeName, string genericPrimitiveComparerTypeName)
    {
        var sb = new StringBuilder();
        sb.AppendLine($"using System;");
        sb.AppendLine("// ReSharper disable CompareOfFloatsByEqualityOperator");
        sb.AppendLine("// ReSharper disable RedundantCast");
        sb.AppendLine("");
        sb.AppendLine($"namespace {rootNamespace};");
        sb.AppendLine(@$"

/// <summary>
/// A primitive type comparer. Intended for use with {genericPrimitiveComparerTypeName}.
/// </summary>
public static class {primitiveComparerTypeName}");
        sb.AppendLine("{");
        var count = Selector.AllSynthesizablePairings.Count;
        for (var index = 0; index < count; index++)
        {
            var pairing = Selector.AllSynthesizablePairings[index];
            var regionName = $"[{pairing.First.Name} and {pairing.Second.Name} Comparisons]";
            sb.AppendLine($"    #region {regionName}");
            sb.AppendLine($"");
            foreach (var synth in Selector.GetImplementationSynthesizers(pairing))
            {
                sb.AppendLine(synth.Synthesize(pairing));
            }

            sb.AppendLine($"    #endregion // {regionName}");
            if (index < count-1)
                sb.AppendLine($"");
        }

        sb.AppendLine("}");
        
        //File.WriteAllText($"{primitiveComparerTypeName}.cs",sb.ToString());
        Console.WriteLine(sb.ToString());
    }
}