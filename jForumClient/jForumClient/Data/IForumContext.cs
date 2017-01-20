using jForumClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jForumClient.Data
{
    public interface IForumContext
    {
        ForumModel Read(int id);
    }
}