using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LKS_Hotel_API_4.Models;

namespace LKS_Hotel_API_4.Controllers
{
    public class FDController : ApiController
    {
        [HttpGet]
        public DataTable GetData()
        {
            string com = "select id, price, name from foodsAndDrinks";
            return Command.data(com);
        }
    }
}
