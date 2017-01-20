using jForumClient.Data;
using jForumClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jForumClient.Logic
{
    public class SectionRepository
    {
        ISectionContext context;

        public SectionRepository(ISectionContext context)
        {
            this.context = context;
        }

        public SectionModel Read(int id)
        {
            return context.Read(id);
        }
    }
}