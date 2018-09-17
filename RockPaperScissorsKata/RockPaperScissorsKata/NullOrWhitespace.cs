using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsKata
{
    public class NullOrWhitespace : IRockPaperScissors
    {
        private IRockPaperScissors _nextRockPaperScissors;

        public string Play(string player1, string player2)
        {
            if (string.IsNullOrWhiteSpace(player1) || string.IsNullOrWhiteSpace(player2))
            {
                return "Invalid input";
            }

            return _nextRockPaperScissors.Play(player1, player2);
        }

        public void SetSucessor(IRockPaperScissors nextRockPaperScissors)
        {
            _nextRockPaperScissors = nextRockPaperScissors;
        }
    }
}
