using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunifu.Framework.UI;
using System.Windows.Forms;
namespace BrgyMis2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dragctrl.TargetControl = this.headerpanel;
            elipse.ElipseRadius = 20;
            elipse.TargetControl = this;
        }
        function f = new function();
        BunifuDragControl dragctrl = new BunifuDragControl();
        BunifuElipse elipse = new BunifuElipse();

        private static Form1 instance;

        public static Form1 Instance
        {
            get
            {
                if (instance == null)
                    instance = new Form1();
                return instance;
            }
        }

        private void MaximizeForm(){
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            f.centerUserpanel(menupanel);
            f.centerUserpanel(f.getpanel(mainpanel));
            f.getpanel(mainpanel).Top = 20;

        }
        public void CollapseHeader()
        {
            if (headerpanel.Height == 40)
            {
                f.Expand(headerpanel, 400, "Height", 400);
                expandbtn.Image = Properties.Resources.icons8_Chevron_Up_32px;
               
            }
            else
            {
                f.Expand(headerpanel, 400, "Height", 40);
                expandbtn.Image = Properties.Resources.icons8_Chevron_Down_32px;
            }
            f.getpanel(mainpanel).Top = 20;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MaximizeForm();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CollapseHeader();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(dashboardUserControl.Instance);
            f.centerUserpanel(dashboardUserControl.Instance);
        }

        private void p_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(residentUserControl.Instance);
            f.centerUserpanel(residentUserControl.Instance);
        }

        private void mainpanel_Click(object sender, EventArgs e)
        {
            CollapseHeader();
        }

        private void programbtn_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(programUserControl.Instance);
            f.centerUserpanel(programUserControl.Instance);
        }

        private void headerpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(eventUserControl.Instance);
            f.centerUserpanel(eventUserControl.Instance);
           
        }

        private void o_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(applicationUserControl.Instance);
            f.centerUserpanel(applicationUserControl.Instance);
        }

        private void r_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(officialsUserControl.Instance);
            f.centerUserpanel(officialsUserControl.Instance);
        }
    }
}
