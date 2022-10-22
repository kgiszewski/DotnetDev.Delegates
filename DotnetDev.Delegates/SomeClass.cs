namespace DotnetDev.Delegates;

public class SomeClass
{
    public void DoSomething(int iterationCount)
    {
        for (var i = 0; i < iterationCount; i++)
        {
            Console.WriteLine($"Performing iteration: {i}");
        }
    }
}