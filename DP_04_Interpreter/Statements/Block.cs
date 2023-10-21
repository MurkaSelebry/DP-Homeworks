using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Statements
{
    class Block : IStatement
    {
        private IStatement[] statements;

        public Block(params IStatement[] statements)
        {
            this.statements = statements;
        }

        public void Execute()
        {
            for (int i = 0; i < statements.Length; i++)
                statements[i].Execute();
        }
    }
}
