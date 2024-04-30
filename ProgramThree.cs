using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    public class ProgramThree:ProgramTwo//
    {
        int _rank;
        public ProgramThree(int id, string name, int rank) : base(id, name)
        {
            this._rank = rank;
        }
        public int Rank {  get { return _rank; } }
    }
}
