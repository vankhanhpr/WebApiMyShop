using Microsoft.AspNetCore.Mvc;
using MyWebShopApplication.Helper;
using MyWebShopApplication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApiMyShop.Models;

namespace MyWebShopApplication.Controllers
{

    public class CustomerController : Controller
    {
        CustomerAPI customerAPI = new CustomerAPI();
        public async Task<IActionResult> Cusstomer()
        {
            List<Customer> listCustomer = new List<Customer>();
            HttpClient client = customerAPI.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Customer").ConfigureAwait(false); ;

            if (res.IsSuccessStatusCode)
            {
                Console.WriteLine(res.ToString());
                var result = res.Content.ReadAsStringAsync().Result;
                listCustomer = JsonConvert.DeserializeObject<List<Customer>>(result);
            }

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
