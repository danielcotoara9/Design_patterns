using System;
using Command.Version_1.Interfaces;

namespace Command.Version_1.Concrete_Commands
{
    public class LightDownCommand : ICommand
    {
        private readonly Light _light;

        public LightDownCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.Off();
            Console.WriteLine("LightDownCommand Stopped\n");
        }

        public void UnExecute()
        {
            _light.On();
        }
    }
}
