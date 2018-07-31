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
using System.Threading;
namespace BrgyMis2
{
    public partial class addResidentForm : Form
    {
        public addResidentForm()
        {
            InitializeComponent();
            
            
        }
        function fc = new function();
        //Timer t = new Timer();
        database db = new database();
        public string id { get; set; }
        string area = "";

        public void update()
        {
            if (id != null)
            {
                string[] info = {
                                      "fname","mname","lname","ext","placeOfBirth",
                                      "age", "gender", "bday", "isVoter", "civilStatus",
                                      "nationality", "contact"
                                  };
                Dictionary<string, dynamic> inforesult = db.fetchRecordWithCondition("tbl_residentinfo", info, "residentId", id);
                fnametxt.Text = inforesult["fname"];
                mnametxt.Text = inforesult["mname"];
                lnametxt.Text = inforesult["lname"];
                exttxt.Text = inforesult["ext"];
                pobtxt.Text = inforesult["placeOfBirth"];
                dobdrp.Value = Convert.ToDateTime(inforesult["bday"]);
                fc.SetSelectedValue(genderdrp, inforesult["gender"]);
                fc.SetSelectedValue(csdrp, inforesult["civilStatus"]);
                fc.SetSelectedValue(natdrp, inforesult["nationality"]);
                fc.SetSelectedValue(isvoterdrp, inforesult["isVoter"]);
                contxt.Text = (inforesult["contact"].Length >= 10) ? inforesult["contact"].Substring(3, 10) : "";
                

                string[] address = {
                                          "houseNumber","block","lot","streetName","areaType","area"
                                      };

                Dictionary<string, dynamic> addressresult = db.fetchRecordWithCondition("tbl_address", address, "residentId", id);
                housenotxt.Text = addressresult["houseNumber"];
                blktxt.Text = addressresult["block"];
                lottxt.Text = addressresult["lot"];
                streettxt.Text = addressresult["streetName"];
                fc.SetSelectedValue(areatypedrp, addressresult["areaType"]);
            
                //bwisittttttttttttttttttt
                area = addressresult["area"];

                savebtn.Text = "Save Changes";
                label2.Text = "Update Resident";
            }
        }

        


        private void select()
        {
            areadrp.Clear();
            foreach (string item in fc.purokAndOthers(areatypedrp.selectedIndex))
            {
                areadrp.AddItem(item);
            }
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void areatypedrp_onItemSelected(object sender, EventArgs e)
        {
            select();
        }

        private void contxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            fc.KeyPressNumOnly(e, contxt.Text, 10);
        }

