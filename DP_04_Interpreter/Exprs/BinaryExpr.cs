using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter {
    abstract class BinaryExpr : IExpr {
        protected readonly IExpr left;
        protected readonly IExpr right;

        protected BinaryExpr (IExpr left, IExpr right) {
            this.left = left;
            this.right = right;
        }

        public abstract int Calculate ();
    }
}
