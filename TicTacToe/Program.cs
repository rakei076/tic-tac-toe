using System;
using System.Collections.Generic;
using TicTacToe;

namespace TicTacToe
{
class MyGame
{
        const int EMPTY = 0;
        const int FIRST_PLAYER = 1;
        const int SECOND_PLAYER = -1;
        private static int turnNumber = 1; 

    // ここにゲームの主処理を書く
    public void Start()
    {

        
        Console.WriteLine("ゲームを開始します！");
        
        Board board = new Board(); 
        
        // プレイヤーを作成
        Queue<Player> players = new Queue<Player>();
        players.Enqueue(new HumanPlayer(FIRST_PLAYER));
        players.Enqueue(new RandomPlayer(SECOND_PLAYER));
        
        board.Init();
        kaisu(board, players);
        
        
        // ここにあなたのロジックを追加
        board.Print();



 
        
    }


    static bool ReadPlayerInput(Board board, Player currentPlayer){
        int row;
        int col;
        bool success = currentPlayer.GetDecision(board, out row, out col);
        if(!success)
        {
            return false;
        }
        
        if (board.CheckRange(row,col)==false){
            return false;
        }

        if (board.Updata(row,col,currentPlayer.PlayerNumber)==false){
            return false;
        }
        
    
            
        
        Console.WriteLine($"Turn:{turnNumber} Player:{(currentPlayer.PlayerNumber==FIRST_PLAYER?"○":"×")}");
        
        return true;
    }

    static void kaisu(Board board, Queue<Player> players){
        Player currentPlayer = players.Peek();
        
        if(board.CheckWinner()==1){
            Console.Write($"game over 勝の方は{(currentPlayer.PlayerNumber==FIRST_PLAYER?"○":"×")}");
            Console.WriteLine();
            gameover();
            return;
        }
        if (turnNumber==10){
                gameover();
                return;
            }
        
        if (ReadPlayerInput(board, currentPlayer))
        {
            turnNumber++;
            board.Print();
           
            Console.Write("------------");
            Console.WriteLine();
            
            // プレイヤーを交代
            Player player = players.Dequeue();
            players.Enqueue(player);
        }
        kaisu(board, players);
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
}