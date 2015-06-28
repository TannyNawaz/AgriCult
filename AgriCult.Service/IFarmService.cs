using AgriRepository.Entities;
using AgriRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AgriCult.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFarmService" in both code and config file together.
    [ServiceContract]
    public interface IFarmService 
    {
        [OperationContract]
        [FaultContract(typeof(AgriCultSvcData))]

        IEnumerable<Farm> GetFarms();

        [OperationContract]
        Farm GetFarm(int farmID);

        [OperationContract]
        [FaultContract(typeof(AgriCultSvcData))]

        void Add(Farm farm);

        [OperationContract]
        void Update(Farm farm);

        [OperationContract]
        void Delete(int farmID);


    }
}
