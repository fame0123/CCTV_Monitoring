using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTV_Monitoring
{
    public class AppChecks
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string Common { get; set; }
        public string Type { get; set; }
        public string Port { get; set; }
        public string TimeOut { get; set; }
        public string Host { get; set; }
        public string Send { get; set; }
        public string Expect { get; set; }
        public int status { get; set; }
        public string GeoData { get; set; }
        public int OnMap { get; set; }
        public string Latitude { get; set; }
        public string tongitude { get; set; }
    }
}
