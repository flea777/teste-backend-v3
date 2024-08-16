using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheatricalPlayersRefactoringKata
{
    public class PlayCalculator
    {
        public int CalculateLines(int _lines)
        {
            var lines = _lines;
            if(lines > 4000) lines = 4000;
            if(lines < 1000) lines = 1000;
            return lines;
        }
    }
}