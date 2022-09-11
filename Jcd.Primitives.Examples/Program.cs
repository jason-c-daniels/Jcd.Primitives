// See https://aka.ms/new-console-template for more information
Console.WriteLine(@"Hello, World!");


// add examples here.



void TryIt(string actionName, Action runme)
{
    try
    {
        runme.Invoke();
        Console.WriteLine($@"{actionName} worked");
    }
    catch (Exception ex)
    {
        Console.WriteLine($@"{actionName} Exception:{ex.Message}");
    }
}