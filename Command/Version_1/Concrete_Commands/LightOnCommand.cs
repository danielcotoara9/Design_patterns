using System;
using Command.Version_1.Interfaces;

namespace Command.Version_1.Concrete_Commands
{
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.On();
            Console.WriteLine("LightOnCommand Started\n");
        }

        public void UnExecute()
        {
            _light.Off();
        }
    }
}
