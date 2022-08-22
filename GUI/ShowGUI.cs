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
    public partial class ShowGUI : Form
    {
        MovieBL mbl;
        public ShowGUI()
        {
            InitializeComponent();
            mbl = new MovieBL();
        }

        private void btn_add_show_Click(object sender, EventArgs e)
        {
            ShowDTO sdto = new ShowDTO();
            sdto.ShowID = txt_showid.Text;
            sdto.Showtiming = txt_showtiming.Text;
            sdto.Showdate = txt_showdate.Text;
            sdto.Showprice = txt_showprice.Text;
            sdto.Movieid = txt_movieid.Text;
            mbl.AddShow(sdto);
            txt_showid.Clear();
            txt_showtiming.Clear();
            txt_showprice.Clear();
            txt_showdate.Clear();
            txt_movieid.Clear();
            txt_showid.Focus();


        }

        private void btn_remove_show_Click(object sender, EventArgs e)
        {
            ShowDTO sdto = new ShowDTO();
            sdto.ShowID = txt_showid.Text;
            mbl.RemoveShow(sdto);
            txt_showid.Clear();
            txt_showtiming.Clear();
            txt_showprice.Clear();
            txt_showdate.Clear();
            txt_movieid.Clear();
            txt_showid.Focus();
        }

        private void ShowGUI_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();
        }

        private void ShowGUI_FormClosing(object sender, FormClosingEventArgs e)
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

        private void ShowGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
