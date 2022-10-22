// See https://aka.ms/new-console-template for more information

using DotnetDev.Delegates;

var someClass = new SomeClass();

someClass.DoSomething(10);

var someClass2 = new SomeClass2();

someClass2.DoSomething(10, i => Console.WriteLine($"Performing iteration: {i}"));

var someClass3 = new SomeClass3();

someClass3.DoSomething(10, i =>
{
    Console.WriteLine($"Performing iteration: {i}");

    return true;
});

await someClass3.DoSomethingAsync(10, i =>
{
    Console.WriteLine($"Performing iteration: {i}");

    return Task.FromResult(true);
});