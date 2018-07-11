using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Mvc;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class DetailsController : Controller
    {
        // GET: Details
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> GetDetails(int id)
        {
            List<Details> det = new List<Details>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:49371");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage rsp = await client.GetAsync("api/home/"+ id);
                if(rsp.IsSuccessStatusCode)
                {
                    var d = rsp.Content.ReadAsStringAsync().Result;
          det= JsonConvert.DeserializeObject<List<Details>>(d);


                }
                return PartialView(det);


            }
        }
    }
}