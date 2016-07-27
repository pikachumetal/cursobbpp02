using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Model
{
    public class Estimation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public ICollection<EstimationLine> Lines { get; private set; }

        public Estimation()
        {
            Created = DateTime.Now;
            Lines = new List<EstimationLine>();
        }

        public void AddLines(EstimationLine line)
        {
            if(line == null)
            {
                throw new ArgumentNullException("line is null");
            }

            var existingLine = Lines.SingleOrDefault(l => l.Product.Id == line.Product.Id);
            if (existingLine != null)
            {
                existingLine.Quantity += line.Quantity;
            }
            else
            {
                Lines.Add(line);
            }
        }
    }
}
