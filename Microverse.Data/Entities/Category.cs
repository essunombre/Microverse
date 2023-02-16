using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microverse.Data.Entities
{
    public class Category
    {
        public Category() 
        {
            Products= new HashSet<Product>();
        }
        public Guid ID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModified { get; set; }

        public ICollection<Product> Products { get; set;}

    }
}
