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
    public class RoomController : ApiController
    {
        [HttpGet]
        public DataTable data()
        {
            string com = "select room.RoomNumber, reservationRoom.id from reservationRoom join room on room.id = reservationRoom.id where room.status = 'unavail'";
            return Command.data(com);
        }
    }
}
