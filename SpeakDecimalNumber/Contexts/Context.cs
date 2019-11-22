namespace SpeakDecimalNumber.Contexts
{
    class Context
    {
        public int Input { get; set; }
        public int PrevDigit { get; set; }
        public string Output { get; set; }

        public Context(int input)
        {
            Input = input;
            PrevDigit = -1;
        }
    }
}
