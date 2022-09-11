using System.Diagnostics.CodeAnalysis;

namespace Jcd.Primitives.Tests;

[SuppressMessage("Assertions", "xUnit2004:Do not use equality check to test for boolean conditions")]
public class PrimitiveComparerTests
{
    [Fact]
    public void Equals_Boolean_To_Byte_Returns_Expected_Result()
    {
        Assert.Equal(false,PrimitiveComparer.Equals(true, (Byte)0));
        Assert.Equal(true,PrimitiveComparer.Equals(false, (Byte)0));
        Assert.Equal(true,PrimitiveComparer.Equals(true, (Byte)1));
        Assert.Equal(false,PrimitiveComparer.Equals(false, (Byte)1));
    }
}