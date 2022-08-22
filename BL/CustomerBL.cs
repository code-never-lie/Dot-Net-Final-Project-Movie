using Scd_W1_Final_Project_Movie.DL;
using Scd_W1_Final_Project_Movie.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scd_W1_Final_Project_Movie.BL
{
    class CustomerBL
    {
        CustomerDL cdl;
        public CustomerBL()
        {
            cdl = new CustomerDL();
        }

        public MovieDTO GetMovie(MovieDTO mdto)
        {
            MovieDTO rmdto;
            rmdto = cdl.GetMovieInDB(mdto);
            return rmdto;
        }
        public void AddBooking(BookingDTO bdto)
        {
            BookingDTO rbdto = new BookingDTO();
            rbdto = cdl.GetShowIDInDB(bdto);
            cdl.AddBookingInDB(rbdto);
            
        }
        public PaymentDTO GetPayment(PaymentDTO pdto) 
        {
            int number = 0;
            int amount = 0;
            int counter = 1;
            PaymentDTO rpdto = new PaymentDTO();

            while (counter < 10)
            {
                rpdto = cdl.GetPaymentInDB(counter);
                if(rpdto.User_id==pdto.User_id)
                {
                    amount=amount +Convert.ToInt32(cdl.GetShowPriceInDB(rpdto.Show_id));

                    number++;
                    
                }
                counter++;
            }
            if(number>=3)
            {


                rpdto.Discount = "500";

            }
            rpdto.Amount = amount.ToString();
            return rpdto;
        }
    }
}
