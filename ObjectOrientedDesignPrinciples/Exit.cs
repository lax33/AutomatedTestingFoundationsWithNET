using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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