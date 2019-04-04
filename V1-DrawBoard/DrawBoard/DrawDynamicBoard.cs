using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawBoard
{
    class DrawDynamicBoard
    {
        private static bool isNotValid(int rows, int columns)
        {
            return rows < 2 || rows > 30 || columns < 2 || columns > 30;
        }

        public static void DrawBoard1(int rows, int columns)
        {
            if(isNotValid(rows,columns))
            {
                Console.WriteLine("Please enter numbers between 2 and 30");
            }
            else
            {
                for (int i = 0; i < rows; i++)
                {
                    string row1 = "";
                    string row2 = "";

                    for (int j = 0; j < columns; j++)
                    {
                        row1 = row1 + " | ";
                        row2 = row2 + "-+-";
                    }
                    Console.WriteLine(row1);
                    Console.WriteLine(row2);
                }
                Console.WriteLine();            
            }
        }

        public static void DrawBoard2(int rows, int columns)
        {
            if (isNotValid(rows, columns))
            {
                Console.WriteLine("Please enter numbers between 2 and 30");
            }
            else
            {
                for (int i = 0; i < rows; i++)
                {
                    string row1 = "";
                    string row2 = "";
                    string row3 = "";

                    for (int j = 0; j < columns; j++)
                    {
                        row1 = row1 + " - ";
                        row2 = row2 + "| |";
                        row3 = row3 + " - ";
                    }
                    Console.WriteLine(row1);
                    Console.WriteLine(row2);
                    Console.WriteLine(row3);
                }
                Console.WriteLine();
            }
        }

        public static void DrawBoard3(int rows, int columns)
        {
            if (isNotValid(rows, columns))
            {
                Console.WriteLine("Please enter numbers between 2 and 30");
            }
            else
            {
                for (int i = 0; i < rows; i++)
                {
                    string row1 = "|";
                    string row2 = "";

                    for (int j = 0; j < columns; j++)
                    {
                        row1 = row1 + " | ";
                        row2 = row2 + "-+-";
                    }
                    Console.WriteLine(row1);
                    Console.WriteLine(row2);
                }
                Console.WriteLine();
            }
        }
    }
}
