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
    public partial class programUserControl : UserControl
    {
        public programUserControl()
        {
            InitializeComponent();
        }
        private static programUserControl instance;
        database db = new database();
        function fc = new function();

        public static programUserControl Instance
        {
            get
            {
                if (instance == null)
                    instance = new programUserControl();
                return instance;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            addProgramForm f = new addProgramForm();
            f.Show();
        }

        public void loaddata()
        {
            string[] fields = new string[]
            {
               "id as ID", "category as Category", "name as Name", "description as Description", "bannerImage as Banner"
            };
            mytable.DataSource = db.tableLoad("tbl_programs", fields);
            mytable.RowTemplate.Height = 100;
            for (int i = 0; i < mytable.Columns.Count; i++)
                if (mytable.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)mytable.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
        }

        private void programUserControl_Load(object sender, EventArgs e)
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
           
            addProgramForm f = new addProgramForm();
            f.id = mytable.SelectedCells[0].Value.ToString();
            f.category = mytable.SelectedCells[1].Value.ToString();
            f.name = mytable.SelectedCells[2].Value.ToString();
            f.description = mytable.SelectedCells[3].Value.ToString();
            byte[] bite = (byte[])mytable.SelectedCells[4].Value;
            f.img = fc.byteToImage(bite);
            f.Show();
        }
    }
}
