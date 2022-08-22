using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scd_W1_Final_Project_Movie.DTO
{
    class ShowDTO
    {
        private string _showID;
        private string _showtiming;
        private string _showdate;
        private string _showprice;
        private string _movieid;

        public string ShowID { get => _showID; set => _showID = value; }
        public string Showtiming { get => _showtiming; set => _showtiming = value; }
        public string Showdate { get => _showdate; set => _showdate = value; }
        public string Showprice { get => _showprice; set => _showprice = value; }
        public string Movieid { get => _movieid; set => _movieid = value; }
    }
}
