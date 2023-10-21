using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Expr
{
    class IncrementExpr : IExpr
    {
        private string varName;

        public IncrementExpr(string varName)
        {
            this.varName = varName;
        }
        public int Calculate()
        {
            int value = Variables.Instance[varName];
            Variables.Instance[varName] = value + 1;
            return value;
        }
    }
}