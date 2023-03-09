/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

 static double[]NumberArray(int size);
{
 double[]array= new double[size];
 double size = Convert.ToInt64(Console.ReadLine());
  for (int i = 0; i < array.Length; i++)
  {
    array[i]=Convert.ToDouble(new Random()).Next(3,79);  
  }
 
}
return array;

   static void Main(string[]args)
  {
   var myArray = NumberArray(5);
   PrintArray(myArray);
   MaxAndMinNumbers(myNumber);
  }

 static void PrintArray(double[]array);
  {
   Console.WriteLine("[" + string.Join(",", array) +" ]");
  }

  static void MaxAndMinNumbers(double[]array);
  {
    double maxNumber=0;
    double minNumber=0;

    for (int i = 0; i < number.Length; i++)
     {
     if (Array[i]> max) max=numbers[i];
     if(Array[i]< min) min=numbers[i];
     }
    Console.WriteLine($"Разница между максимальным и минимальным элементами в массиве: {maxN - minN}");

   }

   static void Main(string[]args)
  {
   var myArray = NumberArray(5);
   PrintArray(myArray);
   MaxAndMinNumbers(myNumber);
  }


