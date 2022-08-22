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
    public partial class AdminGUI : Form
    {
        MovieBL mbl;
        public AdminGUI()
        {
            InitializeComponent();
            mbl = new MovieBL();
        }

        private void AdminGUI_FormClosing(object sender, FormClosingEventArgs e)
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

        private void AdminGUI_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();
            
            
        }

        private void AdminGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
        string imagelocation = "";
        private void btn_add_poster_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            if(opd.ShowDialog()==DialogResult.OK)
            {

                imagelocation = opd.FileName.ToString();
                pb_poster.ImageLocation = imagelocation;

            }
        }

        private void btn_Addmovie_Click(object sender, EventArgs e)
        {
            MovieDTO mdto = new MovieDTO();
            mdto.Movie_id = txt_movieid.Text;
            mdto.Movie_name = txt_moviename.Text;
            mdto.Movie_language = txt_movielanguage.Text;
            mdto.Movie_type = txt_movietype.Text;
            mdto.Image_location = imagelocation;
            mdto.Movie_cast = txt_moviecast.Text;
            mbl.AddMovie(mdto);
            txt_movieid.Clear();
            txt_moviecast.Clear();
            txt_movielanguage.Clear();
            txt_moviename.Clear();
            txt_movietype.Clear();
            txt_movieid.Focus();
            
        }

        private void btn_view_movie_Click(object sender, EventArgs e)
        {
            MovieDTO mdto = new MovieDTO();
            MovieDTO rmdto = new MovieDTO();
            mdto.Movie_id = txt_movieid.Text;
            rmdto = mbl.ViewMovie(mdto);
           
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
             

        }

        private void btn_remove_movie_Click(object sender, EventArgs e)
        {
            MovieDTO mdto = new MovieDTO();
            mdto.Movie_id = txt_movieid.Text;
            mbl.RemoveMovie(mdto);
            txt_movieid.Clear();
            txt_movieid.Focus();

        }

        private void btn_clear_field_Click(object sender, EventArgs e)
        {
            txt_movieid.Clear();
            txt_moviecast.Clear();
            txt_movielanguage.Clear();
            txt_moviename.Clear();
            txt_movietype.Clear();
            txt_movieid.Focus();

        }

        private void btn_show_menu_Click(object sender, EventArgs e)
        {
            ShowGUI sgui = new ShowGUI();
            sgui.ShowDialog(this);
        }
    }
}
 