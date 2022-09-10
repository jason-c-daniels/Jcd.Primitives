namespace Jcd.Primitives.Tests;

public class ExtendedTypeInfoTests
{
    [Theory]
    [MemberData(nameof(NumericDataTypes))]
    public void Constructor_Sets_The_Properties_With_The_Expected_Values(Type t)
    {
        var eti = new ExtendedTypeInfo(t);
        
        Assert.Equal(t,eti.Type);
        Assert.Equal(t.SizeOf(),eti.Size);
        Assert.Equal(t.IsSigned(),eti.IsSigned);
        Assert.Equal(t.IsFloatingPoint(),eti.IsFloatingPoint);
        Assert.Equal(t.IsPrimitiveStructOrEnum(),eti.IsPrimitiveStructOrEnum);
        Assert.Equal(t.IsUserDefinedStructOrEnum(),eti.IsUserDefinedStructOrEnum);
    }

    [Theory]
    [MemberData(nameof(EqualsData))]
    public void Equals_Returns_The_Expected_Result(ExtendedTypeInfo eti1, ExtendedTypeInfo eti2, bool expectedResult)
    {
        Assert.Equal(expectedResult,eti1.Equals(eti2));
        Assert.Equal(expectedResult,eti1 == eti2);
    }
    
    public static IEnumerable<object[]> NumericDataTypes =>
        PrimitiveTypes.NumericTypesAndBoolean.Select( t=> new object[] { t } );
    
    public static IEnumerable<object[]> EqualsData =>
        PrimitiveTypes.CrossProductOfAllNumericTypesAndBoolean.Select(
            tp=> new object[]
            {
                tp.First.GetExtendedTypeInfo(),
                tp.Second.GetExtendedTypeInfo(),
                tp.First==tp.Second
            }
        );
}