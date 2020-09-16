using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace People.Autentication.DataContexts
{
    public class PeopleDataContext : DbContext
    {
        public PeopleDataContext() : base("PeopleConnectionString")
        {
            Database.SetInitializer<PeopleDataContext>(new DataContextInitialize());
        }

        public DbSet<Models.People> People { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Models.MappingPeople());
            base.OnModelCreating(modelBuilder);
        }
    }
    public class DataContextInitialize : DropCreateDatabaseIfModelChanges<PeopleDataContext>
    {
        protected override void Seed(PeopleDataContext context)
        {
            context.People.Add(new Models.People(0, "03934235220", "Herlison", "RO", 07, 07, 2001));
            context.SaveChanges();
            base.Seed(context);
        }
    }

}