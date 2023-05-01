using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTV_Monitoring
{
    public class UpdateRequest
    {
        public string Host { get; set; }
        public int Id { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public int TimeOut { get; set; }
        public string Type { get; set; }
    }
}
