/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int[] GenerateArray(int size);
{ 
  int[]array = new int[4];
  Random rand = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i]= rand.Next(3,24);
  }
  return;
}

void PrintArray(int[]array)
{
    Console.WriteLine("[" + string.Join(",", array) +" ]");
}

void SumOddAndEvennumber(int[]array, out int SumOddnumber, out int SumEvennumber);
{
  sumOddnumber =0;
  sumEvennumber=0;

  for (int i = 0; i < number.Length; i++)
  {
    if (i%2==0)
    {
        sumEvennumber+=number[i];
    }
    else
     {
        SumOddAndEvennumber+=array[i];
     }
   }
}

var myArray = GenerateArray(4);
PrintArray(myArray);
SumOddAndEvennumber(myArray, out int SumEvennumber, out int SumOddnumber);

System.Console.WriteLine($"Сумма нечётных чисел в заданном массиве: {sumOddnumber}");




