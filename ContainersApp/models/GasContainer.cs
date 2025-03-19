namespace ContainersApp.models;

public class GasContainer : Container, IHazardNotifier
{
    public GasContainer(double height, double weight, double deepness, double capacity) : base(ContainerType.GAS, height, weight, deepness, capacity)
    {
    }
    
    public override void EmptyCargo()
    {
        this.cargoWeight = 0.05 * this.cargoWeight;
    }

    public void sendNotification()
    {
        Console.WriteLine("There is something dangerous in Gas Container: " + this.serialNumber);
    }
}