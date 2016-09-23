using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollerCoasterHomework
{
    class Program
    {
        static void Main(string[] args)
        {

            string line = Console.ReadLine(); //"To be, or not to be: that is the question.";

            ////using an array of characters
            //int index = 0; //counts through the indexes of each letter
            //char[] array = line.ToCharArray(); //turns the string into an array of characters

            //for (int i = 0; i < array.Length; i++) //loops through array of characters
            //{

            //    char ch = array[i]; //sets character at index i to ch

            //    if (char.IsLetter(ch)) //only looks at letters
            //    {
            //        if (index % 2 == 0) //if the index is even
            //        {
            //            array[i] = char.ToUpper(ch); //changes character to uppercase
            //        }
            //        else
            //        {
            //            array[i] = char.ToLower(ch); //changes character to lower case
            //        }
            //        index++; //adds one to the index to repeat loop
            //    }
            //    else
            //    {

            //    }
            //}

            //string result = new string(array); //takes array of characters and put back in a string
            //Console.WriteLine(result);


            int index = 0; //index to count though letters
            StringBuilder result = new StringBuilder(); //builds new string


            for (int i = 0; i < line.Length; i++) //loops though given string
            {

                if (char.IsLetter(line[i])) //if the character in the string is a letter
                {

                    if (index % 2 == 0) //if the index is even
                    {
                        result.Append(line[i].ToString().ToUpper()); //changes character to uppercase
                    }
                    else
                    {
                        result.Append(line[i].ToString().ToLower()); //changes character to lowercase
                    }
                    index++; //adds one to index to continue loop

                }
                else //adds space or character as is
                {
                    result.Append(line[i]);
                }
            }

            Console.WriteLine(result); //prints out results of built string


        }
     }
}
