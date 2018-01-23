using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] a = new int[] { 3, 5, 7, 9, 10, 90, 100, 130, 140, 160, 170};
			int? foundIndex = SearchInArray(a, 140);
			if (foundIndex != null)
				Console.WriteLine("Key value found at " + foundIndex);
			else
				Console.WriteLine("Key value not found");
			Console.ReadKey();
		}

		public static int? SearchInArray(int[] a, int key)
		{
			int left = 0;
			int right = a.Length - 1;
			return BinarySearch(a, left, right, key);			
		}

		private static int? BinarySearch(int[] a, int left, int right, int key)
		{
			if (right >= left)
			{
				int m = (left + right) / 2;
				if (a[m] == key)
					return m;
				if (a[m] > key)  //keep the left half
					return BinarySearch(a, left, m - 1, key);
				if (a[m] < key)  //keep the right half
					return BinarySearch(a, m + 1, right, key);
			}
			return null;
		}
	}
}
