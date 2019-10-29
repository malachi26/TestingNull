public class Class1
{
    public string One { get; set; }
    public string Two { get; set; }
    public Class1()
    {
    }
}

public static class Class2
{
    public static bool returnBoolean(Class1 inputA, Class1 inputB)
    {
        return (inputA?.One == inputB.One);
    }
    

    public static bool checkOnNullProperty(Class1 inputA, Class1 inputB)
    {
        return (inputA.One == inputB.One);
    }

    public static bool CheckEquality(Class1 inputA, Class1 inputB)
    {
        return (inputA.One.Equals(inputB.One));
    }


}
