using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace BrgyMis2
{
    public partial class addProgramForm : Form
    {
        public addProgramForm()
        {
            InitializeComponent();
        }
        database db = new database();
        function fc = new function();
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public Image img { get; set; }

        private void update()
        {
            nametxt.Text = name;
            desctxt.Text = description;
            categorytxt.Text = category;
            bannerimg.Image = img;
            savebtn.Text = "Save Changes";
        }

        //private void update(string id)
        //{
        //    if (id != string.Empty)
        //    {
        //        string[] fields = { "name", "description", "category", "bannerImage" };
        //       Dictionary<string,string> result = db.fetchRecordWithCondition("tbl_programs",fields,"id", id);
        //       nametxt.Text = result["name"];
        //       desctxt.Text = result["description"];
        //       categorytxt.Text = result["category"];

        //    }
        //}


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bannerimg.Image = Image.FromFile(ofd.FileName);

            }
        }

        private void bannerimg_Click(object sender, EventArgs e)
        {

        }

        private bool validation()
        {
            if (nametxt.Text == "" || desctxt.Text == "" || categorytxt.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void clear()
        {
            nametxt.Text = "";
            desctxt.Text = "";
            categorytxt.Text = "";
            bannerimg.Image = Properties.Resources.logo;
        }


        private void savedata()
        {
            if (validation())
            {
                bool result = db.insertProgram(fc.ucf(nametxt.Text), fc.ucf(categorytxt.Text), fc.ucf(desctxt.Text), fc.imagetoByte(bannerimg.Image));
                if (result)
                {
                    MessageBox.Show("save");
                    clear();
                    programUserControl.Instance.loaddata();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Please fill up all of the required fields");
            }
        }

        private void updatedata()
        {
            if (validation())
            {
                bool result = db.updateProgram(fc.ucf(nametxt.Text), fc.ucf(categorytxt.Text), fc.ucf(desctxt.Text), fc.imagetoByte(bannerimg.Image), id);
                if (result)
                {
                    MessageBox.Show("updated");
                    programUserControl.Instance.loaddata();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Please fill up all of the required fields");
            }
        }


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                savedata();

            }
            else
            {
                updatedata();
            }
            programUserControl.Instance.loaddata();

        }

        private void addProgramForm_Shown(object sender, EventArgs e)
        {
            if (id != null)
            {
                update();
            }
        }
    }
}
