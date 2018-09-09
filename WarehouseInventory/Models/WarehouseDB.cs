namespace WarehouseInventory.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class WarehouseDB : DbContext
    {
        // Your context has been configured to use a 'WarehouseDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WarehouseInventory.Models.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'WarehouseDB' 
        // connection string in the application configuration file.
        public WarehouseDB()
            : base("name=WarehouseDB")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

            public virtual DbSet<WarehouseItem> WarehouseItems { get; set; }
            public virtual DbSet<Location> Locations { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}