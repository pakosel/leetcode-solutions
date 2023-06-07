using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace DesignParkingSystem
{
    public class ParkingSystem
    {
        int[] parking;
        public ParkingSystem(int big, int medium, int small)
        {
            parking = new int[3] { big, medium, small };
        }

        public bool AddCar(int carType)
        {
            return --parking[carType - 1] >= 0;
        }
    }
}