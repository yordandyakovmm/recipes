﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Recipes.DAL
{
	
    public class RecipeDBContext : DbContext
    {

        public RecipeDBContext() : base("RecipeConnectionString")
        {
            Database.SetInitializer<RecipeDBContext>(null);
        }

        public DbSet<Users> Users { get; set; }

        //public DbSet<Form> Forms { get; set; }
        //public DbSet<Measure> Measures { get; set; }
        //public DbSet<Study> Studys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

}
