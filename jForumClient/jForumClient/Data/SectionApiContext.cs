using jForumClient.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jForumClient.Data
{
    public class SectionApiContext :ISectionContext
    {
        RestClient client = new RestClient("http://localhost:6135/");

        public SectionModel Read(int id)
        {
            var request = new RestRequest("section/{id}", Method.GET);
            request.AddUrlSegment("id", id.ToString());
            var response = client.Execute<SectionModel>(request);
            return response.Data;
        }
    }
}