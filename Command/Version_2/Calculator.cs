using System;

namespace Command.Version_2
{
    /// <summary>
    /// The 'Receiver' class
    /// </summary>
    public class Calculator
    {
        private int _current = 0;
        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': _current += operand; break;
                case '-': _current -= operand; break;
                case '*': _current *= operand; break;
                case '/': _current /= operand; break;
            }
            
            Console.WriteLine("Current value = {0} (last value {1} {2})", _current, @operator, operand);
        }
    }
}
