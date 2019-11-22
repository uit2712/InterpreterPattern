using SpeakDecimalNumber.AbstractExpressions;

namespace SpeakDecimalNumber.ConcreteExpressions
{
    class TwoDigitsExpression : Expression
    {
        public override string Zero()
        {
            return "";
        }

        public override string One(int prevDigit)
        {
            return "muoi";
        }

        public override string Two()
        {
            return "hai muoi";
        }

        public override string Three()
        {
            return "ba muoi";
        }

        public override string Four()
        {
            return "bon muoi";
        }

        public override string Five(int prevDigit)
        {
            return "nam muoi";
        }

        public override string Six()
        {
            return "sau muoi";
        }

        public override string Seven()
        {
            return "bay muoi";
        }

        public override string Eight()
        {
            return "tam muoi";
        }

        public override string Nine()
        {
            return "chin muoi";
        }

        public override int Multiplier()
        {
            return 10;
        }
    }
}
