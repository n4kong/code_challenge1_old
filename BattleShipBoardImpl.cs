using Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge1
{
    public class BattleShipBoardImpl : BattleShipBoard
    {
        public override void Play()
        {
            // Implement AI logic here

            #region example code 
            /*
            var isCompleted = false;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    var result = Fire(i, j);
                    PrintBoard();
                    if (result == Result.COMPLETED)
                    {
                        isCompleted = true;
                        break;
                    }
                }
                if (isCompleted)
                    break;
            }
             */
            #endregion
        }

        public void PrintBoard()
        {
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(board[i, j] ?? ".");
                }
                Console.WriteLine();
            }
        }
    }
}
