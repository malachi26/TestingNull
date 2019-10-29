using System;

public class Class1
{
    public string One { get; set; }
    public string Two { get; set; }
    public Class1()
    {

    }


}

public class Class2
{
    public string x { get; set; }
    public string y { get; set; }
    public Class2 ()
    {
        var instance1 = new Class1();
        var instance2 = new Class1();

        instance2.One = "string one";
        instance2.Two = "string two";

        return (instance1?.One == instance2.One);
    }

}
