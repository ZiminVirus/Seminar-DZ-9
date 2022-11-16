// Задача 66: Задайте значения M и N. 
// Напишите программу, которая 
// найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

int SumNaturalNumbers(int num1, int num2)
{

    if (num1 == num2)
    {
        
        System.Console.WriteLine("Числа равны");
        return num1;
        
    }
    if (num1 < num2)
    {

        num1 = num1 + SumNaturalNumbers(num1 + 1, num2);
        return num1;
    }
    if (num1 > num2)
    {

        num1 = num1 + SumNaturalNumbers(num1 - 1, num2);
        return num1;
    }
    return num1;
}

int sumNumber = SumNaturalNumbers(number1, number2);
System.Console.WriteLine($"M = {number1}; N = {number2}. -> {sumNumber}");
