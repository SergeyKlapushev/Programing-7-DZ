/* Напишите программу, которая из массива случайных чисел. Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). Постарайтесь сделать одним циклом
[1, 3, 5, 6, 6, 4] -> 5 */

int [] array = {-1, 0};
int len = array.Length;
int max = array[0];
int secondMax = 0;

if (len > 1)
{
    secondMax = array[1];

    for (int i = 0; i < len; i++)
    {

       if (array[i] < max && array[i] > secondMax)
       {
            secondMax = array[i];
       }

       if (max < array[i])
       {
            secondMax = max;
            max = array[i];             
       }
    }
    if (max == secondMax)
    {
        Console.WriteLine("Максимум = " + max);
        Console.WriteLine("Второго максимума нет");
    }
    else 
    {
        Console.WriteLine("Максимум = " + max);
        Console.WriteLine("Второй максимум = " + secondMax);    
    }
}
else
    {
        Console.WriteLine(max);
        Console.WriteLine("Второго максимума нет");
    }


