using SpeakDecimalNumber.Contexts;
using System;

namespace SpeakDecimalNumber.AbstractExpressions
{
    abstract class Expression
    {
        public void Interpret(Context context)
        {
            if (context == null)
                return;

            string strInput = context.Input.ToString();
            if (strInput.Length == 0
                || !IsRightExpression(strInput))
                return;

            int firstDigit;
            Int32.TryParse(strInput.Substring(0, 1), out firstDigit);
            switch (firstDigit)
            {
                case 0:
                    context.Output += Zero() + " ";
                    break;
                case 1:
                    context.Output += One() + " ";
                    break;
                case 2:
                    context.Output += Two() + " ";
                    break;
                case 3:
                    context.Output += Three() + " ";
                    break;
                case 4:
                    context.Output += Four() + " ";
                    break;
                case 5:
                    context.Output += Five() + " ";
                    break;
                case 6:
                    context.Output += Six() + " ";
                    break;
                case 7:
                    context.Output += Seven() + " ";
                    break;
                case 8:
                    context.Output += Eight() + " ";
                    break;
                case 9:
                    context.Output += Nine() + " ";
                    break;
                default: break;
            }

            if (strInput.Length == 1)
                context.Input = 0;
            else context.Input = Convert.ToInt32(strInput.Substring(1));
            context.PrevDigit = firstDigit;
        }

        private bool IsRightExpression(string strInput)
        {
            return strInput.Length == Multiplier().ToString().Length;
        }

        public abstract string Zero();
        public abstract string One();
        public abstract string Two();
        public abstract string Three();
        public abstract string Four();
        public abstract string Five();
        public abstract string Six();
        public abstract string Seven();
        public abstract string Eight();
        public abstract string Nine();
        public abstract int Multiplier();
    }
}
