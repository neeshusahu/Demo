using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class HomeController : ApiController
    {
       
      [Route("api/home/{id:int}")]
        public List<Details> GetByID(int id)
        {
            return new List<Details>
            {
                new Details { ID=1,owner="john",App="BAV"},

            };

        }
        [Route("api/home/")]
        public List<Details> GetAll()
        {
            return new List<Details>
            {
                new Details { ID=1,owner="john",App="BAV"},
                new Details { ID=2,owner="sam",App="TAMI"}
            };
        }

    }
}
