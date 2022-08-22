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
    class LogInDL
    {

        private DBConnection sqlCon;
        private UserDTO retDTO;
        public LogInDL()
        {
            sqlCon = new DBConnection();
        }
        public void AddUserIntoDB(UserDTO udto)
        {
            try
            {

                sqlCon.Con.Open();
                string queryString = "INSERT INTO myuser  VALUES('" + udto.UserID + "','" + udto.Username + "','" + udto.Password + "','Customer','" + udto.Age + "');";
                SqlCommand com = new SqlCommand(queryString, sqlCon.Con);
                int rowsAffected = com.ExecuteNonQuery();
                
               /* com.Parameters.AddWithValue("@UserID", udto.UserID);
                com.Parameters.AddWithValue("@Password", udto.Password);
                com.Parameters.AddWithValue("@Username", udto.Username);
                com.Parameters.AddWithValue("@Age", udto.Age);*/
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
        public UserDTO VerifyUserFromDB(UserDTO udto)
        {
            try
            {

                retDTO = new UserDTO();
                sqlCon.Con.Open(); // it will be used to open connection
                                   //string queryString = "SELECT * FROM MyUser WHERE Username='"+udto.Username+"' AND Password='"+udto.Password+"';";
                string queryString = "SELECT * FROM myuser WHERE Username=@username AND Password=@pass";
                SqlCommand com = new SqlCommand(queryString, sqlCon.Con);
                com.Parameters.AddWithValue("@username", udto.Username);
                com.Parameters.AddWithValue("@pass", udto.Password);

                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {

                    retDTO.UserID = reader["User_id"].ToString();
                    retDTO.Username = reader["Username"].ToString();
                    retDTO.Password = reader["Password"].ToString();
                    retDTO.Role = reader["Role"].ToString();
                    retDTO.Age = reader["Age"].ToString();

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);


            }
            finally
            {
                sqlCon.Con.Close(); // it will be used to close connection

            }
            

            return retDTO;
        }

    }
}
