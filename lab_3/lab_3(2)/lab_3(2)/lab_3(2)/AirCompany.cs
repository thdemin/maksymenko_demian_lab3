﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace AirCompany
{
    public class AirCompany
    {
        private List<Plane> planes;  //створюємо список літаків

        public long TotalCapacity
        {
            get
            {
                long totalCapacity = 0;                           //метод для отримання місткості літака

                foreach (var item in planes)
                    totalCapacity += item.Capacity;

                return totalCapacity;
            }
        }

        public long TotalCarrying
        {
            get
            {
                long totalCarrying = 0;

                foreach (var item in planes)
                    totalCarrying += item.Carrying;      //метод для отримання вантажопідйомності літака

                return totalCarrying;
            }
        }

        public AirCompany()
        {
            planes = new();
        }

        public void AddPlane(Plane plane)
        {
            planes.Add(plane);
        }

        public void GetAllPlanes()
        {
            foreach (var plane in planes)                     
                Console.WriteLine(plane.GetInformation());      //вивід отриманих літаків
        }


        //сортування літаків
        public void SortPlanes()
        {
            planes = planes.OrderByDescending(t => t.Range).ToList();     
            GetAllPlanes();
        }

        public Plane GetPlaneByRange(int bottom, int up)
        {
            foreach (var plane in planes)
                if (plane.FuelConsumption >= bottom && plane.FuelConsumption <= up)
                    return plane;

            return null;
        }
    }
}
