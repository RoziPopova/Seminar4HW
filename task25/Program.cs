/*
Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int GetPowerNumber(int num1, int num2)
{
    for (int i = 1; i < num2; i++)
    {
        num1 *= num1;
    }
    return num1;
}

Console.Write("Введите число А: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int power = GetPowerNumber(number1, number2);
Console.WriteLine($"Число {number1} в степени {number2} равно {power}");