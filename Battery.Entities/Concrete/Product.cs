using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battery.Entities.Concrete
{
    public class Product : BaseEntity
    {
        public int CategoryId { get; set; }
        public string CellSerialNo { get; set; }
        public Category Category { get; set; }
        public ProductFeature ProductFeature { get; set; }
    }
}
