using System;
namespace Class2
{
   class program
   {
       static void Main(string[] args)
       {
           int man;
           int nin;
           int j;
           int i;
            Console.Write("Enter the Order of the Matrix : ");
            man = Convert.ToInt16(Console.ReadLine());
            nin = Convert.ToInt16(Console.ReadLine());
            int[,] Arr = new int[10, 10];


            Console.Write("\nEnter The Matrix Elements : ");
            for (i = 0; i < man; i++)
            {
                for (j = 0; j < nin; j++)
                {
                    Arr[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("\nMatrix A : ");
            for (i = 0; i < man; i++)
            {
                for (j = 0; j < nin; j++)
                {
                    Console.Write(Arr[i, j] + "\t");

                }
                Console.WriteLine();
            }
          
            
       }
   }
}

