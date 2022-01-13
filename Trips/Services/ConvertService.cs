using Interview_Asseement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Trips.Repository;

namespace Interview_Asseement.Services
{
    public class ConvertService : IMetricConversionService
    {
        private readonly Irepository _data;
      

        public ConvertService(Irepository data)
        {
            _data = data;
        }

      

        public IEnumerable <Units> ConvertTemperature()
        {

              //convert
      
        List< Units> metric =  _data.GetAll();
        


            for (int y = 0; y < metric.Count; y++)
              
                {
                metric[y].ConvertTemperature();

                //metric[y].ConvertArea();

                }
            return metric;
            
        }

        public IEnumerable<Units> Convertlength()
        {
            List<Units> metricss = _data.GetAll();

            for (int y = 0; y < metricss.Count; y++)

            {
                metricss[y].Converlength();

                

            }
            return metricss;
        }

        public IEnumerable<Units> ConvertArea()
        {
            List<Units> areas = _data.GetAll();

            for (int y = 0; y < areas.Count; y++)

            {
                areas[y].ConvertArea();

            }
            return areas; ;
        }
    }
} 
