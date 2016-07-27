using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Model
{
    public class EstimationLine
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public long Quantity { get; set; }
    }
}
