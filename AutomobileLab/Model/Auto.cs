using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomobileLab.Model
{
    public class Auto
    {
        public long ID { get; set; }
        public string ModelName { get; set; }
        public string ModelType { get; set; }
        public DateTime ProductionYear { get; set; }
        public int BackPackType { get; set; }
        public decimal Price { get; set; }
    }
}
