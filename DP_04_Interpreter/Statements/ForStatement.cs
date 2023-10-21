using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Statements
{
    class ForStatement : IStatement
    {
        private IStatement init;
        private IExpr condition;
        private IStatement update;
        private IStatement body;

        public ForStatement(IStatement init, IExpr condition, IStatement update, IStatement body)
        {
            this.init = init;
            this.condition = condition;
            this.update = update;
            this.body = body;
        }

        public void Execute()
        {
            for (init.Execute(); condition.Calculate() != 0; update.Execute())
            {
                body.Execute();
            }
        }
    }
}
