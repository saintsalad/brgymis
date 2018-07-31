using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrgyMis2
{
    public partial class eventUserControl : UserControl
    {
        public eventUserControl()
        {
            InitializeComponent();
        }
        private static eventUserControl instance;
        database db = new database();
        function fc = new function();

        public static eventUserControl Instance
        {
            get
            {
                if (instance == null)
                    instance = new eventUserControl();
                return instance;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            addEventForm f = new addEventForm();
            f.Show();
        }

        public void loaddata()
        {
            string[] fields = new string[]
            {
               "id as ID", "name as Name", "location as Location", "dateTime as Schedule" ,"participants as Participant","isNotify as Notify", "dateCreated as DateCreated"
            };
            mytable.DataSource = db.tableLoad("tbl_events", fields);
            
        }
        private void eventUserControl_Load(object sender, EventArgs e)
        {
            loaddata();
            fc.columnsToListbox(filterdrp, mytable);
        }

        private void searchtxt_OnValueChanged(object sender, EventArgs e)
        {
            if (!(filterdrp.selectedIndex <= -1))
            {
                try
                {
                    DataView dv = new DataView(db.table);
                    dv.RowFilter = string.Format("CONVERT({0}, System.String) Like '%{1}%'", filterdrp.selectedValue, searchtxt.Text.ToString());
                    mytable.DataSource = dv;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            addEventForm f = new addEventForm();
            f.id = mytable.SelectedCells[0].Value.ToString();
            f.name = mytable.SelectedCells[1].Value.ToString();
            f.location = mytable.SelectedCells[2].Value.ToString();
            f.datetime = mytable.SelectedCells[3].Value.ToString();
            f.participant = mytable.SelectedCells[4].Value.ToString();
            f.isNotify = mytable.SelectedCells[5].Value.ToString();
            f.Show();

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            confirmationBox f = new confirmationBox();
            if (f.ShowDialog() == DialogResult.OK)
            {
                string id =mytable.SelectedCells[0].Value.ToString();
                if (db.deleteRecord("tbl_events", "id", id))
                {
                    loaddata();
                    MessageBox.Show("Deleted");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
