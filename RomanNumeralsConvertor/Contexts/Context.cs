﻿namespace RomanNumeralsConvertor.Contexts
{
    class Context
    {
        public string Input { get; set; }
        public int Output { get; set; }

        public Context(string input)
        {
            Input = input;
        }
    }
}
