class Method_Overloading
{
    public int add(int a, int b)
    {
        return a+b;
    }
    public int add(int a, int b, int c) // possible by adding the paramaters
    {
        int sum = a + b + c;
        return sum;
    }
    public double add(double a, double b, double c) // possible by changing the data types 
    {
        double sum = a+b+c;
        return sum;
    }

}