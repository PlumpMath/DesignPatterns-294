namespace DesignPatterns.Creational.AbstractFactory.Interfaces
{
    public interface IMainProduct : IProduct
    {
        void DependsOn(ISecondryProduct product);
    }
}