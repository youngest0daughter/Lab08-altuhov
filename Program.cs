static void PrintLine()
{
    Console.WriteLine(":)");
}
static void PrintHeader(string title)
{
    PrintLine();
    Console.WriteLine(title);
    PrintLine();
}
static int Max(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}
static bool IsEven(int n)
{
    if (n % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
//Задание 1
// PrintLine();
// Console.WriteLine("Отчет");
// PrintLine();
// PrintHeader("Заголовок");
// Задание 2.1
Console.WriteLine(Max(1, 2));
Console.WriteLine(Max(4, 2));
Console.WriteLine(IsEven(4));
Console.WriteLine(IsEven(7));
Console.WriteLine(IsEven(0));
