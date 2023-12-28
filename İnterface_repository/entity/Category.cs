using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace İnterface_repository.entity
{
    public class Category : IEntitiy
    {
        public int Id { get; set; }
        public string name { get; set; } = String.Empty;
    }
}