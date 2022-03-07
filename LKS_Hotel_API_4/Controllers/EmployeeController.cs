using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Web.Http;
using LKS_Hotel_API_4.Models;

namespace LKS_Hotel_API_4.Controllers
{
    public class EmployeeController : ApiController
    {
        LKS_Hotel_4Entities row = new LKS_Hotel_4Entities();

        string encrypt(string s)
        {
            using (SHA256Managed managed = new SHA256Managed())
            {
                byte[] b = managed.ComputeHash(Encoding.UTF8.GetBytes(s));
                return Convert.ToBase64String(b);
            }
        }

        [HttpPost]
        public IHttpActionResult post([FromBody] EmployeeModel model)
        {
            string sql = "select * from employee where username = '" + model.username + "' and password = '" + encrypt(model.password) + "'";
            var user = row.employees.SqlQuery(sql).FirstOrDefault();
            if(user != null)
            {
                EmployeeModel e = new EmployeeModel();
                e.id = user.id;
                e.name = user.name;
                e.username = user.username;

                return Ok(e);
            }

            return null;
        }
    }
}
