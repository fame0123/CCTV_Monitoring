using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Newtonsoft.Json;
using CCTV_Monitoring.Entities;

namespace CCTV_Monitoring
{
    
    public class APIRequester
    {
        //private static RestClient client = new
        //RestClient("https://jam.document.fish/version-test/api/1.1/obj");

        static string URL = "https://cctv-monitoring.bubbleapps.io/api/1.1/obj/";

        private static RestClient client = new RestClient(URL);

        static string BEARERTOKEN = "e6df45bfa03c4f0641e073eefe2680b7";

        public static void SendCCTV_Status(AppCheckAlertRequest postData)
        {
            var route = "appchecks";
            
            try 
            {
                var postRequest = new UpdateRequest()
                {
                    Id = postData.Id,
                    Host = postData.Host,
                    Status = postData.Status,
                    Location = postData.Location,
                    Name = postData.Name,
                    Type = postData.Type,
                    TimeOut = postData.TimeOut
                };

                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                RestRequest request = new RestRequest(route, Method.POST);

                request.AddJsonBody(postRequest);
                //client.AddDefaultHeader("Authorization", string.Format("Bearer {0}", BEARERTOKEN));
                //client.Execute(request);
                request.RequestFormat = RestSharp.DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", "Bearer " + BEARERTOKEN);
                client.Execute(request);
                //client.ExecuteAsync(request);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public static void Update_CCTV_Status(AppCheckAlertRequest postData, string uniqueId)
        {
            var route = $"appchecks/{uniqueId}";//1673686040029x354955890590791230";

            try
            {
                var postRequest = new UpdateRequest()
                {
                    Id = postData.Id,
                    Host = postData.Host,
                    Status = postData.Status,
                    Location = postData.Location,
                    Name = postData.Name,
                    Type = postData.Type,
                    TimeOut = postData.TimeOut
                };

                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                RestRequest request = new RestRequest(route, Method.PUT);

                request.AddJsonBody(postRequest);
                request.RequestFormat = RestSharp.DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", "Bearer " + BEARERTOKEN);
                client.Execute(request);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Get All Data Base on Location
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="count"></param>
        /// <param name="location"></param>
        /// <returns></returns>
        public static Response GetAll_CCTV_Status(int cursor, int count, string location)
        {
            string convertToUrl = "[{\"constraint_type\":\"equals\",\"value\":\""+ location + "\",\"key\":\"location\"}]";
            var encodedParam = System.Web.HttpUtility.UrlEncode(convertToUrl);
            var route = $"appchecks?cursor={cursor}&count={count}&constraints={encodedParam}";

            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                RestRequest request = new RestRequest(route, Method.GET);

                var response = client.Execute<GetAllAppCheckResponse>(request);

                var deserializedAppChecks = JsonConvert.DeserializeObject<GetAllAppCheckResponse>(response.Content);
          
                return deserializedAppChecks.response;
           
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
                throw new ArgumentException();
            }

        }

        /// <summary>
        /// Get spicific data
        /// </summary>
        /// <param name="location"></param>
        /// <param name="host"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static AppCheckResult Get_CCTV_Status(string location,string host, string name)
        {
            var filterLocation = "{\"constraint_type\":\"equals\",\"value\":\"" + location + "\",\"key\":\"location\"}";
            var filterHost = "{\"constraint_type\":\"equals\",\"value\":\"" + host + "\",\"key\":\"host\"}";
            var filterName = "{\"constraint_type\":\"equals\",\"value\":\"" + name + "\",\"key\":\"name\"}";

            string convertToUrl = $"[{filterLocation},{filterHost},{filterName}]";
            var encodedParam = System.Web.HttpUtility.UrlEncode(convertToUrl);
            var route = $"appchecks?constraints={encodedParam}";

            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                RestRequest request = new RestRequest(route, Method.GET);

                var response = client.Execute<GetAppCheckRespones>(request);

                //var deserializedAppChecks = JsonConvert.DeserializeObject<GetAllAppCheckResponse>(response.Content);
                AppcCheckRoot deserializedAppChecks = JsonConvert.DeserializeObject<AppcCheckRoot>(response.Content);
                return deserializedAppChecks.response.results.FirstOrDefault();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                throw new ArgumentException();
            }

        }
    }
}
