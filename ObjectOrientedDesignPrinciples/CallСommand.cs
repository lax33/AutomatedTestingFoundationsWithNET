using System;
using System.Linq;

namespace ObjectOrientedDesignPrinciples
{
    public class CallСommand
    {
        private ICommand command;

        public ICommand Command => command;

        public CallСommand(string command)
        {
            string[] args = command.Split(' ').ToArray();

            if (args.Length == 3)  // for command "average price 'type'"
            {
                this.command = new AveragePriceTypes(args[2]);
            }
            else
            {
                switch (command)
                {
                    case "count types": this.command = new CountTypes(); break;

                    case "count all": this.command = new CountAll(); break;

                    case "average price": this.command = new AveragePriceAllCars(); break;

                    case "exit": this.command = new Exit(); break;

                    default: Console.WriteLine("No such command !"); break;
                }
            }
        }
    }
}