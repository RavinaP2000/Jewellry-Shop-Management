namespace Nitin_Mohan_Pingulkar_Jewellers
{
    partial class Bill
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Save_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.prod_id_txt = new System.Windows.Forms.TextBox();
            this.prod_name_cmb = new System.Windows.Forms.ComboBox();
            this.prod_quan_txt = new System.Windows.Forms.TextBox();
            this.prod_price_txt = new System.Windows.Forms.TextBox();
            this.prod_gst_txt = new System.Windows.Forms.TextBox();
            this.prod_total_txt = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LemonChiffon;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(43, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registration  Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(43, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(50, 306);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "GST";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(50, 360);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(48, 248);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(43, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Quantity";
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.Cornsilk;
            this.Save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.Location = new System.Drawing.Point(80, 418);
            this.Save_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(112, 34);
            this.Save_btn.TabIndex = 18;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(272, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // prod_id_txt
            // 
            this.prod_id_txt.Enabled = false;
            this.prod_id_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_id_txt.Location = new System.Drawing.Point(243, 75);
            this.prod_id_txt.Margin = new System.Windows.Forms.Padding(4);
            this.prod_id_txt.Name = "prod_id_txt";
            this.prod_id_txt.Size = new System.Drawing.Size(148, 28);
            this.prod_id_txt.TabIndex = 21;
            // 
            // prod_name_cmb
            // 
            this.prod_name_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prod_name_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_name_cmb.FormattingEnabled = true;
            this.prod_name_cmb.Location = new System.Drawing.Point(243, 135);
            this.prod_name_cmb.Margin = new System.Windows.Forms.Padding(4);
            this.prod_name_cmb.Name = "prod_name_cmb";
            this.prod_name_cmb.Size = new System.Drawing.Size(148, 30);
            this.prod_name_cmb.TabIndex = 22;
            // 
            // prod_quan_txt
            // 
            this.prod_quan_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_quan_txt.Location = new System.Drawing.Point(243, 196);
            this.prod_quan_txt.Margin = new System.Windows.Forms.Padding(4);
            this.prod_quan_txt.Name = "prod_quan_txt";
            this.prod_quan_txt.Size = new System.Drawing.Size(148, 30);
            this.prod_quan_txt.TabIndex = 23;
            // 
            // prod_price_txt
            // 
            this.prod_price_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_price_txt.Location = new System.Drawing.Point(243, 250);
            this.prod_price_txt.Margin = new System.Windows.Forms.Padding(4);
            this.prod_price_txt.Name = "prod_price_txt";
            this.prod_price_txt.Size = new System.Drawing.Size(148, 30);
            this.prod_price_txt.TabIndex = 24;
            // 
            // prod_gst_txt
            // 
            this.prod_gst_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_gst_txt.Location = new System.Drawing.Point(243, 301);
            this.prod_gst_txt.Margin = new System.Windows.Forms.Padding(4);
            this.prod_gst_txt.Name = "prod_gst_txt";
            this.prod_gst_txt.Size = new System.Drawing.Size(148, 30);
            this.prod_gst_txt.TabIndex = 25;
            // 
            // prod_total_txt
            // 
            this.prod_total_txt.BackColor = System.Drawing.Color.White;
            this.prod_total_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_total_txt.Location = new System.Drawing.Point(243, 354);
            this.prod_total_txt.Margin = new System.Windows.Forms.Padding(4);
            this.prod_total_txt.Name = "prod_total_txt";
            this.prod_total_txt.ReadOnly = true;
            this.prod_total_txt.Size = new System.Drawing.Size(148, 30);
            this.prod_total_txt.TabIndex = 26;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 528);
            this.Controls.Add(this.prod_total_txt);
            this.Controls.Add(this.prod_gst_txt);
            this.Controls.Add(this.prod_price_txt);
            this.Controls.Add(this.prod_quan_txt);
            this.Controls.Add(this.prod_name_cmb);
            this.Controls.Add(this.prod_id_txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox prod_id_txt;
        private System.Windows.Forms.ComboBox prod_name_cmb;
        private System.Windows.Forms.TextBox prod_quan_txt;
        private System.Windows.Forms.TextBox prod_price_txt;
        private System.Windows.Forms.TextBox prod_gst_txt;
        private System.Windows.Forms.TextBox prod_total_txt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}