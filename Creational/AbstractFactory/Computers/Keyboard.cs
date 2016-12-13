using System;
using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.Computers
{
    public class Keyboard : ISecondryProduct
    {
        public string GetName()
        {
            return "Keyboard";
        }
    }
}