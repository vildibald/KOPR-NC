using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace KOPR_Indexovac_klient
{
    class RestRequestFactory
    {
        public static RestRequest newJsonRestRequest()
        {
            RestRequest restRequest = new RestRequest();
            restRequest.RequestFormat = DataFormat.Json;
            return restRequest;
        }

        public static RestRequest newJsonRestRequest(string resource, Method method)
        {
            RestRequest restRequest = new RestRequest(resource, method);
            restRequest.RequestFormat = DataFormat.Json;
            return restRequest;
        }
    }
}
