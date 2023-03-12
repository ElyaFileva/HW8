Console.Clear();
Console.WriteLine("Введите кол-во строк для первой матрицы:");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов для первой матрицы/строк второй матрицы:");
int columns1Rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов для второй матрицы:");
int columns2 = Convert.ToInt32(Console.ReadLine());

int[,] array1 = FillArray(rows1, columns1Rows2, 1, 4);
int[,] array2 = FillArray(columns1Rows2, columns2, 1, 4);
int[,] resultArray = MultArrays(array1, array2);

PrintArray(array1);
Console.WriteLine("_______________");
PrintArray(array2);
Console.WriteLine("_______________");
Console.WriteLine("Результат произведения двух матриц:");
PrintArray(resultArray);

int[,] FillArray(int m, int n, int min, int max)
{
  int[,] result = new int[m, n];
  Random rnd = new Random();
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      result[i, j] = rnd.Next(min, max);
    }
  }
  return result;
}
void PrintArray(int[,] inputArray)
{
  for (int i = 0; i < inputArray.GetLength(0); i++)
  {
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
      Console.Write(inputArray[i, j] + " ");
    }
    Console.WriteLine("");
  }
}
int[,] MultArrays(int[,] arr1, int[,] arr2)
{
  int[,] resultArr = new int[arr1.GetLength(0), arr2.GetLength(1)];
  int sum = 0;
  for (int i = 0; i < arr1.GetLength(0); i++)
  {
    for (int j = 0; j < arr2.GetLength(1); j++)
    {
      for (int k = 0; k < arr1.GetLength(1); k++)
      {
        sum += arr1[i, k] * arr2[k, j];
      }
      resultArr[i, j] = sum;
      sum = 0;
    }
  }
  return resultArr;
}