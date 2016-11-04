using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
// Create an empty array to hold integer values 0 through 9
// Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
// Create an array with space 10 that alternates between true and false values, starting with true
        public static void Main(string[] args)
        {
            int[] numArray = {0,1,2,3,4,5,6,7,8,9};
            Console.WriteLine(numArray[1]);

            string[] nameArray = {"Tim", "Martin", "Nikki",  "Sara"};
            Console.WriteLine(nameArray[1]);

            Console.WriteLine("******************************************");

            bool[] boolArray = new bool[10];

            for (int i = 0; i < boolArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    boolArray[i] = true;
                }
                else
                {
                    boolArray[i] = false;
                }
                Console.WriteLine(boolArray[i]);
            }

            Console.WriteLine("******************************************");

            int [,] array2D = new int[10,10];

            for(int i = 0; i < 10; i++) 
            {
                for(int j = 0; j < 10; j++)
                {
                    array2D[i,j] = (i*j);
                }
            }
            Console.WriteLine(array2D[7,5]);

            Console.WriteLine("******************************************");

// Create a Dictionary for storing Name, Favorite Sport, Num of Pets, and True/False for whether or not a user like Ice Cream.
// Create 4 different dictionaries holding information for the 4 people in the array you created earlier (Tim, Martin, Nikki, Sara).
// Create a list of dictionaries and add each user dictionary to it.
// Loop through the list and print out each field of user info.

            Dictionary <string,string> jacob = new Dictionary<string,string>();
            jacob.Add("Name", "Jacob");
            jacob.Add("Sport", "Football");
            jacob.Add("Pets", "3");
            jacob.Add("Ice Cream", "true");
            Console.WriteLine(jacob["Name"]);
            Console.WriteLine(jacob["Sport"]);
            Console.WriteLine(jacob["Pets"]);
            Console.WriteLine(jacob["Ice Cream"]);
            
            
            
        }
    }
}
