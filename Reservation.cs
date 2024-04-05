using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    internal class Reservation
    {
        public int ReservationNumber { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public HotelRoom Room { get; set; } 
        public int DurationInDays { get; set; }
        public decimal Total {  get; set; }

        public Reservation(int reservationNumber, DateTime startTime, DateTime endTime, HotelRoom room, int durationInDays, decimal total)
        {
            ReservationNumber = reservationNumber;
            StartTime = startTime;
            EndTime = endTime;
            Room = room;
            DurationInDays = durationInDays;
            Total = total;
        }

        public void DisplayDetails()
        {

        }
    }
}
