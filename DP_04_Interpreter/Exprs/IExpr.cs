using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter {
    // Один узел в вычислительном дереве
    // Expression — это формула. Например, переменная или сложение двух формул
    interface IExpr {
        // Посчитать значение формулы
        int Calculate ();
    }
}
