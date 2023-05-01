using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace CCTV_Monitoring
{
    
    public class Response
    {
        public int cursor { get; set; }
        public List<AppCheckAlertRequest> results { get; set; }
        public int count { get; set; }
        public int remaining { get; set; }
    }

   

    public class GetAllAppCheckResponse
    {
        public Response response { get; set; }
    }
}
//// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);