/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Console.WriteLine("Введите количество элементов массива:");
int qty = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[qty];

FillArray(arr, qty);
// int differrence = MaxMinDiff(arr);
// Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + differrence);
Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + MaxMinDiff(arr));

void FillArray( int[] array, int quantity)
{
    Console.Write("Массив: { ");
    for(int i = 0; i < quantity; i++)
        {
             array[i] = new Random().Next(0, 100);
             Console.Write(array[i]);
             if(i < quantity - 1) Console.Write(", ");
        }
    Console.Write(" }"); 
    Console.WriteLine();    
}


int MaxMinDiff(int[] array)
{
    int maxValue = array[0];
    int minValue = array[0];
    for(int i = 0; i < array.Length; i++)
         {
             if(array[i] > maxValue) maxValue = array[i];
             if(array[i] < minValue) minValue = array[i];
         }
    return maxValue-minValue;
}