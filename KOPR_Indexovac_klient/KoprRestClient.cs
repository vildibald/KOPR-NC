using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace KOPR_Indexovac_klient
{
    class KoprRestClient : RestClient
    {
        public KoprRestClient(string baseUrl)
            : base(baseUrl)
        {
            //_restRequest = new RestRequest();
            //_restRequest.RequestFormat = DataFormat.Json;
        }

        //public Document findByGUID(Guid guid)
        //{
        //    Document document;
        //    _restRequest.Resource="/documents/byId/";
        //}
        public Guid addDocument(Document document)
        {
            RestRequest restRequest = RestRequestFactory.newJsonRestRequest("indexer/documents", Method.POST);

           // restRequest.Resource="indexer/documents";
           // restRequest.Method = Method.POST;
            restRequest.AddBody(document);
           // var guid = Execute<string>(_restRequest).Data;
            var response = Execute(restRequest);
            
            //return Guid.Empty;
            
            //Console.WriteLine("new GUID: " +response.Content);
            return new Guid(response.Content);
        }

        public List<Guid> findByString(string searchString)
        {
            searchString = searchString.Replace(' ','_');
            RestRequest restRequest =
                RestRequestFactory.newJsonRestRequest("indexer/documents/byString/"+searchString, Method.GET);
           // RestRequestFactory.newJsonRestRequest("indexer/documents/byString/{string}", Method.GET);
           // restRequest.Resource = "indexer/documents/byString/{string}";
           // restRequest.Method = Method.GET;
           // restRequest.AddParameter("string", searchString);

            var response = Execute<List<string>>(restRequest).Data;          
            var guids = new List<Guid>(response.Count);
            for (int i = 0; i < response.Count; ++i)
            {
                guids.Add(Guid.Parse(response[i]));
                //  Console.WriteLine("Response:"+response[i]);
            }
          
            return guids;
            
        }

        //public List<Guid> findByString(string searchString)
        //{
        //    _restRequest.Resource = "/documents/byString/{string}";
        //    _restRequest.Method = Method.GET;
        //    _restRequest.AddParameter("string", searchString);

        //    var response = Execute<List<string>>(_restRequest).Data;
        //    var guids = new List<Guid>(response.Count);

        //    for (int i = 0; i < guids.Count; ++i)
        //    {
        //        guids[i] = Guid.Parse(response[i]);
        //    }
        //    return guids;
        //}


        public List<Document> getDocumentsByUUIDs(string stringGUIDsForRestClient)
        {
            var stringGUIDs = stringGUIDsForRestClient.Replace(' ', '_');
            RestRequest restRequest =
                RestRequestFactory.newJsonRestRequest("indexer/documents/byIds/" + stringGUIDs, Method.GET);

            var response = Execute<List<Document>>(restRequest).Data;

            return response;
        }
    }
}
