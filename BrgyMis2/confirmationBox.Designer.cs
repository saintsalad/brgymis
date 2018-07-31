namespace BrgyMis2
{
    partial class confirmationBox
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.savebtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.savebtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 215);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::BrgyMis2.Properties.Resources.icons8_Cancel_32px;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(455, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 10, 10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // savebtn
            // 
            this.savebtn.Activecolor = System.Drawing.Color.White;
            this.savebtn.BackColor = System.Drawing.Color.White;
            this.savebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.savebtn.BorderRadius = 0;
            this.savebtn.ButtonText = "Continue";
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
            this.savebtn.Location = new System.Drawing.Point(267, 160);
            this.savebtn.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.savebtn.Name = "savebtn";
            this.savebtn.Normalcolor = System.Drawing.Color.White;
            this.savebtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(236)))));
            this.savebtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(68)))), ((int)(((byte)(200)))));
            this.savebtn.selected = false;
            this.savebtn.Size = new System.Drawing.Size(102, 35);
            this.savebtn.TabIndex = 102;
            this.savebtn.Text = "Continue";
            this.savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savebtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(68)))), ((int)(((byte)(200)))));
            this.savebtn.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Cancel";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::BrgyMis2.Properties.Resources.icons8_Delete_32px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(379, 160);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5, 20, 20, 20);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(236)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(68)))), ((int)(((byte)(200)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(91, 35);
            this.bunifuFlatButton1.TabIndex = 103;
            this.bunifuFlatButton1.Text = "Cancel";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(68)))), ((int)(((byte)(200)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(62)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(3, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 61);
            this.label1.TabIndex = 104;
            this.label1.Text = "Please confirm your action.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(88)))), ((int)(((byte)(220)))));
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 105;
            this.label2.Text = "System Message";
            // 
            // confirmationBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(500, 225);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "confirmationBox";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "confirmationBox";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton savebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}