using System;
using System.Data.Entity;
using System.Linq;

namespace DAL.Data
{
    public class Payroll : DbContext
    {
        // Your context has been configured to use a 'Payroll' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DAL.Data.Payroll' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Payroll' 
        // connection string in the application configuration file.
        public Payroll()
            : base()
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public DbSet<Model.Employee> Employees { get; set; }
    }

   

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}