using Interview_Asseement.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace ProductsApi.Data
{
    public class ContextData : DbContext
    {
        public ContextData(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Units> Values { get; set; }
      
    }

}
