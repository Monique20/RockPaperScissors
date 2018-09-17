using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsKata
{
    public class WinnerScissors : IRockPaperScissors
    {
        private IRockPaperScissors _nextRockPaperScissors;

        public string Play(string player1, string player2)
        {
            if (player1 == "Scissors" && player2 == "Paper" || player1 == "Paper" && player2 == "Scissors")
            {
                return "Scissors has won";
            }

            return "Draw";
        }

        public void SetSucessor(IRockPaperScissors nextRockPaperScissors)
        {
            _nextRockPaperScissors = nextRockPaperScissors;
        }
    }
}
