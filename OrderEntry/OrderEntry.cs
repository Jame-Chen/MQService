using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MQModel
{
    [DataContract]
    public class OrderEntry
    {
        [DataMember]
        public int OrderID { get; set; }
        [DataMember]
        public DateTime OrderDate { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public int UnitPrice { get; set; }

        public override string ToString()
        {
            return string.Format(
                "ID:{0}\tDate:{1}\tQuantity:{2}\tUnitPrice:{3}\t",
                OrderID,
                OrderDate,
                Quantity,
                UnitPrice);
        }
    }
}
