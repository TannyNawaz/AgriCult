using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AgriCult.DAL;
using AgriRepository.Entities;

namespace AgriCult.Tests
{
    [TestClass]
    public class DALTests
    {
        private AgriDbContext db = new AgriDbContext();
        [TestMethod]
        public void TestCreateFarmEntry()
        {
            Farm farm = new Farm
            {
                FarmName = "test Fam1",
                FarmSize = 10.0f,
                FarmType =  FarmType.Agriculture,
                Location = new AgriAddress { AgriAddressID = 1, Area = "etsfd", City = "Bangaore", Country = "India" },
                Comment = "tst Commens",
                Owner = new Person { Background = "fdfas", FirstName = "Jon", LastName = "snow" },
                Specialization = "agri"

            };
            db.Farms.Add(farm);
            db.SaveChanges();
        }
    }
}
