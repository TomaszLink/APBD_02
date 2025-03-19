using ContainersApp.exceptions;
using ContainersApp.models;


Product bananasProduct = new Product("Bananas", 7, false);
Product pastaProduct = new Product("Pasta", 20, false);

CollingContainer collingContainer = null;

try
{
    collingContainer = new CollingContainer(50, 50, 50, 100, bananasProduct, 5);
}
catch (WrongTemperatureException e)
{
    Console.WriteLine("Cooling container has wrong temperature comparing to product required one");
}

collingContainer = new CollingContainer(50, 50, 50, 100, bananasProduct, 7);

Cargo pastaCargo = new Cargo(pastaProduct, 110);

try
{
    collingContainer.LoadCargo(pastaCargo);
}
catch (WrongCargoProductException ex)
{
    Console.WriteLine("Cargo has product imcompatible with cooling container product type");
}

Cargo bananasCargo = new Cargo(bananasProduct, 110);

try
{
    collingContainer.LoadCargo(bananasCargo);
}
catch (OverfillException ex)
{
    Console.WriteLine("There is more cargo then container capacity");
}

Cargo bananasCargo2 = new Cargo(bananasProduct, 50);

collingContainer.LoadCargo(bananasCargo2);

Console.WriteLine("Cargo weight: " + collingContainer.CargoWeight);

Cargo bananasCargo3 = new Cargo(bananasProduct, 40);

collingContainer.LoadCargo(bananasCargo3);

Console.WriteLine("Cargo weight: " + collingContainer.CargoWeight);



LiquidContainer liquidContainer = new LiquidContainer(50, 50, 50, 100);
Product product = new Product("Petrol", 0, true);
Cargo petrolCargo = new Cargo(product, 60);

liquidContainer.LoadCargo(petrolCargo);

liquidContainer.EmptyCargo();

Product milkProduct = new Product("Milk", 0, false);
Cargo milkCargo = new Cargo(milkProduct, 95);

liquidContainer.LoadCargo(milkCargo);

GasContainer gasContainer = new GasContainer(50, 50, 50, 100, 30);
Product gasProduct = new Product("Gas", 0, false);
Cargo gasCargo = new Cargo(gasProduct, 150);

try
{
    gasContainer.LoadCargo(gasCargo);
}
catch (OverfillException ex)
{
    Console.WriteLine("There is more cargo then container capacity");

}

Cargo gasCargo2 = new Cargo(gasProduct, 100);
gasContainer.LoadCargo(gasCargo2);
Console.WriteLine(gasContainer.CargoWeight == 100);
gasContainer.EmptyCargo();
Console.WriteLine(gasContainer.CargoWeight == 5);
