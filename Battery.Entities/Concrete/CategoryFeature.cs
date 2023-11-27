using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battery.Entities.Concrete
{
    public class CategoryFeature
    {
        public int Id { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Weight { get; set; }

        public Category Category { get; set; }

    }
}
