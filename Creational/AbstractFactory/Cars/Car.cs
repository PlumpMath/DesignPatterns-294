using System;
using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.Cars
{
    public class Car : IMainProduct
    {
        public void DependsOn(ISecondryProduct product)
        {
            Console.WriteLine(GetName() + " depends on " + product.GetName());
        }

        public string GetName()
        {
            return "Car";
        }
    }
}