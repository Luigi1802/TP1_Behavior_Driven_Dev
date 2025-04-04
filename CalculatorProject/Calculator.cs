using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorProject
{
    public class Calculator
    {
        public List<int> Operands { get; set; }
        
        public int Subtract()
        {
            //return firstNumber - secondNumber;
            if (!Operands.Any()) throw new InvalidOperationException("No operand.");
            return Operands.Skip(1).Aggregate(Operands.First(), (acc, val) => acc - val);
        }

        public int Multiply()
        {
            //return firstNumber * secondNumber;
            return Operands.Aggregate(1, (acc, val) => acc * val);
        }

        public int Divide()
        {
            //if (secondNumber == 0)
            //{
            //    throw new DivideByZeroException("Cannot divide by zero");
            //}
            //return firstNumber / secondNumber;
            if (!Operands.Any()) throw new InvalidOperationException("No operand.");
            return Operands.Skip(1).Aggregate(Operands.First(), (acc, val) =>
            {
                if (val == 0) throw new DivideByZeroException("Cannot divide by zero.");
                return acc / val;
            });
        }

        public int Add()
        {
            return Operands.Sum();
        }
    }
}