using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter {
    // Один узел в исполнительном дереве
    // Statement — утверждение. Отдельная команда, заканчивающаяся точкой с запятой
    interface IStatement {
        // Исполнить команду
        void Execute ();
    }
}
