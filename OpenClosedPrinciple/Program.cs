using OpenClosedPrinciple.Problem;
using OpenClosedPrinciple.Solution;

public class Program
{
    public static void Main(string[] args)
    {
        // This violates the Open/Closed Principle as we need to modify the AreaProblem class
        AreaProblem areaProblem = new AreaProblem();
        // Calculate area of a rectangle
        areaProblem.RectangleArea(5, 10);
        // Calculate area of a circle
        areaProblem.CircleArea(7);
        // Need to change AreaProblem to add triangle area calculation

        // IShape is an interface that adheres to the Open/Closed Principle
        // RectangleSolution is a new class that adheres to the Open/Closed Principle
        RectangleSolution rectangleSolution = new RectangleSolution
        {
            Width = 5,
            Height = 10
        };
        rectangleSolution.CalculateArea();
        // CircleSolution is a new class that adheres to the Open/Closed Principle
        CircleSolution circleSolution = new CircleSolution
        {
            Radius = 7
        };
        circleSolution.CalculateArea();
        // TriangleSolution is a new class that adheres to the Open/Closed Principle
        TriangleSolution triangleSolution = new TriangleSolution
        {
            Base = 5,
            Height = 10
        };
        triangleSolution.CalculateArea();


    }
}