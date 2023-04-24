using Microsoft.AspNetCore.Mvc;
using OrderForm.Models;

namespace OrderForm.Controllers
{
    public class HomeController : Controller
    { 
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.quantity = 0;
            ViewBag.messages = 0;
            ViewBag.shirt = 0;
            ViewBag.subtotal = 0;
            ViewBag.tax = 0;
            ViewBag.total = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(orderForm order)
        {
            if (ModelState.IsValid)
            {
                ViewBag.quantity = order.ReturnQuantity();
                ViewBag.messages = order.DiscountMessages();
                ViewBag.shirt = order.CalculatePricePerShirt();
                ViewBag.subtotal = order.CalculateSubtotal();
                ViewBag.tax = order.CalculateTax();
                ViewBag.total = order.CalculateTotal();
            }
            else
            {
                ViewBag.quantity = 0;
                ViewBag.messages = 0;
                ViewBag.shirt = 0;
                ViewBag.subtotal = 0;
                ViewBag.tax = 0;
                ViewBag.total = 0;
            }
            return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}