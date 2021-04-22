    using System;  
    namespace palindrome  
    {  
        class Program  
        {  
            static void Main(string[] args)  
            {  
            string word;
            string reverse="";

            Console.Write("Enter any word: ");  
             word = Console.ReadLine();  

                for (int i = word.Length-1; i >=0; i--) 
                {  
                    reverse += word[i].ToString();  
                }  
                if (reverse == word)  
                {  
                    Console.WriteLine("The Word is a Palindrome \nThe word you Entered  Was {0}..... And reverse of the word is {1}", word, reverse);  
                }  
                else  
                {  
                    Console.WriteLine("The Word is not a Palindrome \nThe word you Entered  Was {0}....... and reverse of the word is {1}", word, reverse);  
                }  
                
            }  
        }  
    }