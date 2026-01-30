using lab3.Database;
using System.Text.Json;
using zadanie8;

//var carsPath = Path.Combine(Directory.GetCurrentDirectory(), "cars.json");
//var bikesPath = Path.Combine(Directory.GetCurrentDirectory(), "bikes.json");
//var carsJson = File.ReadAllText(carsPath);
//var cars = JsonSerializer.Deserialize<List<Car>>(carsJson);

//var bikesJson = File.ReadAllText(bikesPath);
//var bikes = JsonSerializer.Deserialize<List<Bike>>(bikesJson);

//List<Vehicle> Vehicles()
//{
//    var list = new List<Vehicle>();
//    list.AddRange(cars);
//    list.AddRange(bikes);
//    return list;
//}
var db = new CarsDb();

bool run = true;
do
{
    Console.WriteLine("Welcome to the Car Shop");
    Console.WriteLine("[1] Show all, [2] Search by year, [3] Search by model, [4] Search by engine capacity, [5] Add new vehicle, [0] Exit");
    var input = Console.ReadKey().KeyChar;
    Console.WriteLine();

    switch (input)
    {
        case '1':
            DisplayVehicleModel();
            break;
        case '2':
            SearchByYear();
            break;
        case '3':
            SearchByModel();
            break;
        case '4':
            SearchByEngineCapacity();
            break;
        case '5':
            AddNewVehicle();
            break;
        case '0':
            run = false;
            break;
        default:
            Console.WriteLine("Invalid menu option");
            break;
    }
   
} while (run);
Console.WriteLine("Goodbye...");

void DisplayVehicleModel()
{
    Console.WriteLine("Our vehicles");
    foreach (var vehicle in db.Vehicles)
    {
        Console.WriteLine(vehicle.Model);
    }
}
void SearchByYear()
{
    Console.Write("Enter year: ");
    var success = Int32.TryParse(Console.ReadLine(), out int year);
    if (!success)
    {
        Console.WriteLine("Invalid year");
        SearchByYear();
        return;
    }
    var vehicles = db.Vehicles.Where(veh => veh.Year == year);
    if (!vehicles.Any())
    {
        Console.WriteLine("No vehicles found");
    }
    else
    {

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle.Model);
        }

    }
}
void SearchByModel()
{
    Console.Write("Enter model: ");
    string? model = Console.ReadLine();
    if (String.IsNullOrEmpty(model))
    {
        Console.WriteLine("Invalid model");
        SearchByModel();
        return;
    }
    model = model.ToLower().Trim();
    var vehicles = db.Vehicles.Where(veh => veh.Model.ToLower() == model);
    if (!vehicles.Any())
    {
        Console.WriteLine("No vehicles found");
    }
    else
    {

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle.Model);
        }

    }
}
void SearchByEngineCapacity()
{
    Console.Write("Enter engine capacity: ");
    var success = double.TryParse(Console.ReadLine(), out double engineCapacity);
    if (!success)
    {
        Console.WriteLine("Invalid engine capacity");
        SearchByEngineCapacity();
        return;
    }
    var vehicles = db.Vehicles.Where(veh => veh.EngineCapacity == engineCapacity);
    if (!vehicles.Any())
    {
        Console.WriteLine("No vehicles found");
    }
    else
    {

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle.EngineCapacity);
        }

    }
}
void AddNewVehicle()
{
    Console.WriteLine("B for bike, C for Car");
    var input = Console.ReadKey().KeyChar;
    if (input.ToString().ToLower() is not ("b" or "c"))
    {
        Console.WriteLine("Invalid vehicle type");
        return;
    }

    Console.WriteLine("Enter engine capacity: ");
    var success = double.TryParse(Console.ReadLine(), out double engineCapacity);

    if (!success)
    {
        Console.WriteLine("Invalid engine capacity");
        return;
    }
    Console.WriteLine("Enter model: ");
    string? model = Console.ReadLine();
    if (string.IsNullOrEmpty(model))
    {
        Console.WriteLine("Invalid model");
        return;
    }
    Console.WriteLine("Enter year: ");
    success = Int32.TryParse(Console.ReadLine(), out int year);
    if (!success)
    {
        Console.WriteLine("Invalid year");
        SearchByYear();
        return;
    }
 
    if (input=='c')
    {
        var v = new Car(engineCapacity, model, year);
        db.Cars.Add(v);
    }
    else
    {
        db.Bikes.Add(new Bike (engineCapacity, model, year));
    }
   db.SaveChanges();
}