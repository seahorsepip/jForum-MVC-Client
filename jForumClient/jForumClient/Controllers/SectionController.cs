using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using jForumClient.Logic;
using jForumClient.Data;
using jForumClient.Models;

namespace jForumClient.Controllers
{
    public class SectionController : Controller
    {
        SectionRepository repository = new SectionRepository(new SectionApiContext());

        public ActionResult Index(int id)
        {
            SectionModel section = repository.Read(id);
            if(section == null)
            {
                throw new HttpException(404, "Section could not be found.");
            }
            return View(section);
        }
    }
}