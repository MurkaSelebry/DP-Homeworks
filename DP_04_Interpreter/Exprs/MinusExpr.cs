using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter {
    class MinusExpr : BinaryExpr {
        public MinusExpr (IExpr left, IExpr right) : base (left, right) { }

        public override int Calculate () => left.Calculate () - right.Calculate ();
    }
}
