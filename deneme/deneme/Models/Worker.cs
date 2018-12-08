using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace deneme.Models
{
    public class Worker:Person
    {

        public Worker()
        {
            this.Markets = new HashSet<Market>();
        }

        
        public int Id { get; set; }

        public byte Age { get; set; }

        public char Gender { get; set; }
     
        public string CarNumber { get; set; }

        public string RTcode { get; set; }

        public byte TravelExpenses { get; set; }

        public virtual ICollection<Market> Markets { get; set; }

    }
}