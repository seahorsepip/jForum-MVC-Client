using jForumClient.Data;
using jForumClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jForumClient.Logic
{
    public class TopicRepository
    {
        ITopicContext context;

        public TopicRepository(ITopicContext context)
        {
            this.context = context;
        }

        public TopicModel Read(int id, int start = 0, int stop = int.MaxValue)
        {
            return context.Read(id, start, stop);
        }
    }
}