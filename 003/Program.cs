// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 3, n = 2 -> A(m,n) = 29


int Prompt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerman(int a, int b)
{
    if (a == 0) return b + 1;
    if (a != 0 && b == 0) return Akkerman(a - 1, 1);
    if (a > 0 && b > 0) return Akkerman(a - 1, Akkerman(a, b - 1));
    return Akkerman(a, b);
}
int m = Prompt("Введите значение m");
int n = Prompt("Введите значение n");
int result = Akkerman(m,n);
System.Console.WriteLine(result);