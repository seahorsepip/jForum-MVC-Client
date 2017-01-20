using jForumClient.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jForumClient.Data
{
    public class TopicApiContext :ITopicContext
    {
        RestClient client = new RestClient("http://localhost:6135/");
        public TopicModel Read(int id, int start = 0, int stop = int.MaxValue)
        {
            var request = new RestRequest("topic/{id}", Method.GET);
            request.AddUrlSegment("id", id.ToString());
            request.AddQueryParameter("start", start.ToString());
            request.AddQueryParameter("stop", stop.ToString());
            var response = client.Execute<TopicModel>(request);
            TopicModel topic = JsonConvert.DeserializeObject<TopicModel>(response.Content);
            if (topic.Posts != null)
            {
                topic.Posts.Data = JsonConvert.DeserializeObject<Dictionary<int, PostModel>>(topic.Posts.Data.ToString());
            }
            return topic;
        }
    }
}