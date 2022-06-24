using System;

namespace ObjectOrientedDesignPrinciples
{
    public class Exit : ICommand
    {
        public void ExecuteCom(Cars cars)
        {
            Environment.Exit(0);
        }

        public void Print()
        {
        }
    }
}