using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Math_Expression_Evaluator
{
    public static  class ExperssionParser
    {
        private const string MathSymbol = "+*/%^";

        public static MathExpression Parse (string input)
        {
            var expr = new MathExpression ();
            string token = "";
            bool leftSideInitialized =false;

            for (var i= 0; i < input.Length; i++)
            {
                var currentChar = input[i];
                if (char.IsDigit(currentChar))
                {
                    token += currentChar;
                    if (i ==input.Length -1 && leftSideInitialized)
                    {
                        expr.RightSideOperand = double.Parse(token);
                        break;
                    }

                }else if (MathSymbol.Contains(currentChar))
                {
                    if (!leftSideInitialized)
                    {


                        expr.LeftSideOperand = double.Parse(token);
                        leftSideInitialized = true;
                    }
                        expr.Operation = ParseMathOperation(currentChar.ToString());
                        token = "";

                }else if (currentChar == '-' && i>0)
                {
                   if (expr.Operation == MathOperation.None)
                    {
                        expr.Operation = MathOperation.Subtraction;
                        expr.LeftSideOperand=double.Parse(token);
                        leftSideInitialized = true;
                        token = "";

                    }else
                    {
                        token += currentChar;
                    }

                }
                else if (char.IsLetter(currentChar))
                {
                    token += currentChar;
                    leftSideInitialized  = true;

                }else if (currentChar == ' ')
                {
                    if (!leftSideInitialized)
                    {
                        expr.LeftSideOperand= double.Parse(token);
                        leftSideInitialized= true;
                        token = "";
                    }
                    else if ( expr.Operation == MathOperation.None)
                    {
                        expr.Operation =ParseMathOperation(token);
                        token = "";
                    }
                    
                }else
                {
                    token += currentChar;
                }
            }
            return expr;
        }

        private static MathOperation ParseMathOperation(string token)
        {
            switch (token.ToLower()) {
                case "+":
                    return MathOperation.Addition;
                case "*":
                    return MathOperation.Multiplication;
                case "/":
                    return MathOperation.Division;
                case "%":
                case "mod":
                    return MathOperation.Modulus;
                case "^":
                case "pow":
                    return MathOperation.Power;
                case "sin":
                    return MathOperation.Sin;
                case "cos":
                    return MathOperation.Cos;
                case "tan":
                    return MathOperation.Tan;
                default:
                    return MathOperation.None;
            }
        }
    }
}
