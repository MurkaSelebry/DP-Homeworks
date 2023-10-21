using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    // Глобальное хранилище всех переменных
    class Variables
    {
        public static Variables Instance { get; } = new Variables();

        private Variables() { }


        IDictionary<string, int> values = new Dictionary<string, int>();

        public int this[string varName]
        {
            get => values[varName];
            set => values[varName] = value;
        }
    }
}
