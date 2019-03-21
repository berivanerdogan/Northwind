using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.ORM.Entity
{
    public class CustomerCustomerDemo:BaseEntity
    {
        public List<Customer> Customers { get; set; }

        public List<CustomerDemographic>CustomerDemographics { get; set; }
       
    }
}
