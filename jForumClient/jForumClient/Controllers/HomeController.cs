using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using jForumClient.Models;
using jForumClient.Logic;
using jForumClient.Data;

namespace jForumClient.Controllers
{
    public class HomeController : Controller
    {
        ForumRepository repository = new ForumRepository(new ForumApiContext());

        public ActionResult Index()
        {
            return View(repository.Read(1));
        }
    }
}