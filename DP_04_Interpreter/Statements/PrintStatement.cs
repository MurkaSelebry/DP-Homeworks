using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter {
    class PrintStatement : IStatement {
        private IExpr expr;

        public PrintStatement (IExpr expr) => this.expr = expr;


        public void Execute () {
            Console.WriteLine (expr.Calculate ());
        }
    }
}
