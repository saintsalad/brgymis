namespace BrgyMis2
{
    partial class addEventForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.notify = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.savebtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.parttxt = new Bunifu.Framework.UI.BunifuDropdown();
            this.locationtxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nametxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.notify);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.savebtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.parttxt);
            this.panel1.Controls.Add(this.locationtxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nametxt);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 496);
            this.panel1.TabIndex = 0;
            // 
            // notify
            // 
            this.notify.AutoSize = true;
            this.notify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notify.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notify.Location = new System.Drawing.Point(122, 384);
            this.notify.Name = "notify";
            this.notify.Size = new System.Drawing.Size(130, 21);
            this.notify.TabIndex = 103;
            this.notify.Text = "Notify Participants";
            this.notify.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 277);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(400, 33);
            this.dateTimePicker1.TabIndex = 102;
            this.dateTimePicker1.Value = new System.DateTime(2018, 2, 15, 13, 0, 0, 0);
            // 
            // savebtn
            // 
            this.savebtn.Activecolor = System.Drawing.Color.White;
            this.savebtn.BackColor = System.Drawing.Color.White;
            this.savebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.savebtn.BorderRadius = 0;
            this.savebtn.ButtonText = "Save New Event";
            this.savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebtn.DisabledColor = System.Drawing.Color.Gray;
            this.savebtn.Iconcolor = System.Drawing.Color.Transparent;
            this.savebtn.Iconimage = global::BrgyMis2.Properties.Resources.icons8_Checkmark_32px;
            this.savebtn.Iconimage_right = null;
            this.savebtn.Iconimage_right_Selected = null;
            this.savebtn.Iconimage_Selected = null;
            this.savebtn.IconMarginLeft = 0;
            this.savebtn.IconMarginRight = 0;
            this.savebtn.IconRightVisible = true;
            this.savebtn.IconRightZoom = 0D;
            this.savebtn.IconVisible = true;
            this.savebtn.IconZoom = 50D;
            this.savebtn.IsTab = false;
            this.savebtn.Location = new System.Drawing.Point(466, 441);
            this.savebtn.Margin = new System.Windows.Forms.Padding(20);
            this.savebtn.Name = "savebtn";
            this.savebtn.Normalcolor = System.Drawing.Color.White;
            this.savebtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(236)))));
            this.savebtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(68)))), ((int)(((byte)(200)))));
            this.savebtn.selected = false;
            this.savebtn.Size = new System.Drawing.Size(160, 35);
            this.savebtn.TabIndex = 101;
            this.savebtn.Text = "Save New Event";
            this.savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savebtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(68)))), ((int)(((byte)(200)))));
            this.savebtn.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(62)))), ((int)(((byte)(74)))));
            this.label6.Location = new System.Drawing.Point(122, 319);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 100;
            this.label6.Text = "Participants *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(62)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(121, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 97;
            this.label1.Text = "Date *";
            // 
            // parttxt
            // 
            this.parttxt.BackColor = System.Drawing.Color.Transparent;
            this.parttxt.BorderRadius = 0;
            this.parttxt.DisabledColor = System.Drawing.Color.Gray;
            this.parttxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parttxt.ForeColor = System.Drawing.Color.White;
            this.parttxt.Items = new string[] {
        "All",
        "Residents",
        "Voters",
        "Senior Citizens",
        "Barangay Officials"};
            this.parttxt.Location = new System.Drawing.Point(122, 341);
            this.parttxt.Margin = new System.Windows.Forms.Padding(5);
            this.parttxt.Name = "parttxt";
            this.parttxt.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(62)))), ((int)(((byte)(74)))));
            this.parttxt.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(62)))), ((int)(((byte)(74)))));
            this.parttxt.selectedIndex = 0;
            this.parttxt.Size = new System.Drawing.Size(400, 35);
            this.parttxt.TabIndex = 96;
            // 
            // locationtxt
            // 
            this.locationtxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(236)))));
            this.locationtxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(62)))), ((int)(((byte)(74)))));
            this.locationtxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(236)))));
            this.locationtxt.BorderThickness = 1;
            this.locationtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.locationtxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(62)))), ((int)(((byte)(74)))));
            this.locationtxt.isPassword = false;
            this.locationtxt.Location = new System.Drawing.Point(122, 217);
            this.locationtxt.Margin = new System.Windows.Forms.Padding(5);
            this.locationtxt.Name = "locationtxt";
            this.locationtxt.Size = new System.Drawing.Size(400, 35);
            this.locationtxt.TabIndex = 94;
            this.locationtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(62)))), ((int)(((byte)(74)))));
            this.label4.Location = new System.Drawing.Point(119, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 93;
            this.label4.Text = "Location *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(62)))), ((int)(((byte)(74)))));
            this.label3.Location = new System.Drawing.Point(119, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 92;
            this.label3.Text = "Event Name *";
            // 
            // nametxt
            // 
            this.nametxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(236)))));
            this.nametxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(62)))), ((int)(((byte)(74)))));
            this.nametxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(236)))));
            this.nametxt.BorderThickness = 1;
            this.nametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nametxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(62)))), ((int)(((byte)(74)))));
            this.nametxt.isPassword = false;
            this.nametxt.Location = new System.Drawing.Point(122, 142);
            this.nametxt.Margin = new System.Windows.Forms.Padding(5);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(400, 35);
            this.nametxt.TabIndex = 91;
            this.nametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::BrgyMis2.Properties.Resources.icons8_Cancel_32px;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(611, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 10, 10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(68)))), ((int)(((byte)(200)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(646, 50);
            this.label2.TabIndex = 90;
            this.label2.Text = "Add New Event";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addEventForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addEventForm";
            this.Load += new System.EventHandler(this.addEventForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox locationtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox nametxt;
        private Bunifu.Framework.UI.BunifuDropdown parttxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuFlatButton savebtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox notify;
    }
}