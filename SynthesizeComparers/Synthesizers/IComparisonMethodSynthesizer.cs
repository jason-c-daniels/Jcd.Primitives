using Jcd.Primitives;

namespace SynthesizeComparers.Synthesizers;

/// <summary>
/// The interface definition for any comparison (Compare or Equals) method synthesizing.
/// </summary>
public interface IComparisonMethodSynthesizer
{
    /// <summary>
    /// Gets the synthesizer type information.
    /// </summary>
    public SynthesizerType SynthesizerType { get; }
    
    /// <summary>
    /// Returns true if the implementation can synthesize the requested type of method.
    /// </summary>
    /// <param name="typePairing">the pair of types to synthesize the method for.</param>
    /// <returns>True if it's possible to synthesize a code snippet with one or more (usually two) correctly executing methods.</returns>
    bool CanSynthesize(TypePairing typePairing);

    /// <summary>
    /// Generates the requested method(s).
    /// </summary>
    /// <param name="typePairing">The type pair for which method synthesization has been requested.</param>
    /// <returns>The text for the method(s)</returns>
    public string Synthesize(TypePairing typePairing);
}