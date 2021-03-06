﻿using SupermarketDomainDtos;


namespace Supermarket.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DeparnmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
