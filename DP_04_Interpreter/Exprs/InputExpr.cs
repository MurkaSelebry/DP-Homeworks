using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Expr
{
    class InputExpr : IExpr
    {
        public int Calculate()
        {
            string input = Console.ReadLine();
            int.TryParse(input, out int result);
            return result;
        }
    }
}
