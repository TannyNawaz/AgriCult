using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AgriRepository.Entities
{
    [DataContract]
    public class AgriAddress
    {
        [DataMember]
        public int AgriAddressID { get; set; }

        [DataMember]
        public string Street { get; set; }

        [DataMember]
        public string Area { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public int ZipCode { get; set; }

        [DataMember]
        public string Country { get; set; }
    }
}
