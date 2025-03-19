using ContainersApp.exceptions;

namespace ContainersApp.models;

public abstract class Container
{
    protected string serialNumber;
    protected double height;
    protected double weight;
    protected double deepness;
    protected double capacity;
    protected double cargoWeight;
    
    private static int last_serial_number = 0;
    private static string serial_number_prefix = "KON";

    public Container(ContainerType type, double height, double weight, double deepness, double capacity)
    {
        this.serialNumber = GenerateNewSerialNumber(type);
        this.height = height;
        this.weight = weight;
        this.deepness = deepness;
        this.capacity = capacity;
        this.cargoWeight = 0;
    }

    public string SerialNumber => serialNumber;

    public double Height => height;
    
    public double Weight => weight;

    public double Capacity => capacity;
    
    public double CargoWeight => cargoWeight;


    public virtual void LoadCargo(Cargo cargo)
    {
        if (cargo.Weight + this.cargoWeight > this.capacity)
            throw new OverfillException();
        this.cargoWeight += cargo.Weight;
    }

    public virtual void EmptyCargo()
    {
        this.cargoWeight = 0;
    }
    
    public void ShowInfo()
    {
        Console.WriteLine(this.serialNumber);
    }
    
    private string GenerateNewSerialNumber(ContainerType containerType)
    {
        string typeSymbol = containerType.GetSymbolOfContainerType();
        last_serial_number++;
        return serial_number_prefix + "-" + typeSymbol + "-" + last_serial_number;
    }
}