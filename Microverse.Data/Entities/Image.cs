using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microverse.Data.Entities
{
    public class Image
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public bool IsMainImage { get; set; }
        public Product Product { get; set; }
        public Guid ProductID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastModified { get; set; }
    }
}
