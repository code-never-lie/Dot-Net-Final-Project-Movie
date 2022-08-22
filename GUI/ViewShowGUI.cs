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
    public partial class ViewShowGUI : Form
    {
        string _id;
        MovieBL mbl;
        public ViewShowGUI()
        {
            InitializeComponent();
            mbl =  new MovieBL();
        }
        public ViewShowGUI(string id)
        {
            InitializeComponent();

            _id = id;
            mbl = new MovieBL();
        }
        private void ViewShowGUI_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();
            ShowDTO sdto = new ShowDTO();
            ShowDTO rsdto = new ShowDTO();
            sdto.Movieid = _id;
            rsdto = mbl.ViewShow(sdto);
            txt_showid.Text = rsdto.ShowID;
            txt_showdate.Text = rsdto.Showdate;
            txt_showprice.Text = rsdto.Showprice;
            txt_showtiming.Text = rsdto.Showtiming;
            txt_movieid.Text = rsdto.Movieid;



        }

        private void ViewShowGUI_FormClosing(object sender, FormClosingEventArgs e)
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

        private void ViewShowGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
