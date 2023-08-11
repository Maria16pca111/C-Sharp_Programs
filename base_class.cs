public class Test
{
    string name = "Data Structure and Algorithms Learning";

    public virtual void show_data()
    {
        Console.WriteLine("Test 1: ");
    }
}

class result: Test
{
    string process = "Data Structure and Algorithms Learning Completed";
    public override void show_data()
    {
        base.show_data();
        Console.WriteLine(process);
    }
}

class baseclassconst
{
    int n1, n2;
    public baseclassconst()
    {
        Console.WriteLine("Default Constructor Invoked");
    }
    public baseclassconst(int i, int j)
    {
        n1 =i;
        n2 = j;
        Console.WriteLine("Parameterized Constructor Invoked");
        Console.WriteLine("Invoked values are " + n1 + " and "+ n2);
    }
}

class derivedclassconstr : baseclassconst
{
    public derivedclassconstr():base(){} //This Constructor will instantiate baseclassconst using base keyword

    public derivedclassconstr(int i, int j) : base(i, j){}
}