using System.Data;
using System.Runtime.CompilerServices;

namespace Tictactoe
{
    public partial class Form1 : Form
    {
        public char player;
        public Dictionary<int, char?> board;
        public Form1()
        {
            InitializeComponent();
            player = 'X';
            board = new Dictionary<int, char?>();
            for (int i = 0; i < 10; i++)
            {
                board.Add(i, null);
            }
        }
        public void PlayGame()
        {
            while (!IsWin(board) || !IsOver(board))
            {
                if (player == 'X')
                {
                    char move = (char)Console.Read();
                    if (board[move] != null)
                    {
                        Console.WriteLine("Already taken");
                    }
                    else
                    {
                        board[move] = 'X';
                    }
                    player = 'O';
                }
                else
                {
                    char move = (char)Console.Read();
                    if (board[move] != null)
                    {
                        Console.WriteLine("Already taken");
                    }
                    else
                    {
                        board[move] = 'O';
                    }
                    player = 'X';
                }
            }
            if (IsWin(board))
            {
                Console.WriteLine($"Player {player} won");
            }
            else
            {
                Console.WriteLine("Draw");
            }
            
        }
        public bool IsWin(Dictionary<int, char?> board)
        {
            if (board[1] == board[2] && board[2] == board[3])
                return true;
            else if (board[4] == board[5] && board[5] == board[6])
                return true;
            else if (board[7] == board[8] && board[8] == board[9])
                return true;
            else if (board[1] == board[4] && board[4] == board[7])
                return true;
            else if (board[2] == board[5] && board[5] == board[8])
                return true;
            else if (board[3] == board[6] && board[6] == board[9])
                return true;
            else if (board[1] == board[5] && board[5] == board[9])
                return true;
            else if (board[3] == board[5] && board[5] == board[7])
                return true;
            return false;

        }
        public bool IsOver(Dictionary<int, char?> board)
        {
            foreach (char? entry in board.Values)
            {
                if (entry == null)
                {
                    return false;
                }
            }
            return true;
        }
        
    static void Main(string[] args)
            {
                Form1 form = new Form1();
                form.PlayGame();
            }
        }
}