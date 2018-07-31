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
    public partial class applicationUserControl : UserControl
    {
        public applicationUserControl()
        {
            InitializeComponent();
        }
        private static applicationUserControl instance;
        database db = new database();
        function fc = new function();

        public static applicationUserControl Instance
        {
            get
            {
                if (instance == null)
                    instance = new applicationUserControl();
                return instance;
            }
        }

        private void applicationUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
