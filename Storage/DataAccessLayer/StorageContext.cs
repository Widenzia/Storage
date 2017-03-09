using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Storage.DataAccessLayer
{
    public class StorageContext : DbContext
    {
        public StorageContext() : base("StorageContext")
        {

        }

        public DbSet<Models.Product> Products { get; set; }
    }
}