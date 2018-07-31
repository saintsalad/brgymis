using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
using System.Drawing;
using System.IO;
using Microsoft.VisualBasic;
namespace BrgyMis2
{
    class function
    {
        public string[] tbl_residentinfo ={
        "residentId","fname","mname","lname","ext","placeOfBirth","age","gender","bday","isVoter","civilStatus","nationality","contact","residentImage"
                                          };

        
        List<string> purokList = new List<string>(){
            "Purok 1", "Purok 2", "Purok 3", "Purok 4", "Purok 5", "Purok 6", "Purok 7"
        };
        List<string> sitioList = new List<string>() {
            "Sitio Veterans", "Sitio Pugot","Sitio Kumunoy","Sitio Bakal","Sitio Rolling Hills"
        };
        List<string> subdivisionList = new List<string>() { 
            "Bona Subdivision","Violago Homes","Filinvest 2","Filenvest Heights","Spring Country","Spring Heights 1","Spring Heights 2", "Spring Valley","Violago Parkwood Hills Subdivision","Mountain View"
        };
        List<string> villagesList = new List<string>()
        {
            "Tagumpay Village", "Humanity Village", "Country Homes"
        };
        List<string> compoundList = new List<string>() { 
            "Sipna","Bakas","Sulyap ng Pag-asa Housing","UPNA"
        };
        List<string> othersList = new List<string>() { 
            "BASECO","Paltoc-Country Homes","Filside","Brook Side"
        };


        public List<string> purokAndOthers(int type)
        {
            switch (type)

            {
               case 0:
                    return purokList;
               case 1:
                    return sitioList;

               case 2:
                    return subdivisionList;

               case 3:
                    return villagesList;

               case 4:
                    return compoundList;

               case 5:
                    return othersList;
                default:
                   return null;
            }
        }

        public void centerUserpanel(Control c)
        {
            //  int cheigth = c.Parent.Height / 2;
            int cwidth = c.Parent.Width / 2;
            //   int h = cheight - (c.heigth / 2);
            int w = cwidth - (c.Width / 2);
            c.Left = w;
        }
        public void Expand(Control obj, int speed, string property, int value)
        {
            Transition t = new Transition(new TransitionType_CriticalDamping(speed));
            t.add(obj, property, value);
            t.run();
        }
        public Control getpanel(Control parent)
        {
            try
            {
                foreach (Control c in parent.Controls)
                {
                    return c;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return null;
        }


        public byte[] imagetoByte(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] arr = ms.GetBuffer();
            return arr;
        }
        public Image byteToImage(byte[] bite)
        {
            MemoryStream ms = new MemoryStream(bite);
            return System.Drawing.Image.FromStream(ms);
        }
        public string generateId(int count)
        {
            string output = "";
            Random rd = new Random();
            string c = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] arr = c.ToCharArray();
            for (int i = 1; i < count; i++)
            {
                int x = rd.Next(0, arr.Length);
                output += arr[x];
            }
            return output;
        }

        public int CalculateAge(string dateOfBirth)
        {
            TimeSpan ts = DateTime.Now - Convert.ToDateTime(dateOfBirth);
            int age = Convert.ToInt32(ts.Days) / 365;
            return age;
        }

        public void KeyPressNumOnly(KeyPressEventArgs e, string input, int length){
            if (input.Length >= length)
            {
                if(e.KeyChar != ControlChars.Back){
                    e.Handled = true;
                }
            }
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        public object check(dynamic input,object ret)
        {
            if (input == null || input == "" || input == string.Empty)
            {
                return ret;
            }
            else {
                return input;
            }
        }
        public string ucf(string str)
        {
            str = char.ToUpper(str[0]) + str.Substring(1);
            return str.Trim();
        }



        public void columnsToListbox(dynamic drp, dynamic grd)
        {
            try
            {
                drp.Clear();

                for (int i = 0; i <= grd.Columns.Count -1 ; i++){
                    drp.AddItem(grd.Columns[i].Name);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void SetSelectedValue(dynamic drp, string value)
        {

            for (int i = 0; i <= drp.Items.Length- 1; i++)
			{
               

                if (value == drp.Items[i])
                {
                    drp.selectedIndex = i;
                    break;
                }
			}
        }

    }
}
