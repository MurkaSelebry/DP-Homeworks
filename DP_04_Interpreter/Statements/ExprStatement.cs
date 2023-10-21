using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter {
    class ExprStatement : IStatement {
        private IExpr expr;

        public ExprStatement (IExpr expr) => this.expr = expr;


        public void Execute () => expr.Calculate ();
    }
}
