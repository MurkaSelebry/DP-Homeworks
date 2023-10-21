using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter {
    // Константный узел
    // Запоминает значение в момент создания
    class ConstExpr : IExpr {
        private int value;

        public ConstExpr (int value) => this.value = value;

        public int Calculate () => value;
    }
}
