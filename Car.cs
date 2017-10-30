using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChapOneAlgorithms
{
    public class Car
    {
        public string Model { get; set; }
        public CarType TypeOfCar { get; set; }
        public enum CarType
        {
            SUV,
            Salon,
            FourWheel,
            Coupe
        }
    }
}
