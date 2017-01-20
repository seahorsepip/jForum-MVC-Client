using jForumClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jForumClient.Data
{
    public interface ITopicContext
    {
        TopicModel Read(int id, int start = 0, int stop = int.MaxValue);
    }
}