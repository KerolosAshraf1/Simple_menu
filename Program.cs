using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {

            float avarage = 0;
            int sum = 0;
            Console.WriteLine("Enter number of the students C# Subject");
            int Snum = Convert.ToInt32(Console.ReadLine());
            string[] names = new string[Snum];
            int[] grades = new int[Snum];
            Console.WriteLine("Enter the students names");
            for (int i = 0; i < Snum; i++)
            {
                names[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter the students grades");
            for (int i = 0; i < Snum; i++)
            {
                grades[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();

        start:
            Console.WriteLine("1:Display the name , grade of each student");
            Console.WriteLine("2:calculate the maximum mark");
            Console.WriteLine("3:calculate the minimum mark");
            Console.WriteLine("4:calculate the summation of all marks");
            Console.WriteLine("5:calculate the average of all marks");
            Console.WriteLine("6:Exit");
            int option = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (option)
            {
                case 1:
                    for (int i = 0; i < Snum; i++)
                    {
                        Console.WriteLine(names[i]);
                        Console.WriteLine(grades[i]);
                    }
                    break;
                case 2:
                    int max = grades[0];
                    for (int i = 0; i < Snum; i++)
                    {
                        if (max <= grades[i])
                        {
                            max = grades[i];
                        }
                    }
                    Console.WriteLine(max);
                    break;
                case 3:
                    int min = grades[0];
                    for (int i = 0; i < Snum; i++)
                    {
                        if (min >= grades[i])
                        {
                            min = grades[i];
                        }
                    }
                    Console.WriteLine(min);
                    break;
                case 4:
                    sum = 0;
                    for (int i = 0; i < Snum; i++)
                    {
                        sum += grades[i];
                    }
                    Console.WriteLine(sum);
                    break;
                case 5:
                    avarage = sum / Snum;
                    Console.WriteLine(avarage);
                    break;
                case 6:
                    break;
            }
            Console.WriteLine(" Does he/she want to perform another operation or not(y/n)");
            string choice = Console.ReadLine();
            if (choice == "y")
            {
                goto start;
            }
            else
            {
                Console.WriteLine("thanks");
            }
        }

    }
}
