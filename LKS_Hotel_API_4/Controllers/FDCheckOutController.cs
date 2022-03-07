using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LKS_Hotel_API_4.Models;

namespace LKS_Hotel_API_4.Controllers
{
    public class FDCheckOutController : ApiController
    {
        SqlConnection connection = new SqlConnection(Utils.conn);
        SqlCommand command;

        [HttpPost]
        public string[] post(CheckOutModel model)
        {
            command = new SqlCommand("insert into fdCheckOut values(" + model.reservationRoomId + ", " + model.fdId + ", " + model.qty + ", " + model.price + ", " + model.employeeId + ")", connection);
            connection.Open();
            try
            {
                command.ExecuteNonQuery();
                connection.Close();
                return new string[] { "Success" };
            }
            catch (Exception ex)
            {
                return new string[]{ ex.Message };
            }
        }
    }
}
