using System;
using System.Text;

namespace TemeString2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
            1.Middle Characther
            You are going to be given a word.Your job is to return the middle character of the word.If the word's length is odd, return the middle character. 
            If the word's length is even, return the middle 2 characters.
            #Examples:
            "test" should return "es"
            "testing" should return "t"
            "middle" should return "dd"
            "A" should return "A" #Input
            A word (string) of length 0 < str < 1000. #Output
            The middle character(s) of the word represented as a string.
            PS: Should work for words of 999 characters
            */

            Console.WriteLine("Te rog sa introduci cuvantul");
            var middle = Convert.ToString(Console.ReadLine());
            int length = middle.Replace(" ", "").Length;
            if (middle.Length <= 999)
            {
                
                if (length % 2 == 0)
                {
                    Console.Write("Cuvantul introdus este par {0} iar mijlocul lui este: {1}{2}", middle, middle.Replace(" ", "")[length / 2 - 1], middle.Replace(" ", "")[length / 2]);
                }
                else
                {
                    Console.Write("Cuvantul introdus este impar iar mijlocul lui este: {1} ", middle, middle.Replace(" ", "")[length / 2]);
                }
            }



            /*
           2.The goal of this kata is to write a function that takes two inputs: a string and a character. The function will count the number of times that character appears in the string.The count is case insensitive.
             For example:
             countChar("fizzbuzz", "z") => 4 countChar("Fancy fifth fly aloof", "f") => 5 The character can be any alphanumeric character.
            */
            

        }

    }
}
