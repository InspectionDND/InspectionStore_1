﻿using System.ComponentModel.DataAnnotations;

namespace deneme.Models
{
    public class RegionalManager:Person
    {
        
        public int Id { get; set; }

        public Market Market { get; set; }

        public int MarketId { get; set; }
    }
}