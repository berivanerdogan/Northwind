using Northwind.DAL.ORM.Enum;
using Northwind.DAL.ORM.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.ORM.Entity
{
   public class BaseAdressInfo:IBaseEntity
    {
        public int ID { get; set; }

        private DateTime _adddate = DateTime.Now;
        public DateTime AddDate { get { return _adddate; } set { _adddate = value; } }

        private DateTime _delete = DateTime.Now;
        public DateTime Delete { get { return _delete; } set { _delete = value; } }

        private DateTime _update = DateTime.Now;
        public DateTime Update { get { return _update; } set { _update = value; } }

        private Status _status = Status.Active;
        public Status Status { get { return _status; } set { _status = value; } }


        [MaxLength(60)]
        public string Adress { get; set; }

        [MaxLength(15)]
        public string City { get; set; }

        [MaxLength(15)]
        public string Region { get; set; }

        [MaxLength(10)]
        public string PostalCode { get; set; }

        [MaxLength(15)]
        public string Country { get; set; }


    }
}
