using SynthesizeComparers.FileGenerators;

var (primitiveComparerType, genericComparerType, rootNamespace, abort) = ProcessArgs(args);
if (abort) return;
//Generate(rootNamespace, primitiveComparerType, genericComparerType);
PrimitiveComparerGenerator.Generate(rootNamespace, primitiveComparerType);

GenericPrimitiveComparerGenerator.Generate(rootNamespace, primitiveComparerType);

(
    string primitiveComparerType, 
    string genericComparerType, 
    string rootNamespaceName,
    bool abort
) ProcessArgs(string[] strings)
{
    var primitiveComparerTypeName = "PrimitiveComparer";
    var genericComparerTypeName = $"Generic{primitiveComparerTypeName}";
    var rootNamespaceName = "Jcd.Primitives";

    if (strings.Length >= 1 && (
            strings[0] == "--help"
            || strings[0] == "-?"
            || strings[0] == "/?"
        )
       )
    {
        Console.WriteLine(@"
usage: SynthesizeComparers [primitiveComparerTypeName] [genericPrimitiveComparerTypeName] [rootNamespace]
       OR
       SynthesizeComparers [primitiveComparerTypeName] [genericPrimitiveComparerTypeName]
       OR
       SynthesizeComparers [primitiveComparerTypeName]
       OR
       SynthesizeComparers [primitiveComparerTypeName]
       OR
       SynthesizeComparers
       OR
       SynthesizeComparers --help (shows this message)

The following defaults are applied when any parameter is omitted:
       primitiveComparerTypeName=PrimitiveComparer 
       genericPrimitiveComparerTypeName=Generic{primitiveComparerTypeName}
       rootNamespace=Jcd.Primitives

This tool emits two files compatible with C# 10.
{PrimitiveComparerTypeName}.cs which contains all of the synthesized .Compare and 
                               .Equals methods for types that normally don't get sensible
                               .Equals and .CompareTo implementations by default.

{GenericPrimitiveComparerTypeName}.cs which contains two methods: 
        Compare<T1,T2>(T1 x, T2 y) - this performs runtimes checks (slow!) to see if 
                                     any of the following are true, in order.
                 * T1 and T2 are actually the same type
                 * A semantically correct native implementation of T1.CompareTo(T2) exists.   
                 * {PrimitiveComparerTypeName} has a generated Compare(T1 x, T2 y)
                 * T1 implements IComparable<T2>
                 If any are true the correct call is made.
                 T1 and T2 are both constrained to be structs.

        Equals<T1,T2>(T1 x, T2 y) - this performs runtimes checks (slow!) to see if 
                                    any of the following are true
                 * T1 and T2 are actually the same type
                 * A semantically correct native implementation of T1.Equals(T2) exists.   
                 * {PrimitiveComparerTypeName} has a generated Equals(T1 x, T2 y)
                 * T1 implements IEquatable<T2>
                 If any are true the correct call is made.
                 T1 and T2 are both constrained to be structs.
");
        return (primitiveComparerTypeName, genericComparerTypeName, rootNamespaceName, true);
    }

    if (strings.Length >= 1)
    {
        primitiveComparerTypeName = strings[0];
        genericComparerTypeName = $"Generic{primitiveComparerTypeName}";
    }

    if (strings.Length >= 2)
    {
        genericComparerTypeName = strings[1];
    }

    if (strings.Length >= 3)
    {
        primitiveComparerTypeName = strings[0];
        genericComparerTypeName = strings[1];
        rootNamespaceName = strings[3];
    }

    return (primitiveComparerTypeName, genericComparerTypeName, rootNamespaceName, false);
}

/*
foreach (var pairing in synthesizablePairings)
{
    Console.WriteLine(pairing + $@"; synths: {string.Join(", ", Selector.GetSynthesizers(pairing).Select(s=>s.GetType().Name))}");    
}
*/
