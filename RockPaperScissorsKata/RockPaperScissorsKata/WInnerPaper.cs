using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsKata
{
    public class WinnerPaper : IRockPaperScissors
    {
        private IRockPaperScissors _nextRockPaperScissors;

        public string Play(string player1, string player2)
        {
            if (player1 == "Paper" && player2 == "Rock" || player1 == "Rock" && player2 == "Paper")
            {
                return "Paper has won";
            }

            return _nextRockPaperScissors.Play(player1, player2);
        }

        public void SetSucessor(IRockPaperScissors nextRockPaperScissors)
        {
            _nextRockPaperScissors = nextRockPaperScissors;
        }
    }
}
