using Interview_Asseement.Models;
using ProductsApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Trips.Repository
{
    public class ValueRepository : Irepository
    {
        private readonly ContextData _data;

        public ValueRepository( ContextData data)
        {
            _data = data;
        }

        public List<Units> GetAll()
        {
            return _data.Values.ToList();
        }
    }
    
}
