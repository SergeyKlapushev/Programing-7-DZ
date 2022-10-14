/*Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Функция должна на вход принимать число, а выдавать сумму его цифр

452 -> 11
82 -> 10
9012 -> 12*/ 

int num = Number("Введите число: ");
int a = 10;
int b = 0;
int otvet = 0;
Console.WriteLine($"Сумма цифр числа {num} = {Calculation(num, a, b, otvet)}");


int Number(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Calculation (int num, int a, int b, int otvet)
{
    while(num >= a)
    {
        b = (num%a)/(a/10);
        a *=10;
        otvet = otvet + b;
    }
    b = (num%a)/(a/10);
    otvet = otvet + b;
    return otvet;
}