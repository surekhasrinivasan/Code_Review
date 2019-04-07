using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChallenge
{
    public class Game 
    {
        //private bool player1;
        //private bool player2;
        //public string Winner;
        //public int MovesCounter;

        //public bool Player1 { get => player1; set => player1 = value; }
        //public bool Player2 { get => player2; set => player2 = value; }

        //public enum State
        //{
        //    empty = 0,
        //    Player1 = 1,
        //    Player2 = 2
        //}

        //// 2D array of states represents the board 
        //private State[,] gameBoard = new State[7, 6];

        //public Game()
        //{
        //    Player1 = true;
        //    Player2 = false;

        //    for (int width = 0; width < gameBoard.GetLength(0); width++)
        //    {
        //        for (int height = 0; height < gameBoard.GetLength(1); height++)
        //        {
        //            gameBoard[width, height] = State.empty;
        //        }
        //    }

        //}
           

        int player1 = 1;
        int player2 = 2;
        int emptyCell = 0;

        public Game(int player1, int player2, int emptyCell)
        {
            this.player1 = player1;
            this.player2 = player2;
            this.emptyCell = emptyCell;
        }
        

        int[,] storeData = new int[7, 6];

        public int[,] applyMove(int[,] storeData)
        {
            for(int i = 0; i < storeData.GetLength(0); i++)
            {
                for(int j = 0; j < storeData.GetLength(1); j++)
                {
                    storeData[i, j] = 0;
                    Console.WriteLine("storeData[{0}, {1}] = {2}", i, j, storeData[i, j]);
                }
            }
            return storeData;
        }

    }
}
