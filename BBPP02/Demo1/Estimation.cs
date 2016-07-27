using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public class Estimation
    {
        public string Name { get; set; }
        public DateTime Created { get; set; }
        private readonly List<EstimationLine> _lines;
        public IEnumerable<EstimationLine> Lines { get { return _lines; } }

        public Estimation()
        {
            Created = DateTime.Now;
            _lines = new List<EstimationLine>();
        }
        public void AddLines(EstimationLine line)
        {
            _lines.Add(line);
        }
    }
}
