using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ProgramTwo
    {
        int _id;
        string _name;
        public ProgramTwo(int id,string name)
        {
            this._id = id;
            this._name = name;   
        }
        public int Id { get { return _id; } }
        public string Name { get { return _name; } }

    }
}
