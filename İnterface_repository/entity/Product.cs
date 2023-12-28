using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace İnterface_repository.entity
{
    public class Product : IEntitiy
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public double Price { get; set; }
    }
}