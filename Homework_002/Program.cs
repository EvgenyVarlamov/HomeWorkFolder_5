/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.WriteLine("Введите количество элементов массива: ");
int qty = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[qty];

FillArray(arr, qty);
int sum = OddPositionSum(arr);
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях массива: " + sum);

void FillArray( int[] array, int quantity)
{
    Console.Write("Массив: { ");
    for(int i = 0; i < quantity; i++)
        {
             array[i] = new Random().Next(-99, 100);
             Console.Write(array[i]);
             if(i < quantity - 1) Console.Write(", ");
        }
    Console.Write(" }"); 
    Console.WriteLine();    
}

int OddPositionSum(int[] array)
{
    int oddSum = 0;
    for(int i = 0; i < array.Length; i++)
         {
             if(i% 2 == 1) oddSum += array[i];
         }
    return oddSum;
}