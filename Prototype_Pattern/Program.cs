using Prototype_Pattern.Prototype;
using Prototype_Pattern.SubClassPrototypes;

namespace Prototype_Pattern
{
    
    internal class Program
    {
        private static void cloneAndCompare(List<Shape> shapes, List<Shape> shapesCopy)
        {
            foreach (var shape in shapes)
            {
                shapesCopy.Add(shape.Clone());
            }

            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i] != shapesCopy[i])
                {
                    Console.WriteLine(i + ": Shapes are different objects (yay!)");
                    if (shapes[i].equals(shapesCopy[i]))
                    {
                        Console.WriteLine(i + ": And they are identical (yay!)");

                    }
                    else
                    {
                        Console.WriteLine(i + ": But they are not identical (booo!)");

                    }
                }
                else
                {
                    Console.WriteLine(i + ": Shape objects are the same (booo!)");

                }
            }
        }
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            List<Shape> shapesCopy = new List<Shape>();


            Circle circle = new Circle();
            circle.x = 10;
            circle.y = 20;
            circle.radius = 15;
            circle.color = "red";
            shapes.Add(circle);

            Circle anotherCircle = (Circle)circle.Clone();
            shapes.Add(anotherCircle);

            Rectangle rectangle = new Rectangle();
            rectangle.width = 10;
            rectangle.height = 20;
            rectangle.color = "blue";
            shapes.Add(rectangle);

            cloneAndCompare(shapes, shapesCopy);

            Circle c1 = new Circle();
            Shape c2 = new Circle();

            




        }
    }
}