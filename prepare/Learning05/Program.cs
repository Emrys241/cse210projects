using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        List<Shape> shapes =
new
List<Shape>();

        Square square =
new
 Square(
"Red"
,
5
);
        Rectangle rectangle =
new
 Rectangle(
"Blue"
,
3
,
4
);
        Circle circle =
new
 Circle(
"Green"
,
2.5
);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);


        foreach
         (Shape shape
        in
         shapes)
        {
            Console.WriteLine($"Color: { shape.Color}");
            Console.WriteLine($"Area: { shape.GetArea()}");
            Console.WriteLine();
        }

   }
}