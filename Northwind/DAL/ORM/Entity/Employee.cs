using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.ORM.Entity
{
    public class Employee : BaseAdressInfo
    {
        [MaxLength(20)]
        public string FirstName { get; set; }

        [MaxLength(30)]
        public string LastName { get; set; }

        [MaxLength(30)]
        public string Title { get; set; }
        [MaxLength(25)]
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }

        [MaxLength(24)]
        public string HomePhone { get; set; }

        [MaxLength(4)]
        public string Extension { get; set; }

        public string Note { get; set; }

       
        public int ReportsTo { get; set; }


        public int EmployeeID { get; set; }
        public virtual EmployeeTerritory EmployeeTerritory { get; set; }

        

       


    }

}