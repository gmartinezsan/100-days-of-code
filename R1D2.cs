using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
          /*
           --- Exercise 4 managing bi-dimensional arrays
          */

          // declare an array with lenghts for row and column
          int[,] my2dArray = new int[5, 5];
          //initialize 2D arrays with the new operator
          int[,] my2dArray_1 = new int[,] {{1,2,3},{ 1,2,3}};
          //initialize 2d without new operator
          int[,] second2DArray = {{1,2,3}, {1,2,3}};

          // get a value from an specific position          
          var valuefromarray = my2dArray_1[0, 2];

          Console.WriteLine("value from array " + valuefromarray);

          int[,] mymatrix = new int[2, 3] { { 1, 2, 3 }, { 1, 2, 3 } };

					// iterate over the array
          for (int i = 0; i <= mymatrix.GetUpperBound(0); i++)
          {
						for (int x = 0; x <= mymatrix.GetUpperBound(1); x++)
						{
							Console.WriteLine("Element at [" + i + ", " + x + "] " + mymatrix[i, x]);
						}							
          }

					//create an array based on two values given
					//Console.WriteLine("Enter two integers. Space delimited : ");
					//string s = Console.ReadLine();

					//int[,] myArray = new int[(int)s[0], (int)s[2]];
					//myArray[0, 0] = 2;
					//Console.WriteLine(myArray[0, 0]);

			// a new array with the contents of [1,2,3], [5,6,7]

			int[,] ex1 = { { 1, 2, 3 }, { 5, 6, 7 } };

			// replace the number 6 with the 99
			ex1[1, 1] = 99;

			// iterate over the array
			for (int i = 0; i <= ex1.GetUpperBound(0); i++)
			{
				for (int x = 0; x <= ex1.GetUpperBound(1); x++)
				{
					Console.WriteLine("Element at [" + i + ", " + x + "] " + ex1[i, x]);
				}
			}
			Console.WriteLine("-- Exercise --");
			// practice exercise
			// given a two dimensional array that represent a chessboard find the answer to the question
			// if rooks are safe and if that's the case you should return true or false other wise
			// The configuration of the board will be given as an input to your function
			// and it'll be represented as a two dimensional array. Zero means that there's nothing in that space, and one means that there's a rook there.
			// in this case a 4x4 chessboard, the array cannot be empty, but a smallest 1x1 is also a valid board
			// call this method rooks_are_safe
			//int [,] input = { {0, 1, 0, 1, 0}, { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0 } }; // T1 - should be False
			// int [,] input = { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 0, 1 }, { 0, 0, 0, 0 } }; // T2 - should be True
			//int[,] input = { { 1 }, { 0 } }; // T3 - should be True
			//int[,] input = { { 1, 0 } ,{ 1, 0} }; // T4 - should be False
			int[,] input = { { 0, 0, 0 }, { 1, 0, 1 }, { 0, 0, 0 } }; // T5 - should be False
			Console.WriteLine("Are the rooks safe? " + AreRooksSafe(input));
			Console.ReadKey();
        }


			public static bool AreRooksSafe(int[,] input)
			{
				for (int i = 0;	i < input.GetLength(0); i++)
				{
					for (int j = 0; j < input.GetLength(1); j++)
					{
						if (input[i, j] == 1)
						{
							for (int k = i + 1; k < input.GetLength(0); k++)
								{
									if (input[k, j] == 1)
										return false;
								}
								for (int l = j + 1; l < input.GetLength(1); l++)
								{
									if (input[i, l] == 1)
										return false;
								}
						}
					}
				}
				return true;
			}

    }
}
