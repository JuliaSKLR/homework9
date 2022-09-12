//Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ShowEven(int numberStart, int numberFinish)
{
    
    if(numberStart > numberFinish)
    {
        return;
    }
    if (numberStart%2 >0) numberStart = numberStart +1;
    
    System.Console.WriteLine(numberStart);
    ShowEven(numberStart+2, numberFinish);
   
}

int number1 = Prompt("Введите первое число > ");
int number2 = Prompt("Введите второе число > ");
ShowEven(number1 , number2);
