namespace DotnetDev.Delegates;

public class SomeClass2
{
    public void DoSomething(int iterationCount, Action<int> actionDelegate)
    {
        for (var i = 0; i < iterationCount; i++)
        {
            actionDelegate(i);
        }
    }
}