using AgriRepository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgriRepository.Interfaces
{
    public interface IFarmRepository
    {
        IEnumerable<Farm> GetFarms();
        Farm GetFarm(int farmID);
        void Add(Farm farm);
        void Update(Farm farm);
        void Delete(int farmID);

    }
}
