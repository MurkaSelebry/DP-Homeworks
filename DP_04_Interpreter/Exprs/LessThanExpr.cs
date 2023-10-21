using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter {
    class LessThanExpr : BinaryExpr {
        public LessThanExpr (IExpr left, IExpr right) : base (left, right) { }

        public override int Calculate () => left.Calculate () < right.Calculate () ? 1 : 0;
    }
}
