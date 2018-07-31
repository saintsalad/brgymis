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
    public partial class officialsUserControl : UserControl
    {
        public officialsUserControl()
        {
            InitializeComponent();
        }

        private static officialsUserControl instance;
        database db = new database();
        function fc = new function();
        public static officialsUserControl Instance
        {
            get
            {
                if (instance == null)
                    instance = new officialsUserControl();
                return instance;
            }
        }



    }
}