        private void fnametxt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void savedata()
        {
            string residentId = fc.generateId(7);
            Dictionary<string, dynamic> fields = new Dictionary<string, dynamic>(){
                {"residentId",residentId},
                {"fname", fnametxt.Text},
                {"lname", lnametxt.Text},
                {"ext", exttxt.Text},
                {"placeOfBirth", pobtxt.Text},
                {"age", fc.CalculateAge(dobdrp.Value.ToString())},
                {"gender", genderdrp.selectedValue},
                {"bday", dobdrp.Value.ToShortDateString()},
                {"isVoter", isvoterdrp.selectedValue},
                {"civilStatus", csdrp.selectedValue},
                {"nationality", natdrp.selectedValue},
                {"contact", (contxt.Text.Length == 10) ? "+63" + contxt.Text : ""}
            };

            if (db.insertRecord("tbl_residentinfo", fields))
            {

                Dictionary<string, dynamic> address = new Dictionary<string, dynamic>(){
                         {"residentId", residentId},
                         {"houseNumber", housenotxt.Text},
                         {"block", blktxt.Text},
                         {"lot", lottxt.Text},
                         {"streetName", streettxt.Text},
                         {"areaType", areatypedrp.selectedValue},
                         {"area", areadrp.selectedValue},
                     };
                db.insertRecord("tbl_address", address);

                Dictionary<string, dynamic> father = new Dictionary<string, dynamic>()
                    {
                        {"residentId", residentId},
                        {"fname", ffnametxt.Text},
                        {"mname", fmnametxt.Text},
                        {"lname", flnametxt.Text},
                        {"ext", fexttxt.Text},
                        {"isDeceased", fdecdrp.selectedValue},
                        {"relationship", "Father"},
                    };
                db.insertRecord("tbl_familybackground", father);

                Dictionary<string, dynamic> mother = new Dictionary<string, dynamic>()
                    {
                        {"residentId", residentId},
                        {"fname", ffnametxt.Text},
                        {"mname", fmnametxt.Text},
                        {"lname", flnametxt.Text},
                        {"ext", fexttxt.Text},
                        {"isDeceased", fdecdrp.selectedValue},
                        {"relationship", "Mother"},
                    };
                db.insertRecord("tbl_familybackground", mother);

                Dictionary<string, object> guardian = new Dictionary<string, object>()
                    {
                        {"residentId", residentId},
                        {"fname", ffnametxt.Text},
                        {"mname", fmnametxt.Text},
                        {"lname", flnametxt.Text},
                        {"ext", fexttxt.Text},
                        {"isDeceased", fdecdrp.selectedValue},
                        {"relationship", "Guardian"},
                    };
                db.insertRecord("tbl_familybackground", guardian);
                Dictionary<string, object> spouse = new Dictionary<string, object>()
                    {
                        {"residentId", residentId},
                        {"fname", ffnametxt.Text},
                        {"mname", fmnametxt.Text},
                        {"lname", flnametxt.Text},
                        {"ext", fexttxt.Text},
                        {"isDeceased", fdecdrp.selectedValue},
                        {"relationship", "Spouse"},
                    };
                db.insertRecord("tbl_familybackground", spouse);

                MessageBox.Show("save");
                residentUserControl.Instance.loaddata();
            }
            else
            {
                MessageBox.Show("error");

            }
        }


        private void updatedata()
        {
           // fc.SetSelectedValue(areadrp, area);

            Dictionary<string, dynamic> info = new Dictionary<string, dynamic>()
            {
                {"fname", fnametxt.Text},
                {"lname", lnametxt.Text},
                {"ext", exttxt.Text},
                {"placeOfBirth", pobtxt.Text},
                {"age", fc.CalculateAge(dobdrp.Value.ToString())},
                {"gender", genderdrp.selectedValue},
                {"bday", dobdrp.Value.ToShortDateString()},
                {"isVoter", isvoterdrp.selectedValue},
                {"civilStatus", csdrp.selectedValue},
                {"nationality", natdrp.selectedValue},
                {"contact", (contxt.Text.Length == 10) ? "+63" + contxt.Text : ""}
            };
            Dictionary<string, dynamic> winfo = new Dictionary<string, dynamic>()
            {
                {"residentId", id}
            };
            bool result = db.updateRecord("tbl_residentinfo", winfo, info);
            if (result)
            {

                //adress
                Dictionary<string, dynamic> address = new Dictionary<string, dynamic>(){
                         {"houseNumber", housenotxt.Text},
                         {"block", blktxt.Text},
                         {"lot", lottxt.Text},
                         {"streetName", streettxt.Text},
                         {"areaType", areatypedrp.selectedValue}
                        // {"area", areadrp.selectedValue}
                     };
                Dictionary<string, dynamic> waddress = new Dictionary<string, dynamic>()
            {
                {"residentId", id}
            };
                db.updateRecord("tbl_address", waddress, address);





                MessageBox.Show("Updated");
                residentUserControl.Instance.loaddata();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                savedata();
            }
            else
            {
                updatedata();
            }
        }

        private void dobdrp_onValueChanged(object sender, EventArgs e)
        {

        }

        private void addResidentForm_Shown(object sender, EventArgs e)
        {
            update();

        }


    }
}
