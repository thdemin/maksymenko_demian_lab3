using System;
namespace AirCompany
{
    public interface IPlane
    {

        //конструктури характеристик літаків
        int Capacity { get; set; }  
        int Carrying { get; set; }
        int Range { get; set; }
        float FuelConsumption { get; set; }

        string GetInformation();
    }
}
