using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scd_W1_Final_Project_Movie.DTO
{
    class BookingDTO
    {
        private string _bookingID;
        private string _showid;
        private string _movieid;
        private string _userid;

        public string BookingID { get => _bookingID; set => _bookingID = value; }
        public string Showid { get => _showid; set => _showid = value; }
        public string Movieid { get => _movieid; set => _movieid = value; }
        public string Userid { get => _userid; set => _userid = value; }
    }
}
