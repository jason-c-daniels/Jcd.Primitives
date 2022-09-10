namespace Jcd.Primitives.Tests;

public class TypePairingTests
{
    [Fact]
    public void Constructor_Sets_Properties_Correctly()
    {
        var t1 = typeof(int);
        var t2 = typeof(double);
        var tp1 = new TypePairing(t1, t2);
        var tp2 = new TypePairing(t2, t1);
        Assert.Equal(t1,tp1.First);
        Assert.Equal(t1,tp2.Second);
        Assert.Equal(t2,tp2.First);
        Assert.Equal(t2,tp1.Second);
    }
    
    [Theory]
    [MemberData(nameof(AreSameTypeData))]
    public void AreSameType_Returns_Expected_Result_For_All_Primitive_Types(TypePairing tp, bool expectedResult)
    {
        Assert.Equal(expectedResult,tp.AreSameType);
    }

    [Theory]
    [MemberData(nameof(AllPairings))]
    public void ToString_Returns_The_Expected_Value(TypePairing tp, string expectedValue)
    {
        Assert.Equal(expectedValue,tp.ToString());
    }
    
    [Fact]
    public void GetHashCode_Returns_Same_Value_When_Both_TypePairings_Use_The_Same_Types_Regardless_Which_Type_Is_First()
    {
        var tp1 = new TypePairing(typeof(int), typeof(uint));
        var tp2 = new TypePairing(typeof(uint), typeof(int));
        Assert.Equal(tp1.GetHashCode(),tp2.GetHashCode());
        Assert.Equal(tp1.GetHashCode(),tp2.GetHashCode());
    }
    
    [Fact]
    public void Equals_Returns_True_When_Both_TypePairings_Use_The_Same_Types_Regardless_Which_Type_Is_First()
    {
        var tp1 = new TypePairing(typeof(int), typeof(uint));
        var tp2 = new TypePairing(typeof(uint), typeof(int));
        Assert.True(tp1.Equals(tp2));
        Assert.True(tp2.Equals(tp1));
    }

    [Fact]
    public void GetHashCode_Returns_Different_Value_When_At_Least_One_Type_Differs()
    {
        var tp1 = new TypePairing(typeof(int), typeof(sbyte));
        var tp2 = new TypePairing(typeof(uint), typeof(int));
        Assert.NotEqual(tp1.GetHashCode(),tp2.GetHashCode());
        Assert.NotEqual(tp1.GetHashCode(),tp2.GetHashCode());
    }
    
    [Fact]
    public void Equals_Returns_False_When_At_Least_One_Type_Differs()
    {
        var tp1 = new TypePairing(typeof(int), typeof(sbyte));
        var tp2 = new TypePairing(typeof(uint), typeof(int));
        Assert.False(tp1.Equals(tp2));
        Assert.False(tp2.Equals(tp1));
    }
    
    public static IEnumerable<object> AllPairings =>
        PrimitiveTypes.CrossProductOfAllNumericTypesAndBoolean
            .Select(tp => new object[] { tp, string.Format(TypePairing.FormatString, tp.First.Name, tp.Second.Name) });

    public static IEnumerable<object[]> AreSameTypeData =>
        PrimitiveTypes.CrossProductOfAllNumericTypesAndBoolean
            .Select(tp => new object[] { tp, tp.First == tp.Second });
}