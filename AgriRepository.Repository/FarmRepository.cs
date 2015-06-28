using AgriCult.DAL;
using AgriRepository.Entities;
using AgriRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgriRepository.Repository
{
    public class FarmRepository : IFarmRepository
    {
        private AgriDbContext db = new AgriDbContext();
        public IEnumerable<Entities.Farm> GetFarms()
        {
            return db.Farms;
        }

        public Entities.Farm GetFarm(int farmID)
        {
            throw new NotImplementedException();
        }

        public void Add(Entities.Farm farm)
        {
            db.Farms.Add(farm);
            db.SaveChanges();
        }

        public void Update(Entities.Farm farm)
        {
            throw new NotImplementedException();
        }

        public void Delete(int farmID)
        {
            throw new NotImplementedException();
        }
    }
}
