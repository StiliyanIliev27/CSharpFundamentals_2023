namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            while (command != "end")
            {
                string[] commandInfo = command.Split("/");

                string type = commandInfo[0];
                string brand = commandInfo[1];
                string model = commandInfo[2];
                int value = int.Parse(commandInfo[3]);

                Catalog catalog = new Catalog();

                if (type == "Car")
                {
                    Car car = new Car();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = value;

                    cars.Add(car);

                }
                else if (type == "Truck")
                {
                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = value;

                    trucks.Add(truck);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Cars:");
            foreach (var car in cars.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            Console.WriteLine("Trucks:");
            foreach (var truck in trucks.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
    public class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }
    public class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }

    }
    public class Catalog
    {
        //public Catalog()
        //{
        //    List<Car> cars = new List<Car>();
        //    List<Truck> trucks = new List<Truck>();
        //}

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}