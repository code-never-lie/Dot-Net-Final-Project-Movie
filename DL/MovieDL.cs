using Scd_W1_Final_Project_Movie.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scd_W1_Final_Project_Movie.DL
{
    class MovieDL
    {
        private DBConnection sqlCon;
        public MovieDTO rmdto;
        public MovieDL()
        {
            sqlCon = new DBConnection();
            rmdto = new MovieDTO();

        }
        public void AddMovieInDB(MovieDTO mdto)
        {
            try
            {

                sqlCon.Con.Open();
                byte[] images = null;
                FileStream Stream = new FileStream(mdto.Image_location, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(Stream);
                images = br.ReadBytes((int)Stream.Length);


                string SqlQuery = "insert into Movie values ('" + mdto.Movie_id + "' ,@images, '" + mdto.Movie_name + "', '" + mdto.Movie_language + "','" + mdto.Movie_cast + "','" + mdto.Movie_type + "')";
                SqlCommand cmd = new SqlCommand(SqlQuery, sqlCon.Con);
                cmd.Parameters.Add(new SqlParameter("@images", images));
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

        public MovieDTO ViewMovieInDB(MovieDTO mdto)
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
                    rmdto.Movie_id= dr[0].ToString();
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
        public void RemoveMovieInDB(MovieDTO mdto)
        {
            try
            {

                sqlCon.Con.Open();
                string queryString = "Delete from Movie where Movie_id = '" + mdto.Movie_id + "'";
                SqlCommand com = new SqlCommand(queryString, sqlCon.Con);
                int rowsAffected = com.ExecuteNonQuery();
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
        public void AddShowInDB(ShowDTO sdto)
        {
            try
            {

                sqlCon.Con.Open();
                


                string SqlQuery = "insert into MyShow values ('" + sdto.ShowID + "' , '" + sdto.Showtiming + "', '" + sdto.Showdate + "','" + sdto.Showprice + "','" + sdto.Movieid + "')";
                SqlCommand cmd = new SqlCommand(SqlQuery, sqlCon.Con);
               // cmd.Parameters.Add(new SqlParameter("@images", images));
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
        public void RemoveShowInDB(ShowDTO sdto)
        {
            try
            {

                sqlCon.Con.Open();
                string queryString = "Delete from MyShow where Show_id = '" + sdto.ShowID + "'";
                SqlCommand com = new SqlCommand(queryString, sqlCon.Con);
                int rowsAffected = com.ExecuteNonQuery();
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

        public ShowDTO ViewShowInDB(ShowDTO sdto)
        {
            ShowDTO rsdto = new ShowDTO();
            try
            {
                
                sqlCon.Con.Open();
                string queryString = "SELECT * FROM MyShow WHERE Movie_id='" + sdto.Movieid + "'";
                SqlCommand cmd = new SqlCommand(queryString, sqlCon.Con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    rsdto.ShowID = dr[0].ToString();
                    rsdto.Showtiming = dr[1].ToString();
                    rsdto.Showprice = dr[3].ToString();
                    rsdto.Showdate = dr[2].ToString();
                    rsdto.Movieid = dr[4].ToString();
                   


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


            return rsdto;

        }


    }
}
