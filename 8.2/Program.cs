Console.Clear();
Console.WriteLine("Введите кол-во строк в двумерном массиве");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов в двумерном массиве");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, columns, 1, 10);
PrintArray(array);
int[] arr = GetSumRowsArray(array);

Console.WriteLine($"Номер строки с наименьшей суммой элементов: {GetindexMinElemArray(arr)}");
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
int[] GetSumRowsArray(int[,] array)
{
  int[] arr = new int[array.GetLength(0)];

  for (int i = 0; i < array.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sum += array[i, j];
    }
    arr[i] = sum;
  }
  Console.WriteLine($"Среди сумм строк: {string.Join(" ", arr)}");
  return arr;
}

int GetindexMinElemArray(int[] arr)
{
  int min = arr[0];
  int iMin = 1;
  for (int i = 1; i < arr.Length; i++)
  {
    if (arr[i] < min)
    {
      min = arr[i];
      iMin = i + 1;
    }
  }
  return iMin;
}