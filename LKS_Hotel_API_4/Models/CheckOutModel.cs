using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LKS_Hotel_API_4.Models
{
    public class CheckOutModel
    {
        public int reservationRoomId { set; get; }
        public int fdId { set; get; }
        public int qty { set; get; }
        public int price { set; get; }
        public int employeeId { set; get; }
    }
}