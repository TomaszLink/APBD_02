namespace ContainersApp.models;

public class Ship
{
    private List<Container> containers;
    private double maxSpeed;
    private double maxContainersCount;
    private double maxContainersWeight;

    public Ship(double maxSpeed, double maxContainersCount, double maxContainersWeight)
    {
        this.containers = new List<Container>();
        this.maxSpeed = maxSpeed;
        this.maxContainersCount = maxContainersCount;
        this.maxContainersWeight = maxContainersWeight;
    }


    public void AddContainer(Container container)
    {
        this.containers.Add(container);
    }
    

    public void AddContainers(List<Container> containers)
    {
        this.containers.AddRange(containers);
    }
    

    public void RemoveContainer(Container container)
    {
        this.containers.Remove(container);
    }
    
    
    public void RemoveContainer(String serialNumber)
    {
        Container found = this.containers.Find(item => item.SerialNumber.Equals(serialNumber));
        if (found != null)
        {
            this.containers.Remove(found);
        }
        else
        {
            Console.WriteLine("Container " + serialNumber + " not found");
        }
    }
    


    public void Replace(string serialNumber, Container container)
    {
        this.RemoveContainer(serialNumber);
        this.AddContainer(container);
    }


    public static void Transfer(string serialNumber, Ship shipFrom, Ship shipTo)
    {
        Container container = shipFrom.RemoveAndGetContainer(serialNumber);
        if (container != null)
        {
            shipTo.AddContainer(container);
        }
        else
        {
            Console.WriteLine("Container " + serialNumber + " not found");
        }
    }


    public void ShowInfo()
    {
        Console.WriteLine("Ship Info: max speed: " + this.maxSpeed + ", max container count: " + this.maxContainersCount +  ", max container weight: " + this.maxContainersWeight);
        foreach (Container container in this.containers)
        {
            Console.WriteLine("Ship Info: Load: " + container.SerialNumber);
        }
    }
    

    private Container RemoveAndGetContainer(String serialNumber)
    {
        Container found = this.containers.Find(item => item.SerialNumber.Equals(serialNumber));
        if (found != null)
        {
            this.containers.Remove(found);
        }
        return found;
    }
    
    
    
    
    
    
    
    
}