using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AgriRepository.Entities
{
    public enum FarmType
    {
        Agriculture,
        Dairy,
        Poultry,
        Fishing,
        Hatchery
    }
   
    [DataContract]
    public class Farm
    {
        public int Id { get; set; }
        
        [DataMember]
        public string FarmName { get; set; }

        [DataMember]
        public float FarmSize { get; set; }
        
        [DataMember]
        public string Specialization { get; set; }

        [DataMember]
        public FarmType FarmType { get; set; }

        [DataMember]
        public AgriAddress Location { get; set; }

        [DataMember]
        public Person Owner { get; set; }

        [DataMember]
        public string Comment { get; set; }
    }
}
