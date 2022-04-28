/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.WriteLine("Введите количество элементов массива");
int qty = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[qty];

FillArray(arr, qty);
int result = EveNumberQty(arr);
Console.WriteLine("Количество чётных чисел массива: " + result);

void FillArray( int[] array, int quantity)
{
    Console.Write("Массив: { ");
    for(int i = 0; i < quantity; i++)
        {
             array[i] = new Random().Next(100, 1000);
             Console.Write(array[i]);
             if(i < quantity - 1) Console.Write(", ");
        }
    Console.Write(" }"); 
    Console.WriteLine();    
}

int EveNumberQty(int[] array)
{
    int evenNumber = 0;
    for(int i = 0; i < array.Length; i++)
         {
             if(array[i] % 2 == 0) evenNumber ++; 
         }
    return evenNumber;
}