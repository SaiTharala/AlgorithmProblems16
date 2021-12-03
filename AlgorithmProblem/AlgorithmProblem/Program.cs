using System;

namespace AlgorithmProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structures And Alogorithm Programs...");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n Choose an Option :\n 1.Anagram\n 2.Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {             
                    case 1:
                        Anagram check = new Anagram();
                        check.AnagramCheck();
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}