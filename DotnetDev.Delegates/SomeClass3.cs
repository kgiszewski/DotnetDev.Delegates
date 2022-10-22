namespace DotnetDev.Delegates;

public class SomeClass3
{
    public void DoSomething(int iterationCount, Func<int, bool> funcDelegate)
    {
        for (var i = 0; i < iterationCount; i++)
        {
            var someBool = funcDelegate(i);
        }
    }
    
    public async Task DoSomethingAsync(int iterationCount, Func<int, Task<bool>> funcDelegateAsync)
    {
        for (var i = 0; i < iterationCount; i++)
        {
            var someBool = await funcDelegateAsync(i);
        }
    }
}