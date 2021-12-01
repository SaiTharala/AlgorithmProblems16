using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblem
{
	class Bubblesort
	{
		public static void BubbleSortInArray(int[] arr)
		{
		int B = arr.Length;
		for (int i = 0; i < B - 1; i++)
		{
		for (int j = 0; j < B - 1; j++)
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
	public static void PrintArray(int[] arr)
	{
		Console.WriteLine("Using BubbleSort");
		int B = arr.Length;
		for (int i = 0; i < B; ++i)
		{
	    	Console.WriteLine(arr[i] + "");
		}
			Console.WriteLine("\n");
		}
	}
}

		