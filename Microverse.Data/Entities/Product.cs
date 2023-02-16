using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microverse.Data.Entities
{
    public class Product
    {
        public Product()
        {
            Categories = new HashSet<Category>();
            Images= new HashSet<Image>();
        }
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public decimal Pice { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<Image> Images { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModified { get; set; }

    }
}
