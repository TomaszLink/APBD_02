namespace ContainersApp.models;

public static class ContainersTypesHelper
{
    public static string GetSymbolOfContainerType(this ContainerType type)
    {
        return type switch
        {
            ContainerType.LIQUID => "L",
            ContainerType.GAS => "G",
            ContainerType.COOLING => "C",
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };
    }
}