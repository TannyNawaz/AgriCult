using AgriCult.DAL;
using AgriRepository.Entities;
using AgriRepository.Interfaces;
using AgriRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AgriCult.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FarmService" in both code and config file together.
    public class FarmService : IFarmService
    {
        private IFarmRepository repo;
        private AgriCultSvcData agriSvcData;
        public void CreatFarm()
        {
            repo = new FarmRepository();
            repo.Add( new Farm());
        }

        public IEnumerable<Farm> GetFarms()
        {
            agriSvcData = new AgriCultSvcData();

            try
            {
                agriSvcData.Result = true;
                repo = new FarmRepository();
                return repo.GetFarms();
            }
            catch (Exception Ex)
            {   
                //Log the exception
                agriSvcData.Result = false;
                agriSvcData.ErrorMessage = "Soemthing terrible happened. Please try later.";
                agriSvcData.ErrorDetails = Ex.ToString();
                throw new FaultException<AgriCultSvcData>(agriSvcData, Ex.ToString());
            }
        }

        public Farm GetFarm(int farmID)
        {
            throw new NotImplementedException();
        }

        public void Add(Farm farm)
        {
            agriSvcData = new AgriCultSvcData();

            try
            {

                repo = new FarmRepository();
                agriSvcData.Result = true;
                repo.Add(farm);
            }
            catch (Exception Ex)
            {
                //Log the exception
                agriSvcData.Result = false;
                agriSvcData.ErrorMessage = "Soemthing terrible happened. Please try later.";
                agriSvcData.ErrorDetails = Ex.ToString();
                throw new FaultException<AgriCultSvcData>(agriSvcData, Ex.ToString());
            }
        }

        public void Update(Farm farm)
        {
            throw new NotImplementedException();
        }

        public void Delete(int farmID)
        {
            throw new NotImplementedException();
        }
    }

    [DataContract]
    public class AgriCultFault
    {
        [DataMember]
        public bool Result { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public string Description { get; set; }
    }


    [Serializable]
    public class AgriCultException : Exception
    {
        public AgriCultException()
            : base() { }

        public AgriCultException(string message)
            : base(message) { }

        public AgriCultException(string format, params object[] args)
            : base(string.Format(format, args)) { }

        public AgriCultException(string message, Exception innerException)
            : base(message, innerException) { }

        public AgriCultException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }

        protected AgriCultException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}
