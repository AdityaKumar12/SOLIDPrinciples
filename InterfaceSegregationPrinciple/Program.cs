using InterfaceSegregationPrinciple.Problem;
using InterfaceSegregationPrinciple.Solution;

public class Program
{
    public static void Main(string[] args)
    {
        // Problematic code that violates the Interface Segregation Principle
        IMammalProblem human = new HumanProblem();
        human.Walk();
        human.Swim();
        human.Fly(); // Humans cannot fly, but the interface requires it
        human.Eat();
        human.Sleep();
        IMammalProblem bat = new BatProblem();
        human.Walk();
        human.Swim(); // Bats cannot swim, but the interface requires it
        human.Fly(); 
        human.Eat();
        human.Sleep();
        IMammalProblem dolphin = new DolphinProblem();
        human.Walk(); // Dolphins cannot walk, but the interface requires it
        human.Swim();
        human.Fly(); // Dolphins cannot fly, but the interface requires it
        human.Eat();
        human.Sleep();

        // Solution using the Interface Segregation Principle
        //Human can walk, swim, eat, and sleep
        IMammalSolution humanMammal = new HumanSolution();
        humanMammal.Eat();
        humanMammal.Sleep();
        IWalkingMammalSolution walkingHuman = new HumanSolution();
        walkingHuman.Walk();
        ISwimmingMammalSolution swimmingHuman = new HumanSolution();
        swimmingHuman.Swim();

        // Bat can walk, fly, eat, and sleep
        IMammalSolution batMammal = new BatSolution();
        batMammal.Eat();
        batMammal.Sleep();
        IWalkingMammalSolution walkingBat = new BatSolution();
        walkingBat.Walk();
        IFlyingMammalSolution flyingBat = new BatSolution();
        flyingBat.Fly();

        // Dolphin can swim, eat, and sleep
        IMammalSolution dolphinMammal = new DolphinSolution();
        dolphinMammal.Eat();
        dolphinMammal.Sleep();
        ISwimmingMammalSolution swimmingDolphin = new DolphinSolution();
        swimmingDolphin.Swim();
    }
}