using Recipes.DAL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Recipes.DAL.Migration
{

    internal sealed class Configuration : DbMigrationsConfiguration<RecipeDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RecipeDBContext context)
        {
            base.Seed(context);

        }
    }
}
