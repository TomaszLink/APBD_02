namespace ContainersApp.models;

public class Cargo
{
    private Product product;
    private double weight;

    public Cargo(Product product, double weight)
    {
        this.product = product;
        this.weight = weight;
    }

    public Product Product => product;

    public double Weight => weight;
}