using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelAPI.Models
{
    public class HotelMod
    {
        public HotelMod(Hotel hotel)
        {
            ID = hotel.ID;
            Room = hotel.Room;
            Count_Peoples = hotel.Count_Peoples;
            Status = hotel.Status;
            Image = hotel.Image;
        }

        public int ID { get; set; }
        public int Room { get; set; }
        public int Count_Peoples { get; set; }
        public string Status { get; set; }
        public byte[] Image { get; set; }
    }
}