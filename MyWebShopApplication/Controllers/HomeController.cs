using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebShopApplication.Helper;
using System.Net.Http;
using Newtonsoft.Json;
using MyWebShopApplication.Models;
using WebApiMyShop.Models;
using Newtonsoft.Json.Linq;

namespace MyWebShopApplication.Controllers
{
    public class HomeController : Controller
    {
        CustomerAPI customerAPI = new CustomerAPI();
        public async Task<IActionResult> Index()
        {

            List<Customer> listCustomer = new List<Customer>();
            try
            {
                HttpClient client = customerAPI.Initial();
                HttpResponseMessage res = await client.GetAsync("api/Customer");
                if (res.IsSuccessStatusCode)
                {
                    Console.WriteLine(res.ToString());
                    var result = res.Content.ReadAsStringAsync().Result;
                    listCustomer = JsonConvert.DeserializeObject<List<Customer>>(result);

                }
            }
            catch (Exception e) { }


            return View(listCustomer);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
