using System;

namespace TicTacToe
{
    public class RandomPlayer : Player
    {
        public RandomPlayer(int playerNumber) : base(playerNumber) 
        {
        }
        
        public override bool GetDecision(Board board, out int row, out int col)
        {
            Random random = new Random();
            
            
            for (int i = 0; i < 100; i++)  
            {
                row = random.Next(0, 3);
                col = random.Next(0, 3);
                
                
                if (board.IsEmpty(row, col) == true)
                {
                    return true;
                }
            }
            
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board.IsEmpty(i, j) == true)
                    {
                        row = i;
                        col = j;
                        return true;
                    }
                }
            }
            
           
            row = -1;
            col = -1;
            return false;
        }
    }
}