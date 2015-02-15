using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcCore.Math
{
    interface IFinance
    {
        int Add(int x, int y);
    }

    class Finance:IFinance
    {
        public int Add(int x, int y)
        {
            return (x + y);
        }
    }
}
