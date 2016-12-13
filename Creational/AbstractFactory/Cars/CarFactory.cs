using System;
using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.Cars
{
    public class CarFactory : IFactory
    {
        public IMainProduct CreateMainProduct()
        {
            return new Car();
        }

        public ISecondryProduct CreateSeconderyProduct()
        {
            return new Wheel();
        }
    }
}