using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcCore.Math
{
    interface IFinance
    {
        int Add(int x, int y);
        int Subtract(int x, int y);
        int Multiply(int x, int y);
    }

    class Finance:IFinance
    {
        public int Add(int x, int y)
        {
            return (x + y);
        }

        public int Subtract(int x, int y)
        {
            return (x - y);
        }


        public int Multiply(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
