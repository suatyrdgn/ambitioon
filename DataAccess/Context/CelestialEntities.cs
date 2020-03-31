using DataAccess.StrategyPatterm;
using Model.Entities;
using Model.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class CelestialEntities:DbContext
    {
        public CelestialEntities():base("CelestialEntitiesCon")
        {
            //Database.Connection.ConnectionString = "server=DESKTOP-3R3PF25\\LOCALHOST;database=CelestialDB;uid=sa;pwd=123";
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CelestialObject> CelestialObjects { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            Database.SetInitializer<CelestialEntities>(new MyStrategy());

            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new CelestialMap());
            modelBuilder.Configurations.Add(new LogMap());
            modelBuilder.Configurations.Add(new UserMap());

            base.OnModelCreating(modelBuilder);

        }
    }
}
