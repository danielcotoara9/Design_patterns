using System;
using Command.Version_1.Interfaces;

namespace Command.Version_1.Concrete_Commands
{
    public class LightUpCommand : ICommand
    {
        private readonly Light _light;

        public LightUpCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.Up();
            Console.WriteLine("LightUpCommand Started\n");
        }

        public void UnExecute()
        {
            _light.Down();
        }
    }
}
