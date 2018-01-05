using System;
using System.Collections.Generic;


namespace HashTables
{
	class Program
	{
		static void Main(string[] args)
		{
			// declare and initialize a Dictionary in the same instruccion
			Dictionary<String, int> a_dic1 = new Dictionary<string, int>()
			{
				{"Amy", 28 },
				{"Tom", 0 }
			};

			// just declare 
			Dictionary<String, int> a_dict = new Dictionary<string, int>();
			a_dict.Add("Amy", 28);
			foreach (var item in a_dict)
			{
				Console.WriteLine("Key " + item.Key + ", " + item.Value);
			}

			//lookup for a key
			if (a_dic1.TryGetValue("Tom", out int age))
			{
				Console.WriteLine("Tom value " + age);
				Console.WriteLine("Value from Tom " + a_dic1["Tom"]);
			}

			// Write a method that finds the first pair of numbers that adds up to 10
			// Test 1 
			//int[] values = new[]{ 3, 4, 1, 2, 9 };

			// Test 2
			//int[] values = new[] { -11, -20, 2, 4, 30 };

			// Test 3
			//int[] values = new[] { 1, 2, 9, 8 };

			// Test 4
			//int[] values = new[] { 1, 1, 1, 2, 3, 9 };

			// Test 5
			int[] values = new[] { 1, 1, 1, 2, 3, 4, 5 };
			FindFirstPairOfNumbers(values);

			// Test 6
			int[] values_2 = new[] { 3, 4, 1, 7, 9, 9 };  // should print 3 + 7 / 1 + 9
			PrintAllPairOfNumbers(values_2);

			Console.ReadKey();
		}

		public static void FindFirstPairOfNumbers(int[] values)
		{
			if (values.Length > 0)
			{
				Dictionary<int, int> pairs = new Dictionary<int, int>();
				for (int i = 0; i < values.Length; i++)
				{
					if (!pairs.ContainsKey(values[i]))
					{
						if (pairs.ContainsKey(10 - values[i]))
						{
							Console.WriteLine("The first pair that adds up to 10 in the array is {0} + {1}", values[i], (10 - values[i]));
							return;
						}
						else
						{
							pairs.Add(values[i], 10 - values[i]);
						}						
					}					
				}
				Console.WriteLine("No pair of numbers that adds up to 10 was found.");
			}		
		}

		public static void PrintAllPairOfNumbers(int[] values)
		{
			int count = 0;
			if (values.Length > 0)
			{
				Dictionary<int, int> pairs = new Dictionary<int, int>();
				for (int i = 0; i < values.Length; i++)
				{
					if (!pairs.ContainsKey(values[i]))
					{ 
						if (pairs.ContainsKey(10 - values[i]))
						{
							Console.WriteLine("A pair that adds up to 10 in the array is {0} + {1}", values[i], (10 - values[i]));
							count++;
						}										
						pairs.Add(values[i], 10 - values[i]);
					}
				}
				if (count == 0)
					Console.WriteLine("No pair of numbers that adds up to 10 was found.");
			}
		}


	}
}
