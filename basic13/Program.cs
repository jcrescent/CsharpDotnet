using System;
using static System.Console;

namespace ConsoleApplication
{
    public class Program
    {
        public static void oneTo255()
        {
            for(int i = 0; i < 256; i++)
            {
                WriteLine(i);
            }
        }
        public static void sumTo255()
        {
            int sum = 0;
            for(int i = 0; i < 256; i++)
            {
                sum += i;
                WriteLine(i);
                WriteLine(sum);
            }
        }
        public static void iterateAnArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                WriteLine(array[i]);
            }
        }

        public static void findMax(int[] array)
        {
            int max = array[0];
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] > max)
                {
                    max = array[i];
                }
            }
            WriteLine(max);
        }

        public static void findMin(int[] array)
        {
            int min = array[0];
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] < min)
                {
                    min = array[i];
                }
            }
            WriteLine(min);
        }

        public static void average(int[] array)
        {
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            WriteLine(sum/array.Length);
        }

        public static void odds(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 == 1)
                {
                    WriteLine(array[i]);
                }
            }
        }

        public static void greaterThanY(int[] array, int y)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] > y)
                {
                    WriteLine(array[i]);
                }
            }
        } 

        public static void squares(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                WriteLine(array[i]*array[i]);
            }
        }

        public static void negsToZero(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] < 0)
                {
                    array[i] = 0;
                    
                }
                WriteLine(array[i]);
            }
        }

        public static void Main(string[] args)
        {
            int[] array = {1,2,3,-45,6,7,8,9,10,11, -100}; 
            int y = 10;
            oneTo255();
            WriteLine("********************");
            sumTo255();
            WriteLine("********************");      
            iterateAnArray(array);
            WriteLine("********************");
            findMax(array);
            WriteLine("********************");
            findMin(array);
            WriteLine("********************");
            average(array);
            WriteLine("********************");
            odds(array);
            WriteLine("********************");
            greaterThanY(array, y);
            WriteLine("********************");
            squares(array);
            WriteLine("********************");
            negsToZero(array);
            WriteLine("********************");

            

        }
    }
}
