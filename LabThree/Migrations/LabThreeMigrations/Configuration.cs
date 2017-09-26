namespace LabThree.Migrations.LabThreeMigrations
{
    using LabThree.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LabThree.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\LabThreeMigrations";
        }

        protected override void Seed(LabThree.Models.ApplicationDbContext context)
        {

            context.ProvinceTable.AddOrUpdate(t => t.ProvinceCode,
                    getProvinces().ToArray()
                );

            context.SaveChanges();

            context.CityTable.AddOrUpdate(t => t.CityId,
                getCities(context).ToArray()
            );

            context.SaveChanges();
        }

        private List<Province> getProvinces()
        {
            List<Province> provinces = new List<Province>()
            {
                new Province()
                {
                    ProvinceCode = "BC",
                    ProvinceName = "British Columbia"
                },
                new Province()
                {
                    ProvinceCode = "QB",
                    ProvinceName = "Quebec"
                },
                 new Province()
                {
                    ProvinceCode = "ON",
                    ProvinceName = "Ontario"
                },
            };

            return provinces;
        }

        private List<City> getCities(ApplicationDbContext context)
        {
            List<City> cities = new List<City>()
            {
                new City() {
                    CityId = 1,
                    CityName = "Vancouver",
                    Population = 1000,
                    // TeamId = context.Teams.FirstOrDefault(t => t.Name == "Oilers").TeamId
                    ProvinceCode = context.ProvinceTable.FirstOrDefault (t => t.ProvinceCode == "BC").ProvinceCode
                },
                 new City() {
                    CityId = 2,
                    CityName = "Burnaby",
                    Population = 1000,
                    // TeamId = context.Teams.FirstOrDefault(t => t.Name == "Oilers").TeamId
                    ProvinceCode = context.ProvinceTable.FirstOrDefault (t => t.ProvinceCode == "BC").ProvinceCode
                },
                  new City() {
                    CityId = 3,
                    CityName = "Abbotsford",
                    Population = 1000,
                    // TeamId = context.Teams.FirstOrDefault(t => t.Name == "Oilers").TeamId
                    ProvinceCode = context.ProvinceTable.FirstOrDefault (t => t.ProvinceCode == "BC").ProvinceCode
                },
                   new City() {
                    CityId = 4,
                    CityName = "Quebec City",
                    Population = 1000,
                    // TeamId = context.Teams.FirstOrDefault(t => t.Name == "Oilers").TeamId
                    ProvinceCode = context.ProvinceTable.FirstOrDefault (t => t.ProvinceCode == "QB").ProvinceCode
                },
                    new City() {
                    CityId = 5,
                    CityName = "Montreal",
                    Population = 1000,
                    // TeamId = context.Teams.FirstOrDefault(t => t.Name == "Oilers").TeamId
                    ProvinceCode = context.ProvinceTable.FirstOrDefault (t => t.ProvinceCode == "QB").ProvinceCode
                },
                 new City() {
                    CityId = 6,
                    CityName = "Candy Land",
                    Population = 1000,
                    // TeamId = context.Teams.FirstOrDefault(t => t.Name == "Oilers").TeamId
                    ProvinceCode = context.ProvinceTable.FirstOrDefault (t => t.ProvinceCode == "QB").ProvinceCode
                },
                 new City() {
                    CityId = 7,
                    CityName = "TreVarieous",
                    Population = 1000,
                    // TeamId = context.Teams.FirstOrDefault(t => t.Name == "Oilers").TeamId
                    ProvinceCode = context.ProvinceTable.FirstOrDefault (t => t.ProvinceCode == "ON").ProvinceCode
                },
                 new City() {
                    CityId = 8,
                    CityName = "Shawgan",
                    Population = 1000,
                    // TeamId = context.Teams.FirstOrDefault(t => t.Name == "Oilers").TeamId
                    ProvinceCode = context.ProvinceTable.FirstOrDefault (t => t.ProvinceCode == "ON").ProvinceCode
                },
                 new City() {
                    CityId = 9,
                    CityName = "England is my city",
                    Population = 1000,
                    // TeamId = context.Teams.FirstOrDefault(t => t.Name == "Oilers").TeamId
                    ProvinceCode = context.ProvinceTable.FirstOrDefault (t => t.ProvinceCode == "ON").ProvinceCode
                },
            };

            return cities;
        }
    }
}
