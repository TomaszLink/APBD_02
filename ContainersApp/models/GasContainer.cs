namespace ContainersApp.models;

public class GasContainer : Container, IHazardNotifier
{
    private double pressure;
    public GasContainer(double height, double weight, double deepness, double capacity, double pressure) : base(ContainerType.GAS, height, weight, deepness, capacity)
    {
        this.pressure = pressure;
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