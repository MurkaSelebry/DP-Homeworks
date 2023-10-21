using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Exprs
{
    class EqualExpr : IExpr
    {
        private IExpr right, left;

        public EqualExpr(IExpr right, IExpr left)
        {
            this.right = right;
            this.left = left;
        }

        public int Calculate()
        {
            return left.Calculate() == right.Calculate() ? 1 : 0;
        }
    }
}
