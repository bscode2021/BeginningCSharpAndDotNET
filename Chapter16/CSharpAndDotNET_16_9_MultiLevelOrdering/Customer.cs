using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAndDotNET_16_9_MultiLevelOrdering
{
    internal class Customer
    {
        public string ID { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public decimal Sales { get; set; }
        public override string ToString()
        {
            return "ID: " + ID + " City: " + City +
            " Country: " + Country +
            " Region: " + Region +
            " Sales: " + Sales;
        }
    }
}
