rectangle any = new rectangle ();

Console.WriteLine("What do you want measure?");
Console.WriteLine("1 - Area");
Console.WriteLine("2 - Perimeter");
int menu = Convert.ToInt32(Console.ReadLine());

if (menu == 1)
{
    any.RectangleArea();
}
else
{
    if (menu == 2)
    {
        any.RectanglePerimeter();
    }
    else
    {
        Console.WriteLine("Wrong choice");
    }
}

Console.ReadKey();