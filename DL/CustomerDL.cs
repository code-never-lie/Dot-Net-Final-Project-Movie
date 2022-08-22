using Scd_W1_Final_Project_Movie.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scd_W1_Final_Project_Movie.DL
{
    class CustomerDL
    {
        private DBConnection sqlCon;
        public MovieDTO rmdto;
        public CustomerDL()
        {
            sqlCon = new DBConnection();
            rmdto = new MovieDTO();
        }
        public MovieDTO GetMovieInDB(MovieDTO mdto)
        {
            try
            {

                sqlCon.Con.Open();
                string queryString = "SELECT * FROM Movie WHERE Movie_id='" + mdto.Movie_id + "'";
                SqlCommand cmd = new SqlCommand(queryString, sqlCon.Con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    rmdto.Movie_id = dr[0].ToString();
                    rmdto.Movie_name = dr[2].ToString();
                    rmdto.Movie_language = dr[3].ToString();
                    rmdto.Movie_cast = dr[4].ToString();
                    rmdto.Movie_type = dr[5].ToString();
                    rmdto.Images = (byte[])dr[1];


                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Con.Close();
            }


            return rmdto;

        }
            




        public BookingDTO GetShowIDInDB(BookingDTO bdto)
        {
            
            try
            {

                sqlCon.Con.Open();
                string queryString = "SELECT * FROM MyShow WHERE Movie_id='" + bdto.Movieid + "'";
                SqlCommand cmd = new SqlCommand(queryString, sqlCon.Con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    bdto.Showid = dr[0].ToString();
                    


                }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Con.Close();
            }

            return bdto;


        }
        public string GetShowPriceInDB(string show)
        {
            string price = "";
            try
            {

                sqlCon.Con.Open();
                string queryString = "SELECT * FROM MyShow WHERE Show_id='" + show + "'";
                SqlCommand cmd = new SqlCommand(queryString, sqlCon.Con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    price = dr[3].ToString();



                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Con.Close();
            }

            return price;


        }
        public PaymentDTO GetPaymentInDB(int bookid)
        {
            PaymentDTO rpdto = new PaymentDTO();
            try
            {

                sqlCon.Con.Open();
                string queryString = "SELECT * FROM Booking WHERE Booking_id='" + bookid+ "'";
                SqlCommand cmd = new SqlCommand(queryString, sqlCon.Con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    rpdto.Show_id = dr[1].ToString();
                    rpdto.User_id = dr[2].ToString();


                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Con.Close();
            }

            return rpdto;


        }
        public void AddBookingInDB(BookingDTO bdto)
        {

            try
            {
                sqlCon.Con.Open();
                string SqlQuery = "insert into Booking values ( '" + bdto.Showid + "', '" + bdto.Userid + "')";
                SqlCommand cmd = new SqlCommand(SqlQuery, sqlCon.Con);
               
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Con.Close();
            }




        }
    }
}
