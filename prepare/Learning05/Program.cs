using System;

class Program
{
    static void Main(string[] args)
    {
        Square sq1 = new Square("blue", 4);
        //GetArea(sq1);
        //GetColor(sq1);

        Rectangle rec1 = new Rectangle(5, 4, "pink");
        //GetArea(rec1);
        //GetColor(rec1);

        Circle circ1 = new Circle(4.5, "green");
        //GetArea(circ1);
        //GetColor(circ1);

    List<Shape> shapes = new List<Shape>();
    shapes.Add(circ1);
    shapes.Add(rec1);
    shapes.Add(sq1);

    foreach (Shape shp in shapes)
    {
        double a = shp.GetArea();
        string c = shp.GetColor();
    }
        
    }
public static void GetArea(Shape shape)
{
    double area = shape.GetArea();
    Console.WriteLine($"Your shape is has an area of {area}.");

}
public static void GetColor(Shape shape)
{
    string color = shape.GetColor();
    Console.WriteLine($"The color of your shape is {color}.");
}
}