using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public class BotLog
    {
        public string[] karta = new string[9];
        public int EvaluateBoard()
        {
            if (IsWin("X"))
            {
                return -10;
            }
            if (IsWin("O"))
            {
                return 10;
            }
            if (IsDraw())
            {
                return 0;
            }
            int score = 0;
            for (int i = 0; i < 9; i++)
            {
                if (karta[i] == "X")
                {
                    score--;
                }
                else if (karta[i] == "O")
                {
                    score++;
                }
            }
            return score;
        }

        public bool IsWin(string player)
        {
            return (karta[0] == player && karta[1] == player && karta[2] == player) ||
                   (karta[3] == player && karta[4] == player && karta[5] == player) ||
                   (karta[6] == player && karta[7] == player && karta[8] == player) ||
                   (karta[0] == player && karta[3] == player && karta[6] == player) ||
                   (karta[1] == player && karta[4] == player && karta[7] == player) ||
                   (karta[2] == player && karta[5] == player && karta[8] == player) ||
                   (karta[0] == player && karta[4] == player && karta[8] == player) ||
                   (karta[2] == player && karta[4] == player && karta[6] == player);
        }

        public bool IsDraw()
        {
            for (int i = 0; i < 9; i++)
            {
                if (karta[i] == "")
                {
                    return false;
                }
            }
            return true;
        }

        public int Minimax(int depth, bool isMaximizingPlayer)
        {
            if (IsWin("X") || IsWin("O") || IsDraw())
            {
                return EvaluateBoard();
            }
            if (isMaximizingPlayer)
            {
                int bestScore = int.MinValue;
                for (int i = 0; i < 9; i++)
                {
                    if (karta[i] == "")
                    {
                        karta[i] = "O";
                        int score = Minimax(depth + 1, false);
                        karta[i] = "";
                        bestScore = Math.Max(bestScore, score);
                    }
                }
                return bestScore;
            }
            else
            {
                int bestScore = int.MaxValue;
                for (int i = 0; i < 9; i++)
                {
                    if (karta[i] == "")
                    {
                        karta[i] = "X";
                        int score = Minimax(depth + 1, true);
                        karta[i] = "";
                        bestScore = Math.Min(bestScore, score);
                    }
                }
                return bestScore;
            }
        }
        public void Bot(ref Button button1, ref Button button2, ref Button button3, ref Button button4, ref Button button5, ref Button button6, ref Button button7, ref Button button8, ref Button button9)
        {
            karta[0] = button1.Text;
            karta[1] = button2.Text;
            karta[2] = button3.Text;
            karta[3] = button4.Text;
            karta[4] = button5.Text;
            karta[5] = button6.Text;
            karta[6] = button7.Text;
            karta[7] = button8.Text;
            karta[8] = button9.Text;
        }
        public void Bothod(ref Button button1, ref Button button2, ref Button button3, ref Button button4, ref Button button5, ref Button button6, ref Button button7, ref Button button8, ref Button button9)
        {
            int bestScore = int.MinValue;
            int bestMove = -1;
            for (int i = 0; i < 9; i++)
            {
                if (karta[i] == "")
                {
                    karta[i] = "O";
                    int score = Minimax(1, false);
                    karta[i] = "";
                    if (score > bestScore)
                    {
                        bestScore = score;
                        bestMove = i;
                    }
                }
            }
            if (bestMove != -1)
            {
                switch (bestMove)
                {
                    case 0: button1.Text = "O"; button1.Enabled = false; break;
                    case 1: button2.Text = "O"; button2.Enabled = false; break;
                    case 2: button3.Text = "O"; button3.Enabled = false; break;
                    case 3: button4.Text = "O"; button4.Enabled = false; break;
                    case 4: button5.Text = "O"; button5.Enabled = false; break;
                    case 5: button6.Text = "O"; button6.Enabled = false; break;
                    case 6: button7.Text = "O"; button7.Enabled = false; break;
                    case 7: button8.Text = "O"; button8.Enabled = false; break;
                    case 8: button9.Text = "O"; button9.Enabled = false; break;
                }
            }
        }
        public void CalculateProbabilities(ref Button button10, ref Button button11, ref Button button12)
        {
            int totalGames = 0;
            int xWins = 0;
            int oWins = 0;
            int draws = 0;

            SimulateAllGames(1, true, ref totalGames, ref xWins, ref oWins, ref draws);

            double xWinProbability = (double)xWins / totalGames;
            double oWinProbability = (double)oWins / totalGames;
            double drawProbability = (double)draws / totalGames;

            button10.Text = ($"Win X: {Math.Round(xWinProbability * 100, 2)}");
            button11.Text = ($"Win O: {Math.Round(oWinProbability * 100, 2)}");
            button12.Text = ($"Draw: {Math.Round(drawProbability * 100, 2)}");
        }

        public void SimulateAllGames(int depth, bool isMaximizingPlayer, ref int totalGames, ref int xWins, ref int oWins, ref int draws)
        {
            if (IsWin("X"))
            {
                xWins++;
                totalGames++;
                return;
            }
            if (IsWin("O"))
            {
                oWins++;
                totalGames++;
                return;
            }
            if (IsDraw())
            {
                draws++;
                totalGames++;
                return;
            }

            for (int i = 0; i < 9; i++)
            {
                if (karta[i] == "")
                {
                    if (isMaximizingPlayer)
                    {
                        karta[i] = "X";
                    }
                    else
                    {
                        karta[i] = "O";
                    }

                    SimulateAllGames(depth + 1, !isMaximizingPlayer, ref totalGames, ref xWins, ref oWins, ref draws);

                    karta[i] = "";
                }
            }
        }
    }
}