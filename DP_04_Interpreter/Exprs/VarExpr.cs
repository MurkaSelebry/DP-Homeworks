using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter {
    // Узел с переменной
    // Помнит имя переменной
    // Считывает значение из переменной в текущий момент
    class VarExpr : IExpr {
        private string name;

        public VarExpr (string name) => this.name = name;


        public int Calculate () => Variables.Instance[name];
    }
}
