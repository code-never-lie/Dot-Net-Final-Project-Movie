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
    public partial class PaymentGUI : Form
    {
        string user_id;
        string movie_id;
        CustomerBL cbl;
        public PaymentGUI()
        {
            InitializeComponent();
            cbl = new CustomerBL();
        }
        public PaymentGUI(string user,string movie)
        {
            InitializeComponent();
            user_id = user;
            movie_id = movie;
            cbl = new CustomerBL();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You For Chosing us Your Bill is now Clear");
            txt_discount.Clear();
            txt_f_amount.Clear();
            txt_t_amount.Clear();
        }

        private void PaymentGUI_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();
            PaymentDTO pdto = new PaymentDTO();
            pdto.User_id = user_id;
            pdto.Movie_id = movie_id;
            pdto=cbl.GetPayment(pdto);
            txt_t_amount.Text = pdto.Amount;
            txt_discount.Text = pdto.Discount;
            txt_f_amount.Text = (Convert.ToInt32(pdto.Amount) - Convert.ToInt32(pdto.Discount)).ToString();
        }

        private void PaymentGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void PaymentGUI_FormClosing(object sender, FormClosingEventArgs e)
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
