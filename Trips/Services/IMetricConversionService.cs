using Interview_Asseement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Interview_Asseement.Services
{
    public interface IMetricConversionService 
    {  //could have used generic <t> to avoid duplicates
     IEnumerable<Units> ConvertTemperature();
        IEnumerable<Units> Convertlength();
        IEnumerable<Units> ConvertArea();

    }
}
