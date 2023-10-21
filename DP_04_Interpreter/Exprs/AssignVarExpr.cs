using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter {
    class AssignVarExpr : IExpr {
        private string varName;
        private IExpr value;

        public AssignVarExpr (string varName, IExpr value) {
            this.varName = varName;
            this.value = value;
            Variables.Instance[varName] = value.Calculate();  //для переменной счетчика цикла  for
        }    

        public int Calculate () {
            int calculated = value.Calculate();
            Variables.Instance[varName] = calculated;
            return calculated;           
        }
    }
}
