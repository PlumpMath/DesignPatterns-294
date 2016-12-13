using System;
using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Producer
    {
        private IMainProduct _mainProduct;
        private ISecondryProduct _seconderyProduct;
        public Producer(IFactory factory)
        {
            _mainProduct = factory.CreateMainProduct();
            _seconderyProduct = factory.CreateSeconderyProduct();
        }
        public void Produce()
        {
            _mainProduct.DependsOn(_seconderyProduct);
        }
    }
}