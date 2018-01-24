using System;


namespace SpiralFashion
{
	class Program
	{
		static void Main(string[] args)
		{
			// spiral fashion
			//  1 2 3
			//  4 5 6
			//  7 8 9
			//Output: 1 2 3 6 9 8 7 4 5
			Console.WriteLine("Type the length of the matrix");
			int l = Int32.Parse(Console.ReadLine());			

			if (l == 0)
			{
				Console.WriteLine("The number of elements is zero");
				return;
			}

			int[,] myArray = new int[l, l];
			int endIndexRow = myArray.GetLength(0);
			int endIndexCol = myArray.GetLength(1);

			// this array will be used to mark each positon that has been printed.
			bool[,] passed = new bool[endIndexRow, endIndexCol];
		
			int x = 0;
			for (int i = 0; i < endIndexRow; i++)
			{
				for (int j = 0; j < endIndexCol; j++)
				{
					myArray[i, j] = ++x;
				}
			}
			
			int startIndexRow = 0;
			int startIndexCol = 0;
			int row = 0;
			int col = 0;
			int count = 0;
			
			Console.WriteLine("Starting to print the matrix in spiral order");

			while (count < myArray.GetLength(0) * myArray.GetLength(1))
			{
				startIndexRow = row;
				startIndexCol = col;

				//row left to rigth
				while (col < endIndexCol && row < myArray.GetLength(0))
				{
					if (!passed[row, col])
					{
						passed[row, col] = true;
						Console.Write(myArray[row, col] + " ");
						count++;
					}
					else
						break;
					col++;
				}				
				row++;
				col--;

				//col top to bottom
				while (row < endIndexRow && col < myArray.GetLength(1))
				{
					if (!passed[row, col])
					{
						passed[row, col] = true;
						Console.Write(myArray[row, col] + " ");
						count++;
					}
					else
						break;
					row++;
				}
				row--;
				col--;

				//row right to left
				while (col >= startIndexCol && row < myArray.GetLength(0))
				{
					if (!passed[row, col])
					{
						passed[row, col] = true;
						Console.Write(myArray[row, col] + " ");
						count++;
					}
					else
						break;
					col--;
				}				
				row--;
				col = startIndexCol;

				//col bottom to top
				while (row > startIndexRow && col < myArray.GetLength(1))
				{
					if (!passed[row, col])
					{
						passed[row, col] = true;
						Console.Write(myArray[row, col] + " ");
						count++;
					}
					else
						break;
					row--;
				}
				col++;
				row++;
			}
			Console.WriteLine("");
			Console.WriteLine("End printing " + count + " elements.");
			Console.ReadKey();
			return;
		}
	}
}
