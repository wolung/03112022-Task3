namespace Reactangle
{

public class ReactangleArea
{
    public void Main()
    {
        Console.WriteLine("Enter the Length of a Rectangle: ");
        int Length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Width of a Rectangle: ");
        int Width = Convert.ToInt32(Console.ReadLine());
        int Area = Length * Width;
        Console.WriteLine("Area of Length " +Length+" and Width "+Width+" Area is "+Area);
        
    }
}

public class ReactanglePerimeter
{
    public void Main2()
    {
        Console.WriteLine("Enter the Length of a Rectangle: ");
        double Length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Width of a Rectangle: ");
        double Width = Convert.ToInt32(Console.ReadLine());
        double Perimeter = 2*Length + 2*Width;
        Console.WriteLine("For Length " +Length+" and Width "+Width+" Perimeter is "+Perimeter);
        
    }
}
}