using System;
using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.Computers
{
    public class ComputerFactory : IFactory
    {
        public IMainProduct CreateMainProduct()
        {
            return new Computer();
        }

        public ISecondryProduct CreateSeconderyProduct()
        {
            return new Keyboard();
        }
    }
}