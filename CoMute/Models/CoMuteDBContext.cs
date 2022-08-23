using CoMute.Web.Models.Dto;
using System;
using System.Data.Entity;
using System.Linq;

namespace CoMute.Web.Models
{
    public class CoMuteDBContext : DbContext
    {
        // Your context has been configured to use a 'CoMuteDBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CoMute.Web.Models.CoMuteDBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CoMuteDBContext' 
        // connection string in the application configuration file.
        public CoMuteDBContext()
            : base("name=CoMuteDBContext")
        {

        }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder
        //        //.Entity<CarPool>()
        //        //.HasRequired(CarPool=>CarPool.ID)
        //        //.WithMany(CarPool=>CarPool.)
        //        //.HasForeignKey(p => p.)
        //        .Entity<CarPool>()
        //        .Has(CarPool => CarPool.RegistrationRequests)
        //       .WithMany(RegistrationRequests => RegistrationRequests.CarPool)
        //       // .Map(c =>
        //       // {
        //       //     c.ToTable("CarPool_Register_Map");
        //       //     c.MapLeftKey("CarPoolID");
        //       //     c.MapRightKey("ID");
        //       // });
       // }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<RegistrationRequest> RegistrationRequests { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<CarPool> CarPools { get; set; }

      

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}