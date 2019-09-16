using game_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    public class GameBoard : IBoard
    {
        public List<GameTile> board { get; set; }

        public GameBoard(List<GameTile> board)
        {
            this.board = board;
        }

        public void MakeBoard()
        { 
            for (int i = 0; i < 20; i++)
            {
                board.Add(new GameTile("T"));
            }
        }

        public void PrintBoard()
        {
            Console.WriteLine(board[0].ToString() + board[1].ToString(), board[2].ToString(), board[3].ToString(), board[4].ToString(), board[5].ToString());
            Console.WriteLine(board[19].ToString() + "    " + board[6].ToString());
            Console.WriteLine(board[18].ToString() + "    " + board[7].ToString());
            Console.WriteLine(board[17].ToString() + "    " + board[8].ToString());
            Console.WriteLine(board[16].ToString() + "    " + board[9].ToString());
            Console.WriteLine(board[15].ToString() + board[14].ToString(), board[13].ToString(), board[12].ToString(), board[11].ToString(), board[10].ToString());
        }
    }
}
