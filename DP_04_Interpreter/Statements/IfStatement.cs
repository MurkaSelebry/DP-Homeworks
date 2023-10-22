using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Statements
{
    class IfStatement : IStatement
    {
        private IExpr condition;
        private IStatement ifYes;

        public IfStatement(IExpr condition, IStatement ifYes)
        {
            this.condition = condition;
            this.ifYes = ifYes;
        }

        public void Execute()
        {
            if (condition.Calculate() != 0)
                ifYes.Execute();
        }
    }
}
