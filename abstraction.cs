#region Abstract class
abstract class Shape
{
    public abstract int Area();
}
class Square : Shape
{
    private int Side;
    public Square(int x = 0)
    {
        Side = x;
    }

    public override int Area()
    {
        Console.WriteLine("area of the square ");
        return Side*Side;
    }
}
#endregion