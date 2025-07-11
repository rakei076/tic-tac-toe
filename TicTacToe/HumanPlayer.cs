using System;

namespace TicTacToe
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(int playerNumber) : base(playerNumber) 
        {
        }
        
        public override bool GetDecision(Board board, out int row, out int col)
        {
            Console.Write("> Input Row: ");
            string input1 = Console.ReadLine();
            bool success1 = int.TryParse(input1, out row);
            
            if (!success1)
            {
                Console.WriteLine("Row: invalid input");
                col = -1;
                return false;
            }
            
            Console.Write("> Input Column: ");
            string input2 = Console.ReadLine();
            bool success2 = int.TryParse(input2, out col);
            
            if (!success2)
            {
                Console.WriteLine("Column: invalid input");
                return false;
            }
            
            return true;
        }
    }
}