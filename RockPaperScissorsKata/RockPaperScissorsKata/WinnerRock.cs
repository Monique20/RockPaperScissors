using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsKata
{
    public class WinnerRock : IRockPaperScissors
    {
        private IRockPaperScissors _nextRockPaperScissors;

        public string Play(string player1, string player2)
        {
            if (player1 == "Rock" && player2 == "Scissors" || player1 == "Scissors" && player2 == "Rock")
            {
                return "Rock has won";
            }

            return _nextRockPaperScissors.Play(player1, player2);
        }

        public void SetSucessor(IRockPaperScissors nextRockPaperScissors)
        {
            _nextRockPaperScissors = nextRockPaperScissors;
        }
    }
}
