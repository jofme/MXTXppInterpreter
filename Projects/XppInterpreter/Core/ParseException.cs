﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XppInterpreter.Lexer;

namespace XppInterpreter.Core
{
    public class ParseException : Exception
    {
        public Token Token { get; set; }
        public int Line { get; set; }
        public int Position { get; set; }
        public string Module { get; set; }

        public ParseException(string message, Token token, int line, int position) : base(message + $" at line {(line + 1)}")
        {
            Token = token;
            Line = line;
            Position = position;
        }
    }
}