using Interview_Asseement.Models;
using ProductsApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Trips.Repository
{
    public interface Irepository
    {
       List<Units> GetAll();
    }
}
