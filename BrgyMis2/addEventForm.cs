using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrgyMis2
{
    public partial class addEventForm : Form
    {
        public addEventForm()
        {
            InitializeComponent();
        }
        database db = new database();
        function fc = new function();
        public string id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public string datetime { get; set; }
        public string participant { get; set; }
        public string isNotify { get; set; }


        private void update()
        {
            nametxt.Text = name;
            locationtxt.Text = location;
            dateTimePicker1.Value = Convert.ToDateTime(datetime);
            fc.SetSelectedValue(parttxt, participant);
            notify.CheckState = (isNotify == "Yes") ? CheckState.Checked : CheckState.Unchecked;
            savebtn.Text = "Save Changes";
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private int validation()
        {
            if (nametxt.Text == "" || locationtxt.Text == "" || dateTimePicker1.Value == null)
            {
                return 0;
            }
            else
            {
                if (dateTimePicker1.Value < DateTime.Now)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        private void updatedata()
        {
            Dictionary<string, dynamic> fields = new Dictionary<string, dynamic>()
            {
                {"name", nametxt.Text},
                {"location", locationtxt.Text},
                {"participants", parttxt.selectedValue},
                {"dateTime", dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss")},
                {"isNotify", (notify.CheckState == CheckState.Checked) ? 1 : 0 }
            };
            Dictionary<string, dynamic> where = new Dictionary<string, dynamic>()
            {
                {"id", id}
            };
            bool result = db.updateRecord("tbl_events", where, fields);
            if (result)
            {
                MessageBox.Show("Updated");
                eventUserControl.Instance.loaddata();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void savedata()
        {
            Dictionary<string, dynamic> fields = new Dictionary<string, dynamic>()
            {
                {"name", nametxt.Text},
                {"location", locationtxt.Text},
                {"participants", parttxt.selectedValue},
                {"dateTime", dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss")},
                {"isNotify", (notify.CheckState == CheckState.Checked) ? 1 : 0 }
            };
            bool result = db.insertRecord("tbl_events", fields);

            if (result)
            {
                MessageBox.Show("Save");
                eventUserControl.Instance.loaddata();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (validation() == 1)
            {
                if (id != null)
                {
                    updatedata();
                }
                else
                {
                    savedata();

                }
            }
            else if(validation() == 2)
            {
                MessageBox.Show("Error Date");
            }
            else
            {
                MessageBox.Show("Please fill up all of the required fields");

            }
            
        }

        private void addEventForm_Load(object sender, EventArgs e)
        {
            if (id != null)
            {
                update();
            }
            else
            {

            }
        }
    }
}
