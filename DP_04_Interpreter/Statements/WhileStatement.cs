using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Statements
{
    class WhileStatement : IStatement
    {
        private IExpr condition;
        private IStatement body;

        public WhileStatement(IExpr condition, IStatement body)
        {
            this.condition = condition;
            this.body = body;
        }

        public void Execute()
        {
            while (condition.Calculate() != 0)
            {
                body.Execute();
            }
        }
    }
}
