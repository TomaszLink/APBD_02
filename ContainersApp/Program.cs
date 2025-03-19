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
