using Scd_W1_Final_Project_Movie.BL;
using Scd_W1_Final_Project_Movie.DTO;
using Scd_W1_Final_Project_Movie.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scd_W1_Final_Project_Movie
{
    public partial class LogInGUI : Form
    {
        private LogInBL _lgBL;
        public LogInGUI()
        {
            InitializeComponent();
            _lgBL = new LogInBL();
        }

        private void LogInGUI_Load(object sender, EventArgs e)
        {
            txt_username.Text = "UserName";
            txt_password.Text = "Password";
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            UserDTO udto = new UserDTO();
            udto.Username = txt_username.Text;
            udto.Password = txt_password.Text;
            Form gui = _lgBL.VerifyUser(udto);
            gui.ShowDialog(this);
            txt_password.Clear();
            txt_username.Clear();
            txt_username.Focus();

        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
           SignUpGUI su  = new  SignUpGUI();
            su.ShowDialog(this);
        }

        private void LogInGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure you want to close!!!", "Form is going to close", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

            }
            else
            {

            }
        }
    }
}
