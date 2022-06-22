using System;
namespace AirCompany
{
    public class Plane : IPlane
    {
        private readonly string Name;

        private int _capacity;
        private int _carrying;
        private int _range;
        private float _fuel;

        public int Capacity
        {
            get => _capacity;
            set => _capacity = value;
        }

        public int Carrying
        {
            get => _carrying;
            set => _carrying = value;
        }

        public int Range
        {
            get => _range;
            set => _range = value;
        }

        public float FuelConsumption
        {
            get => _fuel;
            set => _fuel = value;
        }

        public Plane(string name, int capacity, int carrying, int range, int fuel)  
        {
            Name = name;
            _capacity = capacity;
            _carrying = carrying;
            _range = range;
            _fuel = fuel;
        }

        public Plane(string name)           //метод надання характеристик літаку
        {
            Random rand = new();
            Name = name;
            _capacity = rand.Next(2, 100);
            _carrying = rand.Next(100, 10000);
            _range = rand.Next(1000, 20000);
            _fuel = rand.Next(20, 300);
        }

        public string GetInformation()
        {
            return $"Ім'я: {Name} | Місткість: {Capacity} | Вантажопідйомність: {Carrying} | Дальність польоту: {Range} | Споживання палива: {FuelConsumption}";
        }
    }
}
