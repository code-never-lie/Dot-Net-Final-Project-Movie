
namespace Scd_W1_Final_Project_Movie.GUI
{
    partial class PaymentGUI
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Movie_ID = new System.Windows.Forms.Label();
            this.txt_f_amount = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_t_amount = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_pay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Discount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Final Amount";
            // 
            // Movie_ID
            // 
            this.Movie_ID.AutoSize = true;
            this.Movie_ID.Location = new System.Drawing.Point(240, 164);
            this.Movie_ID.Name = "Movie_ID";
            this.Movie_ID.Size = new System.Drawing.Size(70, 13);
            this.Movie_ID.TabIndex = 53;
            this.Movie_ID.Text = "Total Amount";
            // 
            // txt_f_amount
            // 
            this.txt_f_amount.Location = new System.Drawing.Point(349, 234);
            this.txt_f_amount.Name = "txt_f_amount";
            this.txt_f_amount.Size = new System.Drawing.Size(146, 20);
            this.txt_f_amount.TabIndex = 52;
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(349, 195);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(146, 20);
            this.txt_discount.TabIndex = 51;
            // 
            // txt_t_amount
            // 
            this.txt_t_amount.Location = new System.Drawing.Point(349, 157);
            this.txt_t_amount.Name = "txt_t_amount";
            this.txt_t_amount.Size = new System.Drawing.Size(146, 20);
            this.txt_t_amount.TabIndex = 50;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.richTextBox1.Font = new System.Drawing.Font("Elephant", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(99, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(529, 37);
            this.richTextBox1.TabIndex = 57;
            this.richTextBox1.Text = "                                Payment Panel";
            // 
            // btn_pay
            // 
            this.btn_pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_pay.Location = new System.Drawing.Point(301, 328);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(121, 23);
            this.btn_pay.TabIndex = 58;
            this.btn_pay.Text = "Pay";
            this.btn_pay.UseVisualStyleBackColor = false;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // PaymentGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Movie_ID);
            this.Controls.Add(this.txt_f_amount);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.txt_t_amount);
            this.Name = "PaymentGUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaymentGUI_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PaymentGUI_FormClosed);
            this.Load += new System.EventHandler(this.PaymentGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Movie_ID;
        private System.Windows.Forms.TextBox txt_f_amount;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.TextBox txt_t_amount;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_pay;
    }
}