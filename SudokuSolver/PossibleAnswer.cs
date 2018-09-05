using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class PossibleAnswer : IComparable<PossibleAnswer>
    {
        public int Value;
        public int Appears;

        public PossibleAnswer(int _Value)
        {
            Value = _Value;
            Appears = 0;
        }


        public int CompareTo(PossibleAnswer elo)
        {
            if (Appears > elo.Appears)
            {
                return -1;
            }
            else if (Appears == elo.Appears)
                return 0;
            else
                return 1; 
        }

    }
}
