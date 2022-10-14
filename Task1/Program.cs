/* Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B (и в нулевую степень). Использовать свои функции, не использовать Math.Pow */

int a = Number("Введите число: ");
int b = Degree("Введите степень: ");
Console.WriteLine(Calculation(a, b));


int Number(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Degree(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 0)
    {
        Console.WriteLine($"Степень должна быть натуральным числом или 0! Ваше число {num} стало {num * -1}");
        num = num * -1;
    }
    return num;
}

int Calculation(int a, int b)
{
    int i = 0;
    int otvet = 1;
    while(i < b)
    {  
        otvet = otvet * a;
        i++;
    }
    return otvet;
}