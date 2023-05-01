using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTV_Monitoring
{
    public class AppCheckAlerts
    {
        public int Id { get; set; }
        public int CheckId { get; set; }
        public string Type { get; set; }
        public string Comparison { get; set; }
        public string ComparisonLimit { get; set; }
        public int Occurrences { get; set; }
        public string Contact { get; set; }
        public int Status { get; set; }
    }
}
