void Zadacha54()
{
   //Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
   Console.WriteLine("введите количество строк");
   int linesVol = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("введите количество столбцов");
   int columnsVol = Convert.ToInt32(Console.ReadLine());
   int[,] numbers = new int[linesVol, columnsVol];
   FillArrayRandomNumbers(numbers);
   Console.WriteLine();
   Console.WriteLine("Наш массив до изменения");
   PrintArray(numbers);

   for (int i = 0; i < numbers.GetLength(0); i++)
     {
       for (int j = 0; j < numbers.GetLength(1) - 1; j++)
         {
            for (int z = 0; z < numbers.GetLength(1) - 1; z++)
              {
               if (numbers[i, z] < numbers[i, z + 1]) 
                {
                int temp = 0;
                temp = numbers[i, z];
                numbers[i, z] = numbers[i, z + 1];
                numbers[i, z + 1] = temp;
                }
              }     
         }    
     }
   Console.WriteLine();
   Console.WriteLine("Массив с упорядоченными значениями");
   PrintArray(numbers);

   void FillArrayRandomNumbers(int[,] array)
    {
       for (int i = 0; i < array.GetLength(0); i++)
        {
          for (int j = 0; j < array.GetLength(1); j++)
           {
            array[i, j] = new Random().Next(0, 10);
           }
        }
    }

   void PrintArray(int[,] array)
    {
       for (int i = 0; i < array.GetLength(0); i++)
        {
          Console.Write("[ ");
           for (int j = 0; j < array.GetLength(1); j++)
            {
              Console.Write(array[i, j] + " ");
            }
           Console.Write("]");
           Console.WriteLine("");
        }
    }
Zadacha54();
}
void Zadacha56()
{
  //Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
  Console.WriteLine("введите размер квадратного массива");
  int massVol = Convert.ToInt32(Console.ReadLine());
  int[,] numbers = new int[massVol, massVol];
  FillArrayRandomNumbers(numbers);
  PrintArray(numbers);
  int minsum = Int32.MaxValue;
  int indexLine = 0;

  for (int i = 0; i < numbers.GetLength(0); i++)
     {
       int sum = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
         {
          sum = sum + numbers[i, j];        
         }
         if (sum < minsum)
         {
          minsum = sum;
          indexLine++;
         }
     }

  Console.WriteLine("строка с наименьшей суммой элементов под номером: " + (indexLine) + ", с суммой элементов равной: " + (minsum));

  void FillArrayRandomNumbers(int[,] array)
    {
      for (int i = 0; i < array.GetLength(0); i++)
       {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
       }
    }

  void PrintArray(int[,] array)
  {
    for (int i = 0; i < array.GetLength(0); i++)
      {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
          {
             Console.Write(array[i, j] + " ");
          }
        Console.Write("]");
        Console.WriteLine("");
      }
  }
  Zadacha56();
}
void Zafacha58()
{
  //Задача 58. Заполните спирально массив 4 на 4 числами от 1 до 16.
  int InputInt(string output)
   {
      Console.Write(output);
      return int.Parse(Console.ReadLine());
   }

  void FillArrayRandomNumbers(int[,] array)
   {
    for (int i = 0; i < array.GetLength(0); i++)
      {
        for (int j = 0; j < array.GetLength(1); j++)
         {
            array[i, j] = new Random().Next(1, 5); 
      }
   }

  void PrintArray(int[,] array)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
  }

  int size = InputInt("размерность матриц: ");
  int[,] matrixA = new int[size, size];
  int[,] matrixB = new int[size, size];
  FillArrayRandomNumbers(matrixA);
  FillArrayRandomNumbers(matrixB);
  int[,] matrixC = new int[size, size];

  for (int i = 0; i < size; i++)
   {
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
   }
  Console.WriteLine("Матрица - А");
  PrintArray(matrixA);
  Console.WriteLine();
  Console.WriteLine("Матрица - В");
  PrintArray(matrixB);
  Console.WriteLine();
  Console.WriteLine("Произведение матриц А*В");
  PrintArray(matrixC);
   } 
  Zafacha58();
} 

