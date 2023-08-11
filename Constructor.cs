/*#region Default Constructor
class Student
{
    public int rollno;
    public string name;

    public Student()
    {
        Console.WriteLine("Constructor called");
    }
}
#endregion*/
/*                  qq
#region Parameterized Constructor
class Student
{
    public int? rollno;
    public string? name;

    public Student(int rollno, string name)
    {
        this.rollno = rollno;
        this.name = name;
    }
}
#endregion*/

#region Copy Constructor
class Student
{
    private int? rollno;
    private string? name;

    public Student(Student c) //Copy Constructor
    {
        rollno = c.rollno;
        name = c.name;
    }
    public Student(int rollno, string name) //Instance Constructor
    {
        this.rollno = rollno;
        this.name = name;
    }
    public string details
    {
        get
        {
            return "RollNo" + rollno + "Name" + name;
        }  
    }
}
#endregion