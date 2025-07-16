using LiskovSubstitutionPrinciple.Problem;
using LiskovSubstitutionPrinciple.Solution;

public class Program
{
    public static void Main(string[] args)
    {
        // Without Liskov Substitution Principle
        BirdProblem birdProblem = new BirdProblem();
        birdProblem.Fly();

        BirdProblem sparrowProblem = new SparrowProblem();
        sparrowProblem.Fly();

        BirdProblem penguinProblem = new PenguinProblem();
        penguinProblem.Fly();

        // With Liskov Substitution Principle
        BirdSolution sparrowSolution = new SparrowSolution();
        sparrowSolution.Move();

        BirdSolution penguinSolution = new PenguinSolution();
        penguinSolution.Move();
    }
}