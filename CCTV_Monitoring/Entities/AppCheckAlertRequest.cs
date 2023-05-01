using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTV_Monitoring
{
    public class AppCheckAlertRequest
    {
        [JsonProperty("Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [JsonProperty("Created Date")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty("Created By")]
        public string CreatedBy { get; set; }
        public string Host { get; set; }
        public int Id { get; set; }
        public string Location { get; set; } = "";
        public string Name { get; set; }
        public int Status { get; set; }
        public int TimeOut { get; set; }
        public string Type { get; set; }
        public string _id { get; set; }
    }
}
