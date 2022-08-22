using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scd_W1_Final_Project_Movie.DTO
{
    class PaymentDTO
    {
        string _user_id;
        string _show_id;
        string _movie_id;
        string _discount;
        string _amount;

        public string User_id { get => _user_id; set => _user_id = value; }
        public string Show_id { get => _show_id; set => _show_id = value; }
        public string Movie_id { get => _movie_id; set => _movie_id = value; }
        public string Discount { get => _discount; set => _discount = value; }
        public string Amount { get => _amount; set => _amount = value; }
    }
}
