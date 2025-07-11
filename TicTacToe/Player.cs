using System;

namespace TicTacToe
{
    public abstract class Player
    {
        public int PlayerNumber { get; set; }
        
        public Player(int playerNumber)
        {
            PlayerNumber = playerNumber;
        }
        
        public abstract bool GetDecision(Board board, out int row, out int col);
    }
}