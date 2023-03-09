/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

static int[] GenerateArray(int size)
{
    int []array= new int [size];
    Random rand = new Random();


   for (int i = 0; i < array.Length; i++)
    {
      array[i] = rand.Next(234,899);  
    }
    return array;
}

static void PrintArray(int[]array);
{
  Console.WriteLine("[" + string.Join(",", array) +" ]");
}

static void CoolArray(int[]array);
{ 
    int result=0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i]%2==0)
       {
        result++;
       }
       System.Console.WriteLine($"Количество чётных чисел в массиве: {result}");
    }
}
  
  static void Main(string[]args);
  {
     int[]array = GenerateArray(array);
     PrintArray(array);
     CoolArray(array);
     PrintArray(array);
  }




