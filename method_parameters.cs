class Method_Parameters
{
    public static void AddString(string s1, string s2, string s3) //Named Parameters
    {
        string result = s1 + s2 + s3;
        Console.WriteLine(result);
    }
    public static void CompareValue(ref string val1) //Reference Parameters
    {
        if(val1 == "Rajan")
        {
            Console.WriteLine("Value passed");
        }
        //assigning new value
        val1 = "Richard";
    }
    public static void addnum(out int num) // out parameters
    {
        num = 40;
        num += 40;
    }

    public static void optional_parameters_detail(string name, string course, string department, string college= "St.Joseph's College, Trichy", int year=2023)
    {
        Console.WriteLine("Student(s) name{0} ", name);
        Console.WriteLine("Selected Course{0} ", course);
        Console.WriteLine($"Department {department} College {college}");
    }

    public static void dynamic_parameters_detail(dynamic val)
    {
        val *= 30;
        //Console.WriteLine($"Result is {val}");
        Console.WriteLine("Result is "+val);
    }
    
    public static string value_type_parameters_detail(string s1, string s2)
    {
        return s1+s2;
    }

    public static int params_details(params int[] num)
    {
        int res = 1;
        foreach(int j in num)
        {
            res *= j;
        }
        return res;
    }
}