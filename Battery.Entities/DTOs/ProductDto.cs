using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battery.Entities.DTOs
{
    public class ProductDto  : BaseDto
    {
        public string? CellSerialNo { get; set; }
        public int CategoryName { get; set; }
    }
}
