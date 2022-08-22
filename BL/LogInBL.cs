using Scd_W1_Final_Project_Movie.DL;
using Scd_W1_Final_Project_Movie.DTO;
using Scd_W1_Final_Project_Movie.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scd_W1_Final_Project_Movie.BL
{
    class LogInBL
    {
        private LogInDL _lgDL;
        public LogInBL()
        {
            _lgDL = new LogInDL();
        }
        public void AddUser(UserDTO udto)
        {
            _lgDL.AddUserIntoDB(udto);

        }
        public Form VerifyUser(UserDTO udto)
        {

            UserDTO retDTO = _lgDL.VerifyUserFromDB(udto);
            //MessageBox.Show(retDTO.Role);
            
            if (retDTO != null && retDTO.Role != null)
            {

                if (retDTO.Role.Equals("Admin"))
                {
                    return new AdminGUI();
                }
                else if (retDTO.Role.Equals("Customer"))
                {
                    return new CustomerGUI(retDTO.UserID);
                }
                /*else if (retDTO.Role.Equals("advisor"))
                {

                }
                else if (retDTO.Role.Equals("ao"))
                {

                }*/
                else
                {
                    // wrong user
                    return new WrongGUI();
                }
            }
            else
            {
                // wrong user
                return new WrongGUI();
            }

        }


    }
}
