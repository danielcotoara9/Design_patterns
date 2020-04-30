using System;
using Command.Version_1.Interfaces;

namespace Command.Version_1.Invokers
{
    public class Invoker
    {
        private ICommand _on;
        private ICommand _off;
        private ICommand _up;
        private ICommand _down;

        public Invoker(ICommand on, ICommand off, ICommand up, ICommand down)
        {
            _on = on;
            _off = off;
            _up = up;
            _down = down;
        }
        public void ClikOn()
        {
            Console.WriteLine("Invoking Click ON");
            _on.Execute();
        }
        public void ClikOff()
        {
            Console.WriteLine("Invoking Click Off");
            _off.Execute();
        }
        public void ClikUp()
        {
            Console.WriteLine("Invoking Click UP");
            _up.Execute();
        }
        public void ClikDown()
        {
            Console.WriteLine("Invoking Click Down");
            _down.Execute();
        }
    }
}
