using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Statements
{
    class DoWhileStatement : IStatement
    {
        private IExpr condition;
        private IStatement body;

        public DoWhileStatement(IExpr condition, IStatement body)
        {
            this.condition = condition;
            this.body = body;
        }

        public void Execute()
        {
            do
            {
                body.Execute();
            } while (condition.Calculate() != 0);
        }
    }
}
