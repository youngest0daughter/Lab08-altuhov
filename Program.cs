//Задание 1
// PrintLine();
// Console.WriteLine("Отчет");
// PrintLine();
// PrintHeader("Заголовок");
// Задание 2.1
// Console.WriteLine(Max(1, 2));
// Console.WriteLine(Max(4, 2));
// Задание 2.2
// Console.WriteLine(IsEven(4));
// Console.WriteLine(IsEven(7));
// Console.WriteLine(IsEven(0));
// Задание 3
// int[] marks = { 120, 45, 300, 80, 15, 210 };
// Console.WriteLine(Average(marks));
// Console.WriteLine(CountGreater(marks, 100));
// Задание 4
// Console.WriteLine(ToFahrenheit(0));
// Console.WriteLine(ToFahrenheit(100));
// Console.WriteLine(ToFahrenheit(37));
// Задание 5
// Console.WriteLine(Factorial(5));
// for (int i = 2; i <51; i++)
// {
//     if (BoolIsPrime(i) == true)
//     {
//         System.Console.WriteLine(i);
//     }
// }
// Задание 6
int a1 = ReadPositive("Введите первое число: ");
int a2 = ReadPositive("Введите второе число: ");
Console.WriteLine($"Сумма: {a1 + a2}");












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
static double Average(int[] arr)
{
    int sum = 0;
    foreach (int x in arr)
    {
        sum += x;
    }
    double a = sum / arr.Length;
    return a;
}
static int CountGreater(int[] arr, int limit)
{
    int sum = 0;
    foreach (int x in arr)
    {
        if (x > limit)
        {
            sum += 1;
        }
    }
    return sum;
}
static double ToFahrenheit(double celsius)
{
    return celsius * 9 / 5 + 32;
}
static long Factorial(int n)
{
    long factorial = 1;
    for (int i = 0; i < n; i++)
    {
        factorial += factorial * i;
    }
    return factorial;
} 
static bool BoolIsPrime(int n)
{
    int a = 0;
    for (int i = 1; i < n + 1; i++)
    {
        if (n % i == 0)
        {
            a += 1;
        }
    }
    if (a == 2)
    {
        return true;
    }
    else
    {
        return false;
    }

}
static int ReadPositive(string message)
{
    int a;
    do
    {
        Console.Write(message);
        a = int.Parse(Console.ReadLine()!);
    } while (a <= 0);
    return a;
}