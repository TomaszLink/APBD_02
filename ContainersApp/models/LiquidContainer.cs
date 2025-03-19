using ContainersApp.exceptions;

namespace ContainersApp.models;

public class LiquidContainer : Container, IHazardNotifier
{
    public LiquidContainer(double height, double weight, double deepness, double capacity) : base(ContainerType.LIQUID, height, weight, deepness, capacity)
    {
    }
    
    
    public override void LoadCargo(Cargo cargo)
    {
        double loadLimitNotification = cargo.Product.IsDangerous ? 0.5 : 0.9;
        if (cargo.Weight + this.CargoWeight > this.Capacity * loadLimitNotification)
        {
            this.sendNotification();
        }
        base.LoadCargo(cargo);
    }
    
    public void sendNotification()
    {
        Console.WriteLine("Safe capacity limit of liquid contained has been exceeded.");
    }
}