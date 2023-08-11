public delegate void printskincolor(string x);
internal class Program
{
    public delegate void person_details(int age);
    public delegate void show();

    public static void Identity(printskincolor mydetails, string color)
    {
        color = "black" + color;
        mydetails(color);
    }
    private static void Main(string[] args)
    {
        BankAccount myAccount = new BankAccount(1000);

        myAccount.Deposit(500);
        Console.WriteLine("Balance: "
                        + myAccount.GetBalance());

        myAccount.Withdraw(1200);
        Console.WriteLine("Balance: "
                        + myAccount.GetBalance());

        if (args.Length > 0)
        {
            Console.WriteLine("Arguments Passed by the Programmer:");

            // To print the command line 
            // arguments using foreach loop
            foreach (object obj in args)
            {
                Console.WriteLine(obj);
            }
        }

        else
        {
            Console.WriteLine("No command line arguments found.");
        }

        Shape sh = new Square(4);
        double result = sh.Area();
        Console.WriteLine(result);

        //Constructor Types
        //Student student = new Student(5, "Rajan");
        //Console.WriteLine(student.rollno, student.name);

        Student student = new Student(5, "Rajan");
        Student s1 = new Student(student);
        Console.WriteLine(s1.details);

        // single inheritance A->B
        Dog dog = new Dog();
        dog.Eat();
        dog.Bark();

        // multi-level inheritance A->B->C
        Horse horse = new Horse();
        horse.Eat();
        horse.Run();
        horse.Gallop();

        // hierarchical inheritance A->B, A->C

        Eagle eagle = new Eagle();
        Penguin penguin = new Penguin();
        eagle.Fly();
        eagle.Hunt();
        penguin.Fly();
        penguin.Swim();

        // multiple inheritance A,B->C
        MyClass myClass = new MyClass();
        myClass.Method1();
        myClass.Method2();

        Solution s2 = new Solution();
        int v = s2.lcs(6, 6, "ABCDEF", "ACDEFG");
        Console.WriteLine("Count is "+v.ToString());

        Method_Overloading m1 = new Method_Overloading();
        Console.WriteLine(m1.add(4,5)); // Initial method
        Console.WriteLine(m1.add(1,2,3)); //same name with the different parameters
        Console.WriteLine(m1.add(2.0,4.0,5.0)); // same name with the same parameters but different data types

        Method_Parameters.AddString(s1:"Geeks",s3:"Geeks",s2:"G");

        string val = "Rajan";
        Method_Parameters.CompareValue(ref val); //Reference Parameters
        Console.WriteLine(val);

        int num;
        Method_Parameters.addnum(out num);
        Console.WriteLine("out Parameters "+ num.ToString());

        Method_Parameters.optional_parameters_detail("Rajan","MCA","CS"); //Optional Paramters
        Method_Parameters.optional_parameters_detail("Manibharathi","MCA","CS","SJC");

        Method_Parameters.dynamic_parameters_detail(30);
        string str1 = "Maria",  str2 ="Sebastin";
        var result1 = Method_Parameters.value_type_parameters_detail(str1, str2);
        Console.WriteLine("First and Middle Name: " + result1);

        var res = Method_Parameters.params_details(20, 49, 56, 69, 78);
        Console.WriteLine(res); 

        baseclass b1 = new baseclass();
        b1.show(); //invoking baseclass methods

        derivedclass b2 = new derivedclass();
        b2.show(); // invoking the derived classx

        baseclassVirtual virtual1 = new baseclassVirtual();
        virtual1.show();  

        derivedclassvirtual v2 = new derivedclassvirtual();
        v2.show();

        result r1 = new result();
        r1.show_data();   

        derivedclassconstr d1 = new derivedclassconstr(); // Invoke No Arguement Constructor see baseclass.cs
        Console.WriteLine();

        derivedclassconstr d2 = new derivedclassconstr(10,20); // Invoke No Arguement Constructor

        person_details p1 = delegate(int age) // Anonymous method
        {
            Console.WriteLine("Person age is " + age);
        };
        p1(23);

        Identity(delegate(string color)//You can pass this method to another method which accepts delegate as a parameter
        {Console.WriteLine("The color of my skin is {0}", color);}, "and white");

        string[] Weekdays; //Array ID Declaration
        Weekdays = new string[]{"Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"};//allocating memory for days

        //Display the elements of weekdays array
        foreach(string day in Weekdays)
        {
            Console.WriteLine(day);
        }

    }
}