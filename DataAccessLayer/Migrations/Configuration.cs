﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.Database>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "DataAccessLayer.Database";
        }

        protected override void Seed(DataAccessLayer.Database context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
