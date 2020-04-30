using System;
using System.Collections.Generic;
using Command.Version_2.Concrete_Commands;

namespace Command.Version_2.Invoker
{
    /// <summary>
    /// The 'Invoker' class
    /// </summary>
    public class User
    {
        // Initializers
        private readonly Calculator _calculator = new Calculator();
        private IList<Abstractization.Command> _commands = new List<Abstractization.Command>();
        private int _current = 0;

        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Redo {0} levels ", levels);
            // Perform redo operations

            for (var i = 0; i < levels; i++)
            {
                if (_current < _commands.Count - 1)
                {
                    var command = _commands[_current++];
                    command.Execute();
                }
            }
        }
        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels ", levels);
            // Perform undo operations

            for (int i = 0; i < levels; i++)
            {
                if (_current > 0)
                {
                    var command = _commands[--_current];
                    command.UnExecute();
                }
            }
        }

        public void Compute(char @operator, int operand)
        {
            // Create command operation and execute it

            Abstractization.Command command = new CalculatorCommand(_calculator, @operator, operand);
            command.Execute();

            // Add command to undo list

            _commands.Add(command);
            _current++;
        }

    }
}
