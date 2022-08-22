
namespace Scd_W1_Final_Project_Movie.GUI
{
    partial class AdminGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_movielanguage = new System.Windows.Forms.TextBox();
            this.txt_moviecast = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_Addmovie = new System.Windows.Forms.Button();
            this.txt_moviename = new System.Windows.Forms.TextBox();
            this.txt_movieid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_movietype = new System.Windows.Forms.TextBox();
            this.pb_poster = new System.Windows.Forms.PictureBox();
            this.btn_view_movie = new System.Windows.Forms.Button();
            this.btn_remove_movie = new System.Windows.Forms.Button();
            this.btn_add_poster = new System.Windows.Forms.Button();
            this.Movie_ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_clear_field = new System.Windows.Forms.Button();
            this.btn_show_menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_poster)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_movielanguage
            // 
            this.txt_movielanguage.Location = new System.Drawing.Point(151, 166);
            this.txt_movielanguage.Name = "txt_movielanguage";
            this.txt_movielanguage.Size = new System.Drawing.Size(146, 20);
            this.txt_movielanguage.TabIndex = 23;
            // 
            // txt_moviecast
            // 
            this.txt_moviecast.Location = new System.Drawing.Point(151, 205);
            this.txt_moviecast.Name = "txt_moviecast";
            this.txt_moviecast.Size = new System.Drawing.Size(146, 20);
            this.txt_moviecast.TabIndex = 22;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.richTextBox1.Font = new System.Drawing.Font("Elephant", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(151, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(489, 37);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "                                Admin Panel";
            // 
            // btn_Addmovie
            // 
            this.btn_Addmovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Addmovie.Location = new System.Drawing.Point(204, 317);
            this.btn_Addmovie.Name = "btn_Addmovie";
            this.btn_Addmovie.Size = new System.Drawing.Size(105, 23);
            this.btn_Addmovie.TabIndex = 19;
            this.btn_Addmovie.Text = "Add Movie";
            this.btn_Addmovie.UseVisualStyleBackColor = false;
            this.btn_Addmovie.Click += new System.EventHandler(this.btn_Addmovie_Click);
            // 
            // txt_moviename
            // 
            this.txt_moviename.Location = new System.Drawing.Point(151, 127);
            this.txt_moviename.Name = "txt_moviename";
            this.txt_moviename.Size = new System.Drawing.Size(146, 20);
            this.txt_moviename.TabIndex = 18;
            // 
            // txt_movieid
            // 
            this.txt_movieid.Location = new System.Drawing.Point(151, 89);
            this.txt_movieid.Name = "txt_movieid";
            this.txt_movieid.Size = new System.Drawing.Size(146, 20);
            this.txt_movieid.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 16;
            // 
            // txt_movietype
            // 
            this.txt_movietype.Location = new System.Drawing.Point(151, 245);
            this.txt_movietype.Name = "txt_movietype";
            this.txt_movietype.Size = new System.Drawing.Size(146, 20);
            this.txt_movietype.TabIndex = 24;
            // 
            // pb_poster
            // 
            this.pb_poster.Location = new System.Drawing.Point(347, 89);
            this.pb_poster.Name = "pb_poster";
            this.pb_poster.Size = new System.Drawing.Size(184, 176);
            this.pb_poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_poster.TabIndex = 25;
            this.pb_poster.TabStop = false;
            // 
            // btn_view_movie
            // 
            this.btn_view_movie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_view_movie.Location = new System.Drawing.Point(425, 317);
            this.btn_view_movie.Name = "btn_view_movie";
            this.btn_view_movie.Size = new System.Drawing.Size(96, 23);
            this.btn_view_movie.TabIndex = 27;
            this.btn_view_movie.Text = "View Movie";
            this.btn_view_movie.UseVisualStyleBackColor = false;
            this.btn_view_movie.Click += new System.EventHandler(this.btn_view_movie_Click);
            // 
            // btn_remove_movie
            // 
            this.btn_remove_movie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_remove_movie.Location = new System.Drawing.Point(315, 317);
            this.btn_remove_movie.Name = "btn_remove_movie";
            this.btn_remove_movie.Size = new System.Drawing.Size(104, 23);
            this.btn_remove_movie.TabIndex = 28;
            this.btn_remove_movie.Text = "Remove movie";
            this.btn_remove_movie.UseVisualStyleBackColor = false;
            this.btn_remove_movie.Click += new System.EventHandler(this.btn_remove_movie_Click);
            // 
            // btn_add_poster
            // 
            this.btn_add_poster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_add_poster.Location = new System.Drawing.Point(558, 166);
            this.btn_add_poster.Name = "btn_add_poster";
            this.btn_add_poster.Size = new System.Drawing.Size(121, 23);
            this.btn_add_poster.TabIndex = 29;
            this.btn_add_poster.Text = "<-- Add poster";
            this.btn_add_poster.UseVisualStyleBackColor = false;
            this.btn_add_poster.Click += new System.EventHandler(this.btn_add_poster_Click);
            // 
            // Movie_ID
            // 
            this.Movie_ID.AutoSize = true;
            this.Movie_ID.Location = new System.Drawing.Point(42, 96);
            this.Movie_ID.Name = "Movie_ID";
            this.Movie_ID.Size = new System.Drawing.Size(53, 13);
            this.Movie_ID.TabIndex = 30;
            this.Movie_ID.Text = "Movie_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Movie_Cast";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Movie_Language";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Movie_Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Movie_Name";
            // 
            // btn_clear_field
            // 
            this.btn_clear_field.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_clear_field.Location = new System.Drawing.Point(527, 317);
            this.btn_clear_field.Name = "btn_clear_field";
            this.btn_clear_field.Size = new System.Drawing.Size(96, 23);
            this.btn_clear_field.TabIndex = 36;
            this.btn_clear_field.Text = "Clear Fields";
            this.btn_clear_field.UseVisualStyleBackColor = false;
            this.btn_clear_field.Click += new System.EventHandler(this.btn_clear_field_Click);
            // 
            // btn_show_menu
            // 
            this.btn_show_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_show_menu.Location = new System.Drawing.Point(601, 376);
            this.btn_show_menu.Name = "btn_show_menu";
            this.btn_show_menu.Size = new System.Drawing.Size(121, 23);
            this.btn_show_menu.TabIndex = 37;
            this.btn_show_menu.Text = "Go To Show Menu";
            this.btn_show_menu.UseVisualStyleBackColor = false;
            this.btn_show_menu.Click += new System.EventHandler(this.btn_show_menu_Click);
            // 
            // AdminGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.btn_show_menu);
            this.Controls.Add(this.btn_clear_field);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Movie_ID);
            this.Controls.Add(this.btn_add_poster);
            this.Controls.Add(this.btn_remove_movie);
            this.Controls.Add(this.btn_view_movie);
            this.Controls.Add(this.pb_poster);
            this.Controls.Add(this.txt_movietype);
            this.Controls.Add(this.txt_movielanguage);
            this.Controls.Add(this.txt_moviecast);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_Addmovie);
            this.Controls.Add(this.txt_moviename);
            this.Controls.Add(this.txt_movieid);
            this.Controls.Add(this.label1);
            this.Name = "AdminGUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminGUI_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminGUI_FormClosed);
            this.Load += new System.EventHandler(this.AdminGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_poster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_movielanguage;
        private System.Windows.Forms.TextBox txt_moviecast;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_Addmovie;
        private System.Windows.Forms.TextBox txt_moviename;
        private System.Windows.Forms.TextBox txt_movieid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_movietype;
        private System.Windows.Forms.PictureBox pb_poster;
        private System.Windows.Forms.Button btn_view_movie;
        private System.Windows.Forms.Button btn_remove_movie;
        private System.Windows.Forms.Button btn_add_poster;
        private System.Windows.Forms.Label Movie_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_clear_field;
        private System.Windows.Forms.Button btn_show_menu;
    }
}