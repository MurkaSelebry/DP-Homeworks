using Interpreter.Expr;
using Interpreter.Exprs;
using Interpreter.Statements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter {
    class InterpreterMain {
        static void Main (string[] args) {
            // создаём узлы 2 и 2
            IExpr leftTwo = new ConstExpr (2);
            IExpr rightTwo = new ConstExpr (2);
            // сумма узлов: 2 + 2
            IExpr twoPlusTwo = new PlusExpr (leftTwo, rightTwo);
            // присваивание: sum = 2 + 2
            IExpr assignSum = new AssignVarExpr ("sum", twoPlusTwo);
            // утверждение: sum = 2 + 2;
            IStatement assignState = new ExprStatement (assignSum);
            assignState.Execute ();  // исполнить

            // то же самое, но в одну команду
            IStatement singleCommand = new ExprStatement (
                new AssignVarExpr ("sum",
                    new PlusExpr (
                        new ConstExpr (2),
                        new ConstExpr (2))));
            singleCommand.Execute ();

            // if (sum < 5)
            //     print (-1);
            // else
            //     print (1);
            new IfElseStatement(
                new LessThanExpr(
                    new VarExpr("sum"),
                    new ConstExpr(5)),
                new PrintStatement(
                    new ConstExpr(-1)),
                new PrintStatement(
                    new ConstExpr(1)))
            .Execute();

            //Для дерева из задания
            // Создание узла n и чтение ввода
            IExpr nExpr = new InputExpr();
            IStatement assignN = new ExprStatement(new AssignVarExpr("n", nExpr));
            assignN.Execute();

            // Инициализация переменных sum и i
            IStatement assignSumF = new ExprStatement( new AssignVarExpr("sum", new ConstExpr(0)));
            IStatement assignI = new ExprStatement(new AssignVarExpr("i", new ConstExpr(0)));
            assignSumF.Execute();
            assignI.Execute();

            // Цикл for: for (i = 0; i < n; i++)
            IStatement forLoop = new ForStatement(
                new ExprStatement(new AssignVarExpr("i", new ConstExpr(0))),
                new LessThanExpr(new VarExpr("i"), new VarExpr("n")),
                new ExprStatement(new IncrementExpr("i")),
                new ExprStatement(
                    new AssignVarExpr(
                        "sum",
                        new PlusExpr(new VarExpr("sum"), new VarExpr("i"))
                    )
                )
            );
            forLoop.Execute();

            // Вывод результата
            IStatement printSum = new PrintStatement(new VarExpr("sum"));
            printSum.Execute();

        }
    }
}
