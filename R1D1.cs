using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
 --- Exercise 1   
        var myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        myArray[0] = 100;
                        int i = 0;
                        foreach (var item in myArray)
                        {
                            Console.WriteLine("Item [ " + item + " ] at Index " + i);
                            i++;
                        }

                        var myArray2 = new string[5] { "a", "b", "b", "d", "e" };
                        i = 0;
                        foreach (var item in myArray2)
                        {
                            Console.WriteLine("Item [ " + item + " ] at Index " + i);
                            i++;
                        }

                        try
                        {
                            myArray2.Single(t => t.Equals("b"));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Exception " + ex.Message);                
                        }
   

            int[] elements = new int[]{ 1, 3, 4, 5, 0, 2 }; result is 4
            //int[] elements = new int[] { 2, 2, 1 };            

            if (elements.Length == 0)
                Console.WriteLine("The array has no elements");
            if (elements.Length == 1)
                Console.WriteLine("The array has only one element");
            else
            {
                Console.WriteLine("The second biggest number in the array is " + SecondLargest(elements));
            } */
            /*    
    
 --- Exercise 2   
 

            string mystring = "somewords";
            Console.WriteLine("second character in the string " + mystring[1]);

            int i = 0;
            foreach (char item in mystring)
            {
                Console.WriteLine("char number " + i + " " + item);
                i++;
            }

            Console.WriteLine("For char print ");

            for (int x = 0; x < mystring.Length; x++)
            {
                Console.WriteLine(x + "-" + mystring[x]);
            }

            Console.WriteLine("These two words are reverse? ABC and CBA " + AreReverse("CBA", "AAA"));
*/
 /*
 --- Exercise 3             
 */
            Console.Write("fisrt number is ?");
            string a = Console.ReadLine();
            Console.Write("second number is ?");
            string b = Console.ReadLine();
            Console.WriteLine("Is first number greater than second number ? " + IsGreaterThan(a, b));
            Console.Read();
         }



     // in a given array get the second larger element in the array    
     public static int SecondLargest(int[] elements)
     {        
         var biggestnumber = elements[0];
         var nextbigger = 0;
         foreach (var item in elements)
         {
                 if (item >= biggestnumber)
                 {
                     nextbigger = biggestnumber;
                     biggestnumber = item;                    
                 }
         }
         return nextbigger;
     }


    //Write a function that takes two strings and returns True if they are reverses of each other. Assume that the two strings are not empty and have the same length
    public static bool AreReverse(string strOne, string strTwo)
    {            
        for (int i = 0; i < strOne.Length; i++)
        {
            if (strOne[i] != strTwo[(strOne.Length - i) -1])
            {
                return false;
            }
        }
        return true;
    }

 //Write a function that takes two strings which are only numbers and returns true if the first argument is greater than the second one.
 //Assume non-negative and non-empty parameters. Do not use int class to convert the strings
//Questions:
//Is there any zero at the begining of the arguments? No, assume there is no zero at the begining.
        public static bool IsGreaterThan(string arg1, string arg2)
        {
            if (arg1.Length > arg2.Length)
                return true;

            if (arg1.Length < arg2.Length)
                return false;

            for (int i = 0; i < arg1.Length; i++)
            {
                if (arg1[i] > arg2[i])
                {
                    return true;
                }
                if (arg1[i] < arg2[i])
                {
                    return false;
                }
            }
            return false;
        }
    }
}
