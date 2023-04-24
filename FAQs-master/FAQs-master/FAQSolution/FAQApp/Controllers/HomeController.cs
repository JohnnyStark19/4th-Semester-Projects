using FAQApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FAQApp.Controllers
{
    public class HomeController : Controller
    {
        private FAQContext context {  get; set; }

        //  Constructor
        public HomeController (FAQContext ctx)
        {
            context = ctx;
        }


        public IActionResult Index(string topic, string category)
        {
            ViewBag.Topics = context.Topics.OrderBy(t => t.TopicName).ToList();
            ViewBag.Categories = context.Categories.OrderBy(c => c.CategoryName).ToList();
            ViewBag.SelectedTopic = topic;

            IQueryable<FAQ> faqs = context.FAQs
                                          .Include(f => f.Topic)
                                          .Include(f => f.Category)
                                          .OrderBy(f => f.FAQQuestion);

            if (!string.IsNullOrEmpty(topic))
            {
                faqs = faqs.Where(f => f.TopicID == topic);
            }

            if (!string.IsNullOrEmpty(category))
            {
                faqs = faqs.Where(f => f.CategoryID == category);
            }

            return View(faqs.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}