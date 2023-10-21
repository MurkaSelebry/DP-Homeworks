using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter {
    class IfElseStatement : IStatement {
        private IExpr condition;
        private IStatement ifYes;
        private IStatement ifNo;

        public IfElseStatement (IExpr condition, IStatement ifYes, IStatement ifNo) {
            this.condition = condition;
            this.ifYes = ifYes;
            this.ifNo = ifNo;
        }

        public void Execute () {
            if (condition.Calculate () != 0)
                ifYes.Execute ();
            else
                ifNo.Execute ();
        }
    }
}
