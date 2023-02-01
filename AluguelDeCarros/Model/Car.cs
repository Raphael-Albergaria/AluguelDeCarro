namespace LocateCar.Model
{
    public class Car
    {
        public string Placa { get; set; } = null!;
        public string Brand { get; set; } = null!;
        public bool IsAvailable { get; set; } = true;

        public Car()
        {

        }

        public Car(string placa, string brand)
        {
            Placa = placa;
            Brand = brand;
        }
    }
}