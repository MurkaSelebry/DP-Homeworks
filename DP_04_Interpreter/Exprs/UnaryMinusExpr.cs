using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter {
    class UnaryMinusExpr : IExpr {
        private IExpr operand;

        public UnaryMinusExpr (IExpr operand) => this.operand = operand;


        public int Calculate () => -operand.Calculate ();
    }
}
