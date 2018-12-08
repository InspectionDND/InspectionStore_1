using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace deneme.Models
{
    public enum Type
    {
        Discount = 1,
        SuperMarket
    }

    public class Market
    {
        public Market()
        {
            this.Workers = new HashSet<Worker>();
        }

        
        public int Id { get; set; }

        public string Name { get; set; }

        public string Adress { get; set; }

        public string Manager { get; set; }

        public Type Type { get; set; }

        public Location Location { get; set; }

        public int LocationId { get; set; }

        public DateTime CreateTime { get; set; }


        public virtual ICollection<Worker> Workers { get; set; }


    }
}