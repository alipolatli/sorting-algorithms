﻿var numbers = Enumerable.Range(1, 10).OrderBy(_=> Guid.NewGuid()).ToArray();
BubbleSort(numbers);
foreach (var item in numbers)
{
    System.Console.WriteLine(item);
    
}

static void BubbleSort(int[] arr)
{
  for (int i = 0; i < arr.Length - 1; i++)
  {
    for (int j = 0; j < arr.Length - i - 1; j++)
    {
      if (arr[j] > arr[j + 1])
      {
        int temp = arr[j];
        arr[j] = arr[j + 1];
        arr[j + 1] = temp;
      }
    }
  }
}
