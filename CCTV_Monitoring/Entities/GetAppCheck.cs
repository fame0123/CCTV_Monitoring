using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTV_Monitoring.Entities
{
    public class GetAppCheckRespones
    {
        public int cursor { get; set; }
        public List<AppCheckResult> results { get; set; }
        public int count { get; set; }
        public int remaining { get; set; }
    }

    public class AppCheckResult
    {
        public string Host { get; set; }
        public int Id { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public int TimeOut { get; set; }
        public string Type { get; set; }
        public string _id { get; set; }
    }

    public class AppcCheckRoot
    {
        public GetAppCheckRespones response { get; set; }
    }
}
