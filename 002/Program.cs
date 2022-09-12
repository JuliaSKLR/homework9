// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum (int a, int b)
{
    if (a > b)
    {
        return 0;
    }
    
    
    return a+Sum (a+1, b);

}

int a = Prompt("Enter a");
int b = Prompt("Enter b");
int result = Sum( a, b);
System.Console.WriteLine(result);