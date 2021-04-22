using System;

namespace method2
{
    public static class dice
    
    {
        public static void MyMethod()
        {

           Random random = new Random();

            int total = 0;

            

            int toss1 = random.Next(1, 7);
            int toss2 = random.Next(1, 7);
            // int toss3 = random.Next(1, 7);

            total = toss1 + toss2;

            string finalMessage = string.Empty;

            if ((toss1 == toss2))
            {

                if ((toss1 == toss2))
                {
                    // total += 6;
                    Console.WriteLine($"Triple +6 bonus point ");
                    finalMessage = $"toss : {toss1} + {toss2} +6 = {total + 6}";
                    Console.WriteLine(finalMessage);
                }
                else
                {
                    // total += 2;
                    Console.WriteLine($"double +2 bonus point ");
                    finalMessage = $"toss : {toss1} + {toss2} +2 = {total + 2}";
                    Console.WriteLine(finalMessage);
                }
            }
            else
            {
                finalMessage = $"toss : {toss1} + {toss2} = {total}";

                Console.WriteLine(finalMessage);
            }

            Console.WriteLine($"you scores {total}");

                // String finalMessage = (total >= 15 ? "Congratulations, You won" : "Sorry, You lose. Try Again");
                // {
                //     Console.WriteLine(finalMessage);
                // }
            if (total >= 15)
            {
                Console.WriteLine("You won a ");
            }
            else if (total >= 10 && total <= 12)
            {
                Console.WriteLine("you won a ");
            }
            // else if (total == 7)
            // {
            //     Console.WriteLine(" You won a mobile phone");
            // }
            else
            {
                Console.WriteLine("You won a pen!!!");
            }
        }
    }
}
    