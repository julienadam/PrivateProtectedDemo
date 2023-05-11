using PrivateProtectedLib;

Console.WriteLine("Hello, World!");

class DerivedClass2 : BaseClass
{
    void Access()
    {
        // CS0122 car on est pas dans la même assembly
        someField = 42;
    }
}