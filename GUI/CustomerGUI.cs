using Scd_W1_Final_Project_Movie.BL;
using Scd_W1_Final_Project_Movie.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scd_W1_Final_Project_Movie.GUI
{
    public partial class CustomerGUI : Form
    {
       
        CustomerBL cbl;
        int i = 1;
        string userid;
        public CustomerGUI()
        {
            InitializeComponent();
            cbl = new CustomerBL();
        }
        public CustomerGUI(string uid)
        {
            InitializeComponent();
            cbl = new CustomerBL();
            userid = uid;
        }

        private void CustomerGUI_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();
            MovieDTO mdto = new MovieDTO();
            MovieDTO rmdto = new MovieDTO();
            mdto.Movie_id = i.ToString();
            rmdto = cbl.GetMovie(mdto);

            txt_moviecast.Text = rmdto.Movie_cast;
            txt_movieid.Text = rmdto.Movie_id;
            txt_movielanguage.Text = rmdto.Movie_language;
            txt_moviename.Text = rmdto.Movie_name;
            txt_movietype.Text = rmdto.Movie_type;
            if (rmdto.Images == null)
            {
                pb_poster.Image = null;
            }
            else
            {
                MemoryStream ms = new MemoryStream(rmdto.Images);
                pb_poster.Image = Image.FromStream(ms);
            }
            i++;
        }

        private void btn_Next_Movie_Click(object sender, EventArgs e)
        {
            MovieDTO mdto = new MovieDTO();
            MovieDTO rmdto = new MovieDTO();
            mdto.Movie_id = i.ToString();
            rmdto = cbl.GetMovie(mdto);

            txt_moviecast.Text = rmdto.Movie_cast;
            txt_movieid.Text = rmdto.Movie_id;
            txt_movielanguage.Text = rmdto.Movie_language;
            txt_moviename.Text = rmdto.Movie_name;
            txt_movietype.Text = rmdto.Movie_type;
            if (rmdto.Images == null)
            {
                pb_poster.Image = null;
            }
            else
            {
                MemoryStream ms = new MemoryStream(rmdto.Images);
                pb_poster.Image = Image.FromStream(ms);
            }
            i++;
        }

        private void btn_View_Show_Click(object sender, EventArgs e)
        {
            ViewShowGUI vsg = new ViewShowGUI(txt_movieid.Text);
            vsg.ShowDialog(this);

        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            BookingDTO bdto = new BookingDTO();
            bdto.Userid = userid;
            bdto.Movieid = txt_movieid.Text;

           // bdto.BookingID = (rnd.Next(1, 202032)).ToString();
            cbl.AddBooking(bdto);
            MessageBox.Show("This movie ticket is sold out to you");
            
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            PaymentGUI pgui = new PaymentGUI(userid,txt_movieid.Text);
            pgui.ShowDialog(this);


        }

        private void CustomerGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void CustomerGUI_FormClosing(object sender, FormClosingEventArgs e)
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
