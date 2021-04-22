using System;
public class StringManipulation2 
{
   public static void Main() 
   {
        string word = "Hippoppotamus";

        Console.WriteLine("Word: "+ word);
      while (word.Length > 0) 
      {
         Console.Write(word[0] + " = ");

         int check = 0;
         for (int i = 0; i < word.Length; i++) {
            if (word[0] == word[i]) {
               check++;
            }
         }
         Console.WriteLine(check);
         word = word.Replace(word[0].ToString(), string.Empty);
      }
      
   }
}
