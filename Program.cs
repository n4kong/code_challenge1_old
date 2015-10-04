using Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {

            BattleShipBoardImpl board = new BattleShipBoardImpl();
            board.Delay = 50;


            board.NewGame1();
            board.PrintBoard();
            board.Play();
            Console.WriteLine("Total Hit: " + board.HitCount + ", Enter to start next game.");
            Console.ReadLine();

            board.NewGame2();
            board.PrintBoard();
            board.Play();
            Console.WriteLine("Total Hit: " + board.HitCount + ", Enter to start next game.");
            Console.ReadLine();

            board.NewGame3();
            board.PrintBoard();
            board.Play();
            Console.WriteLine("Total Hit: " + board.HitCount);
            Console.ReadLine();
        }


    }

   
}
