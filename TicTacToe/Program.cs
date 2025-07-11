using System;
using TicTacToe;
class MyGame
{
        const int EMPTY = 0;
        const int FIRST_PLAYER = 1;
        const int SECOND_PLAYER = -1;
        private static int currentplayer = FIRST_PLAYER;
        private static int turnNumber = 1;

    // ここにゲームの主処理を書く
    public void Start()
    {

        
        Console.WriteLine("ゲームを開始します！");
        
        Board board = new Board(); 
        
        board.Init();
        kaisu(board);
        
        
        // ここにあなたのロジックを追加
        board.Print();



 
        
    }


    static bool ReadPlayerInput(Board board){
        Console.Write("> Input Row: ");
        int row;
        bool success =int.TryParse(Console.ReadLine(),out row);
        if(!success)
        {
            Console.WriteLine("Row :invalid input");
            return false;
        }
        Console.Write("> Input Column: ");
        int col;
        success =int.TryParse(Console.ReadLine(),out col);
        if(!success)
        {
            Console.WriteLine("Column :invalid input");
            return false;
        }
        
        if (board.CheckRange(row,col)==false){
            return false;
        }

        if (board.Updata(row,col,currentplayer)==false){
            return false;
        }
        
    
            
        
        Console.WriteLine($"Turn:{turnNumber} Player:{(currentplayer==FIRST_PLAYER?"○":"×")}");
        
        return true;
    }

    static void kaisu(Board board){
        if(board.CheckWinner()==1){
            Console.Write($"game over 勝の方は{(currentplayer==FIRST_PLAYER?"○":"×")}");
            Console.WriteLine();
            gameover();
            return;
        }
        if (turnNumber==10){
                gameover();
                return;
            }
        currentplayer = FIRST_PLAYER;
        if(turnNumber%2==0)
        {
            currentplayer = SECOND_PLAYER;
        }
        
        if (ReadPlayerInput(board))
        {
            turnNumber++;
            board.Print();
           
            Console.Write("------------");
            Console.WriteLine();
            
        }
        kaisu(board);
    }
    static void gameover(){
        Console.Write("game over");
        Console.WriteLine();
        return;
    }


    
}

class Program
{
    static void Main(string[] args)
    {
        MyGame game = new MyGame();
        game.Start();
    }
}
//dotnet run