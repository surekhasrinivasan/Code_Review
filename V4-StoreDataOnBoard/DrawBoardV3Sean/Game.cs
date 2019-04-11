using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawBoardV3Sean
{
    class Game
    {
        public char[,] GameState;
        public char player1;
        public char player2;


        public Game(int r, int c, char p1, char p2)
        {
            this.player1 = p1;
            this.player2 = p2;
            this.GameState = new char[r, c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    //GameState[i, j] = '.';
                    GameState[i, j] = '|';
                    //Console.WriteLine('+');
                }
            }
        }
        
        public void PrintGameState()
        {
            for (int i = 0; i < GameState.GetLength(0); i++)
            {
                for (int j = 0; j < GameState.GetLength(1); j++)
                {
                    Console.Write(GameState[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }

        // represents the player and the column they intend to drop the chip
        public void ApplyMove(char p, int col)
        {
            int row;
            for (row = 0; row < GameState.GetLength(0); row++)
            {
                //if (GameState[row, col] != '.') break;
                if (GameState[row, col] != '|') break;
            }
            Console.WriteLine("The player selection is row = {0}; col = {1}", row, col);
            GameState[row - 1, col] = p;
            //Console.WriteLine(this.GameState[j - 1, c] = p);            
        }
    }   
}
