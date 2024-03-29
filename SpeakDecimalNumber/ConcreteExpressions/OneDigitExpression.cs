﻿using SpeakDecimalNumber.AbstractExpressions;

namespace SpeakDecimalNumber.ConcreteExpressions
{
    class OneDigitExpression : Expression
    {
        public override string Zero()
        {
            return "khong";
        }

        public override string One(int prevDigit)
        {
            if (prevDigit == 1 || prevDigit == -1)
                return "mot";
            return "mo't";
        }

        public override string Two()
        {
            return "hai";
        }

        public override string Three()
        {
            return "ba";
        }

        public override string Four()
        {
            return "bon";
        }

        public override string Five(int prevDigit)
        {
            if (prevDigit != -1)
                return "lam";
            return "nam";
        }

        public override string Six()
        {
            return "sau";
        }

        public override string Seven()
        {
            return "bay";
        }

        public override string Eight()
        {
            return "tam";
        }

        public override string Nine()
        {
            return "chin";
        }

        public override int Multiplier()
        {
            return 1;
        }
    }
}
