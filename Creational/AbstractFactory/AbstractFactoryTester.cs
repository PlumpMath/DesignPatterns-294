using DesignPatterns.Creational.AbstractFactory.Cars;
using DesignPatterns.Creational.AbstractFactory.Computers;

namespace DesignPatterns.Creational.AbstractFactory
{
    public static class AbstractFactoryTester
    {
        
        public static void TestAbstractFactory()
        {
            var carProducer = new Producer(new CarFactory());
            carProducer.Produce();

            var computerProducer = new Producer(new ComputerFactory());
            computerProducer.Produce();
        }
    }
}