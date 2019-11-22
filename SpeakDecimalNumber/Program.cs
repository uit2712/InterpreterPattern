using SpeakDecimalNumber.AbstractExpressions;
using SpeakDecimalNumber.ConcreteExpressions;
using SpeakDecimalNumber.Contexts;
using System;
using System.Collections.Generic;

namespace SpeakDecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int number = Convert.ToInt32(Console.ReadLine());

                Context context = new Context(number);

                // Build the 'parse tree' 
                List<Expression> tree = new List<Expression>();
                tree.Add(new TwoDigitsExpression());
                tree.Add(new OneDigitExpression());

                // Interpret 
                foreach (Expression exp in tree)
                    exp.Interpret(context);

                Console.WriteLine(number + " = " + context.Output);
            }
        }
    }
}
