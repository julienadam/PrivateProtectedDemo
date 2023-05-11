using System.Runtime.CompilerServices;

// Si l'attribut est actif, les membres deviennent accessible dans PrivateProtectedDemo
// [assembly:InternalsVisibleTo("PrivateProtectedDemo")]

namespace PrivateProtectedLib;
public class BaseClass
{
    private protected int someField = 42;
}

public class DerivedClass : BaseClass
{
	public void SomeMethod()
    {
        // Ok
        base.someField = 12;
    }
}

public class SomeOtherClass
{
    public void SomeMethod()
    {
        BaseClass b = new BaseClass();

        // Ne compile pas.
        Console.WriteLine(b.someField);
    }
}