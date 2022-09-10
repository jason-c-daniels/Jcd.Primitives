namespace Jcd.Primitives.Tests;

public class TypeExtensionsTests
{
    [Theory]
    [MemberData(nameof(IsFloatingPointData))]
    public void IsFloatingPoint_Returns_Expected_Result(Type t, bool expectedResult)
    {
        Assert.Equal(expectedResult,t.IsFloatingPoint());
    }
    
    [Theory]
    [MemberData(nameof(IsSignedData))]
    public void IsSigned_Returns_Expected_Result(Type t, bool expectedResult)
    {
        Assert.Equal(expectedResult,t.IsSigned());
    }
    
    [Theory]
    [MemberData(nameof(SizeOfData))]
    public void SizeOf_Returns_Expected_Result(Type t, int expectedResult)
    {
        Assert.Equal(expectedResult,t.SizeOf());
    }

    [Theory]
    [MemberData(nameof(IsUserDefinedStructOrEnumData))]
    public void IsUserDefinedStructOrEnum_Returns_Expected_Result(Type t, bool expectedResult)
    {
        Assert.Equal(expectedResult,t.IsUserDefinedStructOrEnum());
    }

    [Theory]
    [MemberData(nameof(IsPrimitiveStructOrEnumData))]
    public void IsPrimitiveStructOrEnum_Returns_Expected_Result(Type t, bool expectedResult)
    {
        Assert.Equal(expectedResult,t.IsPrimitiveStructOrEnum());
    }

    [Theory]
    [MemberData(nameof(NumericDataTypes))]
    public void GetExtendedTypeInfo_Returns_Expected_Result(Type t)
    {
        var expectedEti = new ExtendedTypeInfo(t);
        var eti = t.GetExtendedTypeInfo();
        Assert.Equal(expectedEti,eti);
    }
    
    public static IEnumerable<object[]> SizeOfData
    {
        get
        {
            yield return new object[] { typeof(object), GetSize(typeof(object)) };
            var numerics = PrimitiveTypes.NumericTypes.Select(
                t => new object[] { t, GetSize(t) }
            );
            foreach(var result in numerics) yield return result;
        }
    }

    private static int GetSize(Type t)
    {
        if (t == typeof(bool)) return sizeof(bool);
        if (t == typeof(byte)) return sizeof(byte);
        if (t == typeof(sbyte)) return sizeof(sbyte);
        if (t == typeof(short)) return sizeof(short);
        if (t == typeof(ushort)) return sizeof(ushort);
        if (t == typeof(int)) return sizeof(int);
        if (t == typeof(uint)) return sizeof(uint);
        if (t == typeof(long)) return sizeof(long);
        if (t == typeof(ulong)) return sizeof(ulong);
        if (t == typeof(float)) return sizeof(float);
        if (t == typeof(double)) return sizeof(double);
        if (t == typeof(decimal)) return sizeof(decimal);
        return -1;
    }
    
    public static IEnumerable<object[]> IsSignedData =>
        PrimitiveTypes.NumericTypes.Select(
            t=> new object[]
            {
                t,
                t == typeof(decimal) 
                || t==typeof(double) 
                || t==typeof(float) 
                || t==typeof(sbyte) 
                || t==typeof(short) 
                || t==typeof(int) 
                || t==typeof(long) 
            }
        );

    public static IEnumerable<object[]> IsFloatingPointData =>
        PrimitiveTypes.NumericTypes.Select(
            t=> new object[]
            {
                t,
                t == typeof(double) || t==typeof(float) || t==typeof(decimal) 
            }
        );
    
    public static IEnumerable<object[]> IsUserDefinedStructOrEnumData =>
        PrimitiveTypes.NumericTypes.Select(
            t=> new object[]
            {
                t,
                t.IsValueType && !t.IsPrimitive  
            }
        );
    
    public static IEnumerable<object[]> IsPrimitiveStructOrEnumData =>
        PrimitiveTypes.NumericTypes.Select(
            t=> new object[]
            {
                t,
                t.IsValueType && t.IsPrimitive
            }
        );
    
    public static IEnumerable<object[]> NumericDataTypes =>
        PrimitiveTypes.NumericTypes.Select(
            t=> new object[]
            {
                t
            }
        );
}