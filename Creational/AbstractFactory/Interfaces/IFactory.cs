namespace DesignPatterns.Creational.AbstractFactory.Interfaces
{
    public interface IFactory
    {
        IMainProduct CreateMainProduct();
        ISecondryProduct CreateSeconderyProduct();
    }
}