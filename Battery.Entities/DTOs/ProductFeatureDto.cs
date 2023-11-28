using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battery.Entities.DTOs
{
    public class ProductFeatureDto : BaseDto
    {
        public int Id { get; set; }
        public double Icdeger { get; set; }
        public double Gerilim { get; set; }
        public bool Durum { get; set; }
        public int ProductId { get; set; }
    }
}
