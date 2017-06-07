using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 11;
            int y = 10;
			int zap = 0;
			
			int a = 10;
            int b = 10;
			int apples = 0;

			int[] arr_x = new int[100];
			int[] arr_y = new int[100];

			while (true)
			{
				arr_x[0] = x;	
				arr_y[0] = y;
				
				Random random = new Random();

				snake(a, b, '0');

				for (int i = 0; i <= apples; i++) {
					snake(arr_x[i], arr_y[i], 'x');
				}

				ConsoleKeyInfo k = Console.ReadKey();

                if (k.Key == ConsoleKey.RightArrow)
                {
					for (int i = 0; i <= apples; i++)
					{
						zap = arr_x[i];
						arr_x[i] = arr_x[i + 1];
						arr_x[i + 1] = zap;
						
					}
					for (int i = 0; i <= apples; i++)
					{
						
						zap = arr_y[i];
						arr_y[i] = arr_y[i + 1];
						arr_y[i + 1] = zap;
					}

					x += 1;
					
				}

                if (k.Key == ConsoleKey.LeftArrow)
                {
					for (int i = 0; i <= apples; i++)
					{

						zap = arr_x[i];
						arr_x[i] = arr_x[i + 1];
						arr_x[i + 1] = zap;
					}
					for (int i = 0; i <= apples; i++)
					{
						zap = arr_y[i];
						arr_y[i] = arr_y[i + 1];
						arr_y[i + 1] = zap;

					}

					x -= 1;
				}

                if (k.Key == ConsoleKey.UpArrow)
                {
					for (int i = 0; i <= apples; i++)
					{

						zap = arr_x[i];
						arr_x[i] = arr_x[i + 1];
						arr_x[i + 1] = zap;
					}
					for (int i = 0; i <= apples; i++)
					{

						zap = arr_y[i];
						arr_y[i] = arr_y[i + 1];
						arr_y[i + 1] = zap;
					}

					y -= 1;
				}

                if (k.Key == ConsoleKey.DownArrow)
                {
					for (int i = 0; i <= apples; i++)
					{

						zap = arr_x[i];
						arr_x[i] = arr_x[i + 1];
						arr_x[i + 1] = zap;
					}
					for (int i = 0; i <= apples; i++)
					{

						zap = arr_y[i];
						arr_y[i] = arr_y[i + 1];
						arr_y[i + 1] = zap;
					}

					y += 1;
				}
                if (x == a && y == b)
                {
					apples++;
                    a = random.Next(20);
                    b = random.Next(20);
				}
				Console.Clear();
            }
        }

		static void snake(int x, int y, char tail)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(tail);
		}
	}
}
