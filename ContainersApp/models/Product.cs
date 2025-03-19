namespace ContainersApp.models;

public class Product
{
    private String id;
    private string name;
    private decimal temperature;
    private bool isDangerous;

    public Product(string name, decimal temperature, bool isDangerous)
    {
        this.id = Guid.NewGuid().ToString();
        this.name = name;
        this.temperature = temperature;
        this.isDangerous = isDangerous;
    }

    public string Name => name;

    public decimal Temperature => temperature;

    public string Id => id;

    public bool IsDangerous => isDangerous;
}