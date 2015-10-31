using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Simulator_BusinessLogic
{
    public enum Operators
    {
        AND,
        OR,
        INV,
        NAND,
        NOR,
        BUF,
        NONE
    }

    public class LogicRecord
    {
        #region Variables

        public Operators _operator;
        public List<int> _inputs;
        public int _output;

        #endregion

        public LogicRecord()
        {
            _operator = Operators.NONE;
            _inputs = new List<int>();
            _output = 0;
        }

    }
}
