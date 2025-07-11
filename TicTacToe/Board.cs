using System;
namespace TicTacToe
{

    public class Board
    {
            public const int BOARD_SIZE = 3;
            public const int EMPTY = 0;
            public const int FIRST_PLAYER = 1;
            public const int SECOND_PLAYER = -1;
            private int[,] cells = new int[BOARD_SIZE,BOARD_SIZE];
        
    
    public void Init()
    {
        const int BOARD_SIZE = 3; // 例として3x3のボードサイズを設定
        
        
        Console.Write("   "); // 行番号のスペース
        for(int k =0;k<3;k++)
        {
            Console.Write(k + "  ");
        }
        Console.WriteLine(); // 改行

        for (int i = 0; i < BOARD_SIZE; i++)
        {
            Console.Write(i);
            for (int j =0;j<BOARD_SIZE;j++)
            {
                Console.Write("[ ");
                
                cells[i,j] = EMPTY;
                Console.Write("]");
            }
            
        Console.WriteLine();// 改行
        }
    }
    public void Print()
    {
                Console.WriteLine("  0  1  2");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i);
            for (int j =0;j<3;j++)
            {
                
                Console.Write("[");
                if(cells[i,j]==FIRST_PLAYER)
                {
                    Console.Write("○");
                }
                else if(cells[i,j]==SECOND_PLAYER)
                {
                    Console.Write("x");
                }
                else
                {
                    Console.Write(" ");
                }
                Console.Write("]");
            }
            
        Console.WriteLine();// 改行
        }

    }

    public bool CheckRange(int row,int col)
    {
        if(row<0||row>2||col<0||col>2)
        {
            Console.WriteLine("Row :out of range");
            return false;
        }
        
        return true;
    }

    public bool IsEmpty(int row, int col)
    {
        if (row < 0 || row > 2 || col < 0 || col > 2)
        {
            return false;
        }
        return cells[row, col] == EMPTY;
    }

    public bool Updata(int row,int col,int currentPlayer)
    {

        if (cells[row,col]!=EMPTY){
            Console.WriteLine("その場所に数字を置いています");
            return false;
        }
        cells[row,col] = currentPlayer;  
        return true;
        

    }
    public int CheckWinner()
    {
                for(int i=0;i<3;i++){
            if(cells[i,0]!=EMPTY&&cells[i,0]==cells[i,1]&&cells[i,1]==cells[i,2]){
                return 1;
            }
        }
        for(int i=0;i<3;i++){
            if(cells[0,i]!=EMPTY&&cells[0,i]==cells[1,i]&&cells[1,i]==cells[2,i]){
                return 1;
            }
        }
        if(cells[0,0]!=EMPTY&&cells[0,0]==cells[1,1]&&cells[1,1]==cells[2,2]){
            return 1;
        }
        if(cells[0,2]!=EMPTY&&cells[0,2]==cells[1,1]&&cells[1,1]==cells[2,0]){
            return 1;
        }
        return 0;
        
    }
    }
}