using ContainersApp.exceptions;

namespace ContainersApp.models;

public class CollingContainer : Container
{
    private Product product;
    private decimal temperature;
    public CollingContainer(double height, double weight, double deepness, double capacity, Product product, decimal temperature) : base(ContainerType.COOLING, height, weight, deepness, capacity)
    {
        if (temperature < product.Temperature)
        {
            throw new WrongTemperatureException();
        }
        this.product = product;
        this.temperature = temperature;
    }

    public override void LoadCargo(Cargo cargo)
    {
        if (!this.product.Id.Equals(cargo.Product.Id))
        {
            throw new WrongCargoProductException();
        }
        base.LoadCargo(cargo);
    }
}