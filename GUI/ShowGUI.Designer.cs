
namespace Scd_W1_Final_Project_Movie.GUI
{
    partial class ShowGUI
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Movie_ID = new System.Windows.Forms.Label();
            this.txt_movieid = new System.Windows.Forms.TextBox();
            this.txt_showdate = new System.Windows.Forms.TextBox();
            this.txt_showprice = new System.Windows.Forms.TextBox();
            this.txt_showtiming = new System.Windows.Forms.TextBox();
            this.txt_showid = new System.Windows.Forms.TextBox();
            this.btn_add_show = new System.Windows.Forms.Button();
            this.btn_remove_show = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Show Timing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Movie Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Show Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Show Price";
            // 
            // Movie_ID
            // 
            this.Movie_ID.AutoSize = true;
            this.Movie_ID.Location = new System.Drawing.Point(227, 123);
            this.Movie_ID.Name = "Movie_ID";
            this.Movie_ID.Size = new System.Drawing.Size(48, 13);
            this.Movie_ID.TabIndex = 41;
            this.Movie_ID.Text = "Show ID";
            // 
            // txt_movieid
            // 
            this.txt_movieid.Location = new System.Drawing.Point(336, 272);
            this.txt_movieid.Name = "txt_movieid";
            this.txt_movieid.Size = new System.Drawing.Size(146, 20);
            this.txt_movieid.TabIndex = 40;
            // 
            // txt_showdate
            // 
            this.txt_showdate.Location = new System.Drawing.Point(336, 193);
            this.txt_showdate.Name = "txt_showdate";
            this.txt_showdate.Size = new System.Drawing.Size(146, 20);
            this.txt_showdate.TabIndex = 39;
            // 
            // txt_showprice
            // 
            this.txt_showprice.Location = new System.Drawing.Point(336, 232);
            this.txt_showprice.Name = "txt_showprice";
            this.txt_showprice.Size = new System.Drawing.Size(146, 20);
            this.txt_showprice.TabIndex = 38;
            // 
            // txt_showtiming
            // 
            this.txt_showtiming.Location = new System.Drawing.Point(336, 154);
            this.txt_showtiming.Name = "txt_showtiming";
            this.txt_showtiming.Size = new System.Drawing.Size(146, 20);
            this.txt_showtiming.TabIndex = 37;
            // 
            // txt_showid
            // 
            this.txt_showid.Location = new System.Drawing.Point(336, 116);
            this.txt_showid.Name = "txt_showid";
            this.txt_showid.Size = new System.Drawing.Size(146, 20);
            this.txt_showid.TabIndex = 36;
            // 
            // btn_add_show
            // 
            this.btn_add_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_add_show.Location = new System.Drawing.Point(265, 345);
            this.btn_add_show.Name = "btn_add_show";
            this.btn_add_show.Size = new System.Drawing.Size(96, 23);
            this.btn_add_show.TabIndex = 47;
            this.btn_add_show.Text = "Add Show ";
            this.btn_add_show.UseVisualStyleBackColor = false;
            this.btn_add_show.Click += new System.EventHandler(this.btn_add_show_Click);
            // 
            // btn_remove_show
            // 
            this.btn_remove_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_remove_show.Location = new System.Drawing.Point(386, 345);
            this.btn_remove_show.Name = "btn_remove_show";
            this.btn_remove_show.Size = new System.Drawing.Size(96, 23);
            this.btn_remove_show.TabIndex = 48;
            this.btn_remove_show.Text = "Remove Show";
            this.btn_remove_show.UseVisualStyleBackColor = false;
            this.btn_remove_show.Click += new System.EventHandler(this.btn_remove_show_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.richTextBox1.Font = new System.Drawing.Font("Elephant", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(131, 34);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(489, 37);
            this.richTextBox1.TabIndex = 49;
            this.richTextBox1.Text = "                                Show Panel";
            // 
            // ShowGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_remove_show);
            this.Controls.Add(this.btn_add_show);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Movie_ID);
            this.Controls.Add(this.txt_movieid);
            this.Controls.Add(this.txt_showdate);
            this.Controls.Add(this.txt_showprice);
            this.Controls.Add(this.txt_showtiming);
            this.Controls.Add(this.txt_showid);
            this.Name = "ShowGUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowGUI_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShowGUI_FormClosed);
            this.Load += new System.EventHandler(this.ShowGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Movie_ID;
        private System.Windows.Forms.TextBox txt_movieid;
        private System.Windows.Forms.TextBox txt_showdate;
        private System.Windows.Forms.TextBox txt_showprice;
        private System.Windows.Forms.TextBox txt_showtiming;
        private System.Windows.Forms.TextBox txt_showid;
        private System.Windows.Forms.Button btn_add_show;
        private System.Windows.Forms.Button btn_remove_show;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}