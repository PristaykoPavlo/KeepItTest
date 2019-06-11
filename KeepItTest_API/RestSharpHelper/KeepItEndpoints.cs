using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepItTest_API.RestSharpHelper
{
    class KeepItEndpoints : RestSharpClient
    {
        public KeepItEndpoints(string baseUrl) : base(baseUrl)
        {
         
        }

        public string GetUser()
        {
            var response = ExecuteApi(RestSharp.Method.GET, "users/zhc4v6-5ev7di-9hhhlm/tokens");
            return Deserialize(response);
        }
    }
}
