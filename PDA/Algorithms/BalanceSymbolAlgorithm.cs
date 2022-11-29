namespace PDA.Algorithms
{
    internal class BalanceSymbolAlgorithm : IAlgorithm
    {
        private readonly Stack<char> _symbols = new Stack<char>();

        /// <summary>
        /// Only accepts symbols
        /// </summary>
        /// <param name="input"></param>    
        /// <returns></returns>
        public bool CheckInput(string input)
        {
            foreach(var symbol in input)
            {
                // push
                if (symbol == '(' || symbol == '{' || symbol == '[')
                {
                    _symbols.Push(symbol);
                }

                // pop
                else if (symbol == ']' || symbol == '}' || symbol == ')')
                {
                    if (_symbols.Count != 0)
                    {
                        switch (symbol)
                        {
                            case ']':
                                if (_symbols.Peek() == '[')
                                    _symbols.Pop();
                                break;
                            case '}':
                                if (_symbols.Peek() == '{')
                                    _symbols.Pop();
                                break;
                            case ')':
                                if (_symbols.Peek() == '(')
                                    _symbols.Pop();
                                break;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return _symbols.Count == 0;
        }
    }
}
