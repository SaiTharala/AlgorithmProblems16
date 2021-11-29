using System;

namespace AlgorithmProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the values to Execute the Program Press\n1.Bubble sort\n2.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        int[] arr1 = { 55, 7, 87, 2, 3, 55, 5 };
                        Bubblesort.BubbleSortInArray(arr1);
                        Bubblesort.PrintArray(arr1);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}