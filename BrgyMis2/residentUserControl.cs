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
    public partial class residentUserControl : UserControl
    {
        public residentUserControl()
        {
            InitializeComponent();

        }
        private static residentUserControl instance;
        database db = new database();
        function fc = new function();
        public static residentUserControl Instance
        {
            get
            {
                if (instance == null)
                    instance = new residentUserControl();
                return instance;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            addResidentForm f = new addResidentForm();
            f.Show();
        }

        private void residentUserControl_Paint(object sender, PaintEventArgs e)
        {
           
           
        }


        public void loaddata()
        {
            string[] fields = new string[]
            {
                "residentId as ID", "fname as Firstname","mname as Middlename", "lname as Lastname", "placeOfBirth as Birthplace", "age as Age", "gender as Gender", "bday as Birthdate", "isVoter as Voter", "civilStatus as CivilStatus", "nationality as Nationality", "contact as Contact"
            };
            mytable.DataSource = db.tableLoad("tbl_residentinfo", fields);
        }

        private void residentUserControl_Load(object sender, EventArgs e)
        {
            try
            {
                loaddata();
                fc.columnsToListbox(filterdrp, mytable);
                
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void searchtxt_OnValueChanged(object sender, EventArgs e)
        {
            if (!(filterdrp.selectedIndex <= -1))
            {
                try
                {
                    DataView dv = new DataView(db.table);
                    dv.RowFilter = string.Format("CONVERT({0}, System.String) Like '%{1}%'", filterdrp.selectedValue, searchtxt.Text);
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
            addResidentForm f = new addResidentForm();
            f.id = mytable.SelectedCells[0].Value.ToString();
            f.Show();
        }

    }
}
