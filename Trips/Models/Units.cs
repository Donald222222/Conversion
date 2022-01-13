using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interview_Asseement.Models
{
    public class Units
    {
        public int Id { get; set; }
        public double Temperature { get; set; }
        public decimal  length { get; set; }
        public decimal Area { get; set; }
        public double TemperatureConversiomRate { get; set; }
        public int ToCecious { get; set; }
        public double DistanceConversiomRetes { get; set; }
        public double  AreaConverstionRate { get; set; }
        public void ConvertTemperature()

        {
            double conveted = TemperatureConversiomRate * Temperature + ToCecious;
            this.Temperature = conveted;

        }

        public void ConvertArea()

        {
            double conveted = AreaConverstionRate * Convert.ToDouble(Area);
            this.Area = (decimal)conveted;

        }
        public void Converlength()

        {
            double conveted = DistanceConversiomRetes * Convert.ToDouble(length) ;
            this.length = (decimal)conveted;
        }

    }
}
