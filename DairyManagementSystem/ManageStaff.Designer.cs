
namespace DairyManagementSystem
{
    partial class ManageStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStaff));
            this.dtbtn = new System.Windows.Forms.Button();
            this.stbtn = new System.Windows.Forms.Button();
            this.MStdataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gcomboBox = new System.Windows.Forms.ComboBox();
            this.sptxt = new System.Windows.Forms.TextBox();
            this.satxt = new System.Windows.Forms.TextBox();
            this.sntxt = new System.Windows.Forms.TextBox();
            this.sctxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sstxt = new System.Windows.Forms.TextBox();
            this.swtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MStdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtbtn
            // 
            this.dtbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dtbtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbtn.Location = new System.Drawing.Point(398, 191);
            this.dtbtn.Name = "dtbtn";
            this.dtbtn.Size = new System.Drawing.Size(75, 37);
            this.dtbtn.TabIndex = 34;
            this.dtbtn.Text = "Delete";
            this.dtbtn.UseVisualStyleBackColor = true;
            this.dtbtn.Click += new System.EventHandler(this.dtbtn_Click);
            // 
            // stbtn
            // 
            this.stbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stbtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stbtn.Location = new System.Drawing.Point(317, 191);
            this.stbtn.Name = "stbtn";
            this.stbtn.Size = new System.Drawing.Size(75, 37);
            this.stbtn.TabIndex = 33;
            this.stbtn.Text = "Save";
            this.stbtn.UseVisualStyleBackColor = true;
            this.stbtn.Click += new System.EventHandler(this.stbtn_Click);
            // 
            // MStdataGridView
            // 
            this.MStdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MStdataGridView.Location = new System.Drawing.Point(-21, 234);
            this.MStdataGridView.Name = "MStdataGridView";
            this.MStdataGridView.Size = new System.Drawing.Size(843, 228);
            this.MStdataGridView.TabIndex = 32;
            this.MStdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MStdataGridView_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(347, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(600, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // gcomboBox
            // 
            this.gcomboBox.FormattingEnabled = true;
            this.gcomboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.gcomboBox.Location = new System.Drawing.Point(124, 145);
            this.gcomboBox.Name = "gcomboBox";
            this.gcomboBox.Size = new System.Drawing.Size(185, 21);
            this.gcomboBox.TabIndex = 29;
            // 
            // sptxt
            // 
            this.sptxt.Location = new System.Drawing.Point(600, 141);
            this.sptxt.Multiline = true;
            this.sptxt.Name = "sptxt";
            this.sptxt.Size = new System.Drawing.Size(185, 20);
            this.sptxt.TabIndex = 28;
            // 
            // satxt
            // 
            this.satxt.Location = new System.Drawing.Point(124, 102);
            this.satxt.Multiline = true;
            this.satxt.Name = "satxt";
            this.satxt.Size = new System.Drawing.Size(182, 20);
            this.satxt.TabIndex = 27;
            // 
            // sntxt
            // 
            this.sntxt.Location = new System.Drawing.Point(124, 59);
            this.sntxt.Multiline = true;
            this.sntxt.Name = "sntxt";
            this.sntxt.Size = new System.Drawing.Size(182, 20);
            this.sntxt.TabIndex = 26;
            // 
            // sctxt
            // 
            this.sctxt.Location = new System.Drawing.Point(124, 17);
            this.sctxt.Multiline = true;
            this.sctxt.Name = "sctxt";
            this.sctxt.Size = new System.Drawing.Size(182, 20);
            this.sctxt.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(492, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Phone No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(460, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Register Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(521, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Staff Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Staff Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Staff Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 35;
            this.label7.Text = "Gender";
            // 
            // sstxt
            // 
            this.sstxt.Location = new System.Drawing.Point(600, 17);
            this.sstxt.Multiline = true;
            this.sstxt.Name = "sstxt";
            this.sstxt.Size = new System.Drawing.Size(182, 20);
            this.sstxt.TabIndex = 36;
            // 
            // swtxt
            // 
            this.swtxt.Location = new System.Drawing.Point(600, 59);
            this.swtxt.Multiline = true;
            this.swtxt.Name = "swtxt";
            this.swtxt.Size = new System.Drawing.Size(182, 20);
            this.swtxt.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(521, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 23);
            this.label8.TabIndex = 38;
            this.label8.Text = "Work";
            // 
            // ManageStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.swtxt);
            this.Controls.Add(this.sstxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtbtn);
            this.Controls.Add(this.stbtn);
            this.Controls.Add(this.MStdataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gcomboBox);
            this.Controls.Add(this.sptxt);
            this.Controls.Add(this.satxt);
            this.Controls.Add(this.sntxt);
            this.Controls.Add(this.sctxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageStaff";
            this.Load += new System.EventHandler(this.ManageStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MStdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dtbtn;
        private System.Windows.Forms.Button stbtn;
        private System.Windows.Forms.DataGridView MStdataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox gcomboBox;
        private System.Windows.Forms.TextBox sptxt;
        private System.Windows.Forms.TextBox satxt;
        private System.Windows.Forms.TextBox sntxt;
        private System.Windows.Forms.TextBox sctxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sstxt;
        private System.Windows.Forms.TextBox swtxt;
        private System.Windows.Forms.Label label8;
    }
}