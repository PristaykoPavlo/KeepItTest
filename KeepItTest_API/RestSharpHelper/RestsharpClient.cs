using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace KeepItTest_API.RestSharpHelper
{
    class  RestSharpClient
    {
        private RestClient client;

        public RestSharpClient(string baseUrl)
        {
            client = new RestClient(baseUrl);
            client.CookieContainer = new CookieContainer();
        }

        public IRestResponse ExecuteApi(Method methodType, string endPoint)
        {
            var request = new RestRequest(endPoint, methodType);
            request.RequestFormat = DataFormat.Json;
            request.AddParameter
            ("application/json;charset=UTF-8", ParameterType.RequestBody);
            var response = client.Execute(request);
            return response;
        }

        public string Deserialize(IRestResponse response)
        {
            return JsonConvert.DeserializeObject<string>(response.Content);
        }
}
}
