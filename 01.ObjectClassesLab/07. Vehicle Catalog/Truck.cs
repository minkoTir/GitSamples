namespace _07._Vehicle_Catalog
{
    internal class Truck
    {
        public Truck(string brand, string model, int weight) 
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
        public string Brand {  get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
}
