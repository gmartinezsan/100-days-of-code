		
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
 			// Exercise find the a number which neighborgs are both smaller than the number at the middle.
			Console.WriteLine("Write the numbers of the array separated by a space");
			String input = Console.ReadLine();

			var asIntegers = input.Split(' ').Select(s => int.Parse(s)).ToArray();

    
			int found = FindPeak(asIntegers, 0, asIntegers.Length);
			Console.WriteLine("Peak found {0}, value {1}", (found != -1 ? "Yes" : "No"), asIntegers[found]);
			Console.Read();
     }  
  
    public static int FindPeak(int[] elements, int i, int j)
		{
			int m = (i + j) / 2;

			// look at the left
			if (elements[m - 1] <= elements[m] && elements[m] >= elements[m + 1])
			{
				return m;
			}
			else if (elements[m - 1] > elements[m])
			{
				return FindPeak(elements, i, m - 1);
			}
			else if (elements[m + 1] > elements[m])
				return FindPeak(elements, m + 1, j);

			return -1;
		}
  }
}
