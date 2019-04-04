using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawBoard
{
    /* Task
     * 
     * Create the following function:
     * 
     * drawBoard(int x, int y)
     * This function should display an ascii grid that is is x Rows wide ad y columns tall.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows: ");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of columns: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DrawBoard1 pattern: ");
            DrawDynamicBoard.DrawBoard1(r, c);

            Console.WriteLine("DrawBoard2 Pattern: ");
            DrawDynamicBoard.DrawBoard2(r, c);

            Console.WriteLine("DrawBoard3 Pattern: ");
            DrawDynamicBoard.DrawBoard3(r, c);
        }
    }
}
