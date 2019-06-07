using System;
using System.Text;

namespace TemeString2
{
    class Program
    {
        static void Main(string[] args)
        {
            middleChar();
            countChar();
            Like();
            Console.WriteLine(Ho());
            Console.WriteLine(Ho(Ho()));
            Console.WriteLine(Ho(Ho(Ho())));

        }
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

        static void middleChar()
        {
            Console.WriteLine("Te rog sa introduci cuvantul");
            var middle = Convert.ToString(Console.ReadLine());
            int length = middle.Replace(" ", " ").Length;
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
        }


        /*
       2.The goal of this kata is to write a function that takes two inputs: a string and a character. The function will count the number of times that character appears in the string.The count is case insensitive.
         For example:
         countChar("fizzbuzz", "z") => 4 countChar("Fancy fifth fly aloof", "f") => 5 The character can be any alphanumeric character.
        */

        static void countChar()
        {
            Console.WriteLine("Te rog sa introduci propozitia");
            string s = Console.ReadLine();
            int count = 0;
            foreach (char item in s)
            {
                if (item == 'b')
                {
                    count++;
                }
            }
            Console.WriteLine("Numarul de aparitii ale caracterului b este {0} ", count);
        }

        /*
        3.You probably know the "like" system from Facebook and other pages. 
          People can "like" blog posts, pictures or other items.We want to create the text that should be displayed next to such an item.
          Implement a function likes :: [String]->String, which must take in input array, containing the names of people who like an item. 
          It must return the display text as shown in the examples:


          likes[]  must be "no one likes this" 
          likes ["Peter"]  must be "Peter likes this" 
          likes ["Jacob", "Alex"] must be "Jacob and Alex like this" 
          likes ["Max", "John", "Mark"] must be "Max, John and Mark like this" 
          likes ["Alex", "Jacob", "Mark", "Max"] must be "Alex, Jacob and 2 others like this"
          */

        static string Like()
        {

            string[] name = { " ", "Peter", "Jacob Alex", "Max John Mark", "Alex Jacob Mark Max" };

            if (name.Length == 0)
                return "No one likes this";
            if (name.Length == 1)
                return name[0] + " likes this.";
            if (name.Length == 2)
                return name[0] + " and " + name[1] + " like this.";
            if (name.Length == 3)
                return name[0] + "," + name[1] + " and " + name[2] + " like this.";
            return name[0] + ", " + name[1] + " and " + (name.Length - 2).ToString() + " others like this.";

        }

        /*
        4. Santa is learning programming. And what could be the first program, he wants to write? Yes, the "Hello world!" of Christmas: 
        "Ho Ho Ho!".He wants to write a function ho(), which should have the following return values:
         ho() should return "Ho!" 
         ho(ho()) should return "Ho Ho!" 
         ho(ho(ho())) should return "Ho Ho Ho!" 
         Unfortunately he couldn't find any tutorial, which explains, how he could implement that. Can you help him?
         Rules: each call of ho() must add a "Ho" to the string the "Ho"'s must be separated by a space at the end of the string, there must be an exclamation mark (!), without a space
         */
        static string Ho()
        {
            return "Ho!";
        }
        static string Ho(string santa)
        {
            return "Ho " + santa.ToLower();
        }
    }

}





