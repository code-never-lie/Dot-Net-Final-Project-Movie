using Scd_W1_Final_Project_Movie.BL;
using Scd_W1_Final_Project_Movie.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scd_W1_Final_Project_Movie.GUI
{
    public partial class SignUpGUI : Form
    {
        private LogInBL _lgBL;
        public SignUpGUI()
        {
            InitializeComponent();
            _lgBL = new LogInBL();
        }

        private void SignUpGUI_Load(object sender, EventArgs e)
        {
            
            this.Owner.Hide();
        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            UserDTO udto = new UserDTO();
            udto.UserID = txt_userid.Text;
            udto.Age = txt_age.Text;
            udto.Username = txt_username.Text;
            udto.Password = txt_password.Text;
            _lgBL.AddUser(udto);
           
            txt_userid.Clear();
            txt_age.Clear();
            txt_password.Clear();
            txt_username.Clear();
            txt_userid.Focus();


        }

        private void SignUpGUI_FormClosing(object sender, FormClosingEventArgs e)
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

        private void SignUpGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
