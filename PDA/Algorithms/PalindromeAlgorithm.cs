namespace PDA.Algorithms
{
    internal class PalindromeAlgorithm : IAlgorithm
    {
        private readonly Stack<char> _letter = new Stack<char>();

        public bool CheckInput(string input)
        {
            int half = input.Length / 2;
            int index = 0;
            foreach(var letter in input)
            {
                index++;
                // odd
                if (input.Length % 2 != 0 && index == half + 1) 
                {
                    continue;
                }

                // 1st half
                if (index <= half)
                {
                    _letter.Push(letter);
                }

                // 2nd half
                else
                {
                    if (_letter.Peek() == letter)
                    {
                        _letter.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return _letter.Count == 0;
        }
    }
}
