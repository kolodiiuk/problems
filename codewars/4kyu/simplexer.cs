using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    class Simplexer : Iterator<Token>
    {
        private const string IntegerCode = "integer";
        private const string BooleanCode = "boolean";
        private const string OperatorCode = "operator";
        private const string StringCode = "string";
        private const string KeywordCode = "keyword";
        private const string WhitespaceCode = "whitespace";
        private const string IdentifierCode = "identifier";

        private char[] _s;
        private int _currIndex;
        private Token _current;
        private int _len;
        private bool _wasFalse;

        public Simplexer(string buffer)
        {
            if (buffer is null) 
            {
                buffer = "";
            }
            
            _s = new char[buffer.Length];
            _len = buffer.Length;
            for (var i = 0; i < buffer.Length; ++i)
            {
                _s[i] = buffer[i];
            }
        }

        public override bool MoveNext()
        {
            if (_currIndex >= _len)
            {
                _wasFalse = true;
                
                return false;
            }

            var res = false;
            switch (_s[_currIndex])
            {
                case '+' or '-' or '*' or '/' or '%' or '(' or ')' or '=':
                {
                    res = LexOp();
                    break;
                }
                case '0' or '1' or '2' or '3' or '4' or '5' or '6' or '7' or '8' or '9':
                {
                    res = LexInteger();
                    break;
                }
                case '"':
                {
                    res = LexStr();
                    break;
                }
                case ' ' or '\t' or '\n':
                {
                    res = LexWhitespace();
                    break;
                }
                default:
                {
                    res = LexBooleanIdentifierKeyword();
                    break;
                }
            }
            
            _wasFalse = res ? false : true;
            
            return res;
        }

        private bool LexOp()
        {
            _current = new Token(_s[_currIndex++].ToString(), OperatorCode);

            return true;
        }

        private bool LexInteger()
        {
            var sb = new StringBuilder();
            var i = _currIndex;
            while (i < _len && _s[i] >= '0' && _s[i] <= '9')
            {
                sb.Append(_s[i]);
                i++;
            }

            _currIndex = i;
            _current = new Token(sb.ToString(), IntegerCode);

            return true;
        }

        private bool LexStr()
        {
            var sb = new StringBuilder();
            sb.Append('"');
            var i = ++_currIndex;
            while (i < _len && _s[i] != '"')
            {
                sb.Append(_s[i]);
                i++;
            }

            if (i < _len && _s[i] == '"')
            {
                sb.Append('"');
                _currIndex = i + 1;
                _current = new Token(sb.ToString(), StringCode);

                return true;
            }
            else
            {
                return false;
            }
        }

        private bool LexWhitespace()
        {
            var sb = new StringBuilder();
            var i = _currIndex;
            while (i < _len && (_s[i] == ' ' || _s[i] == '\t' || _s[i] == '\n'))
            {
                sb.Append(_s[i]);
                i++;
            }

            _currIndex = i;
            _current = new Token(sb.ToString(), WhitespaceCode);

            return true;
        }

        private Token LexBooleans()
        {
            if (_len - _currIndex >= 4)
            {
                var span = new ReadOnlySpan<char>(_s, _currIndex, 4);
                if (span is "true")
                {
                    _currIndex += 4;

                    return new Token("true", BooleanCode);
                }
            }

            if (_len - _currIndex >= 5)
            {
                var span = new ReadOnlySpan<char>(_s, _currIndex, 5);
                if (span is "false")
                {
                    _currIndex += 5;

                    return new Token("false", BooleanCode);
                }
            }

            return null;
        }

        private Token LexKeywords()
        {
            for (int i = 2; i <= 6; ++i)
            {
                if (_len - _currIndex >= i)
                {
                    var span = new ReadOnlySpan<char>(_s, _currIndex, i);
                    if (span is "return" or "if" or "else" or "for" or "while" or "func" or "break")
                    {
                        _currIndex += i;

                        return new Token(span.ToString(), KeywordCode);
                    }
                }
            }

            return null;
        }

        private Token LexIdentifiers()
        {
            var sb = new StringBuilder();
            while (_currIndex < _len && !IsStopIdentifierLexing(_s[_currIndex]))
            {
                sb.Append(_s[_currIndex]);
                _currIndex++;
            }

            return new Token(sb.ToString(), IdentifierCode);

            bool IsStopIdentifierLexing(char c)
            {
                var isOp = c == '+' || c == '-' || c == '*' || c == '/' || c == '%' || c == '(' || c == ')' || c == '=';
                var isWhiteSpace = c == ' ' || c == '\n' || c == '\t';
                var isNotAlphaNumericExtended = !(char.IsLetterOrDigit(c) || c == '_' || c == '$');

                return isOp || isWhiteSpace || isNotAlphaNumericExtended;
            }
        }

        bool LexBooleanIdentifierKeyword()
        {
            var token = LexBooleans();
            if (token is not null)
            {
                _current = token;

                return true;
            }

            token = LexKeywords();
            if (token is not null)
            {
                _current = token;

                return true;
            }

            token = LexIdentifiers();
            if (token is not null)
            {
                _current = token;

                return true;
            }

            return false;
        }
        
        public override Token Current
        {
            get 
            { 
                if (_wasFalse) 
                {
                    throw new InvalidOperationException();
                }
                
                return _current; 
            }
        }
    }
}