using jForumClient.Data;
using jForumClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jForumClient.Logic
{
    public class ForumRepository
    {
        IForumContext context;

        public ForumRepository(IForumContext context)
        {
            this.context = context;
        }

        public ForumModel Read(int id)
        {
            return context.Read(id);
        }
    }
}