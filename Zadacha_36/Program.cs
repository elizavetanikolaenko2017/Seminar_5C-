/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] GenerateArray(int size);
{ 
  int[]array = new int[4];
  Random rand = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i]= rand.Next(3,24);
  }
  return array;
}

void PrintArray(int[]array)
{
    Console.WriteLine("[" + string.Join(",", array) +" ]");
}

void SumOdd(int[]numbers);
{
     int result=0;
      
     for (int i = 1; i < numbers.Length; i++)
        {
           if (i%2!=0)
           {
            result+=numbers[i];
           }
          
          Console.WriteLine($"Сумма элементов массива,стоящих на нечетных позициях= {result}");
         }
        }
}

var myArray = GenerateArray(4);
PrintArray(myArray);
SumOdd(numbers);

