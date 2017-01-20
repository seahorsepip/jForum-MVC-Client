using jForumClient.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jForumClient.Data
{
    public class ForumApiContext :IForumContext
    {
        RestClient client = new RestClient("http://localhost:6135/");

        public ForumModel Read(int id)
        {
            var request = new RestRequest("forum/{id}", Method.GET);
            request.AddUrlSegment("id", id.ToString());
            var response = client.Execute<ForumModel>(request);
            return response.Data;
        }
    }
}