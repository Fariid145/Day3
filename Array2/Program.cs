using System;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 30;
            int[] students = new int[number];
            number = 60;
            Console.WriteLine("number is: " + number);
            Console.WriteLine("The number of student is: " + students.Length);

            // number is 60;
            // The number of students is 30;
        }
    }
}
