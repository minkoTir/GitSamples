namespace _07._Vehicle_Catalog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> listOfCars = new List<Car>();
            List<Truck> listOfTrucks = new List<Truck>();
            List<Catalog> Collection = new List<Catalog>();
            string input;

            while ((input = Console.ReadLine()!) != "end")
            {
                string[] infoOfVehicle = input.Split('/');
                string typeOfVehicle = infoOfVehicle[0];
                string brandOfVehicle = infoOfVehicle[1];
                string modelOfVehicle = infoOfVehicle[2];
                if (typeOfVehicle == "Car")
                {

                    int horsePower = int.Parse(infoOfVehicle[3]);
                    Car Car = new Car(brandOfVehicle, modelOfVehicle, horsePower);
                    listOfCars.Add(Car);
                }
                else if (infoOfVehicle[0] == "Truck")
                {
                    int weight = int.Parse(infoOfVehicle[3]);
                    Truck Truck = new Truck(brandOfVehicle, modelOfVehicle, weight);
                    listOfTrucks.Add(Truck);
                }
            }
            Console.WriteLine("Cars:");
            foreach (Car car in listOfCars.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            Console.WriteLine("Trucks:");
            foreach (Truck truck in listOfTrucks.OrderBy(x => x.Brand))
            {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }

        }
    }

   /* internal class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    internal class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    internal class Catalog
    {
        public Catalog(string collection)
        {
            Collection = collection;
        }
        public string Collection { get; set; }
    }*/
} 
