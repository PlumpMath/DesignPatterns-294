using System;
using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.Cars
{
    public class Wheel : ISecondryProduct
    {
        public string GetName()
        {
            return "Wheel";
        }
    }
}