// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] FillArray (int count)
{
int[] myArray = new int[count];
for(int i=0; i< myArray.Length; i++)
{
    myArray[i] = new Random().Next (100, 1000);
}
return myArray;
}

Console.Write("Введите длину массива:  ");
int num = Convert.ToInt32(Console.ReadLine());
    // Random rand = new Random();

int[] myArray = FillArray(num);
// int[] myArray = {345, 897, 568, 234};
            int count = 0;
 
            for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] %2 == 0)
            {
                count++;
            }
        }
        
Console.WriteLine( $"Количество четных чисел равно {count}" );



//////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////



// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [ 10, 11, 12, 13, 14 ] -> 5




int[] FillArray (int count)
{
int[] myArray = new int[count];
for(int i=0; i< myArray.Length; i++)
{
    myArray[i] = new Random().Next (10, 100);
}
return myArray;
}

   Console.Write("Введите длину массива:  ");
int num = Convert.ToInt32(Console.ReadLine());
   
int count = 123;
int[] a = new int[count];
Random random = new Random();
for(int i = 0; i < a.Length; i++)
a[i] = random.Next(0,10);
for(int i=0;i<a.Length;i++)
System.Console.Write($"{a[i],4}");

int A=0;
for(var i=0; i<a.Length;i++)
{
if(i>10 && i<99)
count++;
}
System.Console.WriteLine();
System.Console.WriteLine(A);

//////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(индексах).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int index1;
int index2;

int[] myArray = new int[4] {3,7,23,12};

Console.Write("Первый индекс:  ");
  index1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Второй Индекс:  ");
  index2 = Convert.ToInt32(Console.ReadLine());

       if (index1<=myArray.Length && index2<=myArray.Length)
       {
        Console.WriteLine("Сумма элементов:  {0}", myArray[index1] + myArray[index2]);
       }



//////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////


// Задача 38: Задайте массив вещественных(тип double) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int max;
int min;

double[] myArray = new double[] {3.1 , 7.9,  2.2,  2.1, 7.8};

Console.Write("Максимальный индекс:  ");
  max = Convert.ToInt32(Console.ReadLine());

Console.Write("Минимальный индекс:  ");
  min = Convert.ToInt32(Console.ReadLine());

       if (max<=myArray.Length && min<=myArray.Length)
       {
        Console.WriteLine("Сумма элементов:  {0}", myArray[max] - myArray[min]);
       }

