/*Все массивы от 5-ти элементов
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

/*Console.WriteLine("Сколько чисел в массиве?");
int number = int.Parse(Console.ReadLine());
int[] array = new int[number];

void Three(int[] element)
{
int length = element.Length;
int index = 0;

while (index < length)
{
    element[index] = new Random().Next(100,1000);
    index++;
}
}

void Print(int[] el)
{
    int count = el.Length;
    int pos = 0;
    while (pos<count)
    {
        Console.Write(el[pos] + " ");
        pos++;
    }
}

void CountEven(int[] array)
{
    int co = 0;
    foreach (int elem in array)
    {
        if (elem % 2 == 0)
            co ++;
    }
    Console.WriteLine("Чётных: " + co);
}

Three(array);
Print(array);
Console.WriteLine("");
CountEven(array);
*/

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] array = new int[8];

void Random(int[] element)
{
int length = element.Length;
int index = 0;

while (index < length)
{
    element[index] = new Random().Next(-99,99);
    index++;
}
}

void Print(int[] el)
{
    int count = el.Length;
    int pos = 0;
    while (pos<count)
    {
        Console.Write(el[pos] + ", ");
        pos++;
    }
}

void Sum(int[] summ)
{
    int allsum = 0;
        for (int position = 0; position < summ.Length; position++)    
            if (position % 2 != 0)
            {
                allsum = allsum + summ[position];
            }
    Console.Write("Сумма элементов на нечётной позиции: " + allsum);
}

Random(array);
Print(array);
Console.WriteLine("");
Sum(array);


/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/