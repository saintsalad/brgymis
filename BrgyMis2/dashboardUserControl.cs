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
    public partial class dashboardUserControl : UserControl
    {
        public dashboardUserControl()
        {
            InitializeComponent();
        }
        private static dashboardUserControl instance;
        public static dashboardUserControl Instance
        {
            get
            {
                if (instance == null)
                    instance = new dashboardUserControl();
                return instance;
            }
        }

        private void dashboardUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
