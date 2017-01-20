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
    public class TopicController : Controller
    {
        TopicRepository repository = new TopicRepository(new TopicApiContext());

        public ActionResult Index(int id, int page = 1)
        {
            ViewBag.Items = 10;
            ViewBag.Page = page;

            int start = (page - 1) * ViewBag.Items;
            int stop = start + ViewBag.Items;

            TopicModel topic = repository.Read(id, start, stop);
            if (topic == null)
            {
                throw new HttpException(404, "Topic could not be found.");
            }
            topic.Id = id;
            return View(topic);
        }
    }
}