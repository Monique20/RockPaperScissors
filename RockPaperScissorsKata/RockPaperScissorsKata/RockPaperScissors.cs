using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsKata
{
    public class RockPaperScissors: IRockPaperScissors
    {
        public string Play(string player1, string player2)
        {
            if (player1 == "Rock" && player2 == "Scissors" || player1 == "Scissors" && player2 == "Rock")
            {
                return "Rock has won";
            }
            else if (player1 == "Scissors" && player2 == "Paper" || player1 == "Paper" && player2 == "Scissors")
            {
                return "Scissors has won";
            }
            else if (player1 == "Paper" && player2 == "Rock" || player1 == "Rock" && player2 == "Paper")
            {
                return "Paper has won";
            }
            return "Draw";
        }
    }
}