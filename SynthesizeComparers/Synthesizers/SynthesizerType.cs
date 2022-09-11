namespace SynthesizeComparers.Synthesizers;

public readonly struct SynthesizerType
{
    private readonly byte _value;
    public readonly string Name;
    public readonly string MethodName; 

    public static SynthesizerType Undefined = new (0, nameof(Undefined),"!None!");
    public static SynthesizerType EqualsImplementation = new (1, nameof(EqualsImplementation),"Equals");
    public static SynthesizerType CompareImplementation = new (2, nameof(CompareImplementation),"Compare");
    public static SynthesizerType EqualsTest = new (3, nameof(EqualsTest),"Equals");
    public static SynthesizerType CompareTest = new (3, nameof(CompareTest),"Compare");

    private SynthesizerType(byte value, string name, string methodName) => 
        (_value, Name, MethodName )= (value, name, methodName);
    
    #region Equality members

    /// <summary>
    /// Compares this instance to another for equivalence.
    /// </summary>
    /// <param name="other">the other instance to compare against.</param>
    /// <returns>True if equivalent.</returns>
    public bool Equals(SynthesizerType other)
    {
        return _value == other._value;
    }

    /// <inheritdoc />
    public override bool Equals(object? obj)
    {
        return obj is SynthesizerType other && Equals(other);
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        return _value.GetHashCode();
    }

    /// <summary>
    /// The equals operator. 
    /// </summary>
    /// <param name="left">the left hand operand</param>
    /// <param name="right">the right hand operand</param>
    /// <returns>true if equivalent</returns>
    public static bool operator ==(SynthesizerType left, SynthesizerType right)
    {
        return left.Equals(right);
    }

    /// <summary>
    /// The not equals operator.
    /// </summary>
    /// <param name="left">the left hand operand</param>
    /// <param name="right">the right hand operand</param>
    /// <returns>true if not equivalent</returns>
    public static bool operator !=(SynthesizerType left, SynthesizerType right)
    {
        return !left.Equals(right);
    }

    #endregion
    
}