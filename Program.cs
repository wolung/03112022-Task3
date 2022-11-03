

Console.WriteLine("What do you want measure?");
Console.WriteLine("1 - Area");
Console.WriteLine("2 - Perimeter");
int menu = Convert.ToInt32(Console.ReadLine());

if (menu == 1)
{
    new Reactangle.ReactangleArea();
}
else
{
    if (menu == 2)
    {
        new Reactangle.ReactanglePerimeter();
    }
    else
    {
        Console.WriteLine("Wrong choice");
    }
}

Console.ReadKey();