﻿using System;

namespace ObjectOrientedDesignPrinciples
{
    public class CallСommand
    {
        private ICommand command;

        public ICommand Command => command;

        public CallСommand(string command)
        {
            switch (command)
            {
                case "count types": this.command = new CountTypes(); break;

                case "count all": this.command = new CountAll(); break;

                case "average price": this.command = new AveragePrice(); break;

                case "average price type": this.command = new AveragePriceType(); break;

                default: Console.WriteLine("No such command"); break;
            }
        }
    }
}