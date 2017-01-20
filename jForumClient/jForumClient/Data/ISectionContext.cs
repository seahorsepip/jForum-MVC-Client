using jForumClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jForumClient.Data
{
    public interface ISectionContext
    {
        SectionModel Read(int id);
    }
}