using System;

namespace AirCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            AirCompany airCompany = new();
            airCompany.AddPlane(new("перший"));
            airCompany.AddPlane(new("другий"));
            airCompany.AddPlane(new("третій"));
            airCompany.AddPlane(new("четвертий"));
            airCompany.AddPlane(new("п'ятий"));

            airCompany.GetAllPlanes();

            Console.WriteLine();

            //Рахуємо місткість
            Console.WriteLine("Загальна місткість: " + airCompany.TotalCapacity);

            //Рахуємо вантажопідйомність
            Console.WriteLine("Загальна вантажопідйомність: " + airCompany.TotalCarrying);

            //Сортування літаків за дальністю польотів
            Console.WriteLine();
            airCompany.SortPlanes();

            //Пошук літака
            Console.WriteLine();
            Console.WriteLine("Введіть через пробіл тільки дві межі, щоб знайти потрібний літак");
            string[] str = Console.ReadLine().Split(' ');

            if (str.Length != 2)
                Exeption();

            Plane plane = airCompany.GetPlaneByRange(int.Parse(str[0]), int.Parse(str[1]));
            if (plane == null)
                Console.WriteLine("У заданих межах не існує такого літака");
            else
                Console.WriteLine(plane.GetInformation());
        }

        static void Exeption()
        {
            throw new Exception(" введено некоректно");
        }
    }
}
