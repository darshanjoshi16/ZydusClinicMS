using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicMS.Views.Receptionist
{
    
    public partial class Patients : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {

            Con = new Models.Functions();
            ShowPatients();

        }

        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        private void ShowPatients()
        {
            string Query = "Select * from PatientTb";
            PatGV.DataSource = Con.GetData(Query);
            PatGV.DataBind();
        }
        protected void AddBtn_Click(object sender, EventArgs e)
        {

            try
            {
                string User = Session["uid"] as string;
                string PName = PatNameTb.Value;
                string PPhone = PatPhoneTb.Value;
                string PGen = GenderCb.Value;
                string PDOB = DOBTb.Value;
                string PAdd = AddressTb.Value;
                string PAllergies = PatAllergiesTb.Value;
                

                string Query = "insert into PatientTb values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";

                Query = string.Format(Query, PName, PPhone, PGen, PDOB, PAdd, PAllergies,User);
                Con.SetData(Query);
                ShowPatients();
                ErrMsg.InnerText = "New Patient Record Added!!";

                PatNameTb.Value = "";
                PatPhoneTb.Value = "";
                GenderCb.Value = "";
                DOBTb.Value = "";
                AddressTb.Value = "";
                PatAllergiesTb.Value = "";



            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }

        }
        int key = 0;
        protected void PatGV_SelectedIndexChanged1(object sender, EventArgs e)
        {
            PatNameTb.Value = PatGV.SelectedRow.Cells[2].Text;
            PatPhoneTb.Value = PatGV.SelectedRow.Cells[3].Text;
            GenderCb.Value = PatGV.SelectedRow.Cells[4].Text;
            DOBTb.Value = PatGV.SelectedRow.Cells[5].Text;
            AddressTb.Value = PatGV.SelectedRow.Cells[6].Text;
            PatAllergiesTb.Value = PatGV.SelectedRow.Cells[7].Text;

            if (PatNameTb.Value == "")
            {
                key = 0;
            }

            else
            {
                key = Convert.ToInt32(PatGV.SelectedRow.Cells[1].Text);
            }
        }



        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PatNameTb.Value == "")
                {
                    ErrMsg.InnerText = "Please Select the Patient!!";
                }
                else
                {

                    string PName = PatNameTb.Value;
                    string PPhone = PatPhoneTb.Value;
                    string PGen = GenderCb.Value;
                    string PDOB = DOBTb.Value;
                    string PAdd = AddressTb.Value;
                    string PAllergies = PatAllergiesTb.Value;

                    string Query = "update PatientTb set PatName='{0}',PatPhone='{1}',PatGen='{2}',PatDOB='{3}',PatAdd='{4}',PatAllergies ='{5}'";

                    Query = string.Format(Query, PName, PPhone, PGen, PDOB, PAdd, PAllergies, PatGV.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowPatients();
                    ErrMsg.InnerText = " Patient Record Updated!!";

                    PatNameTb.Value = "";
                    PatPhoneTb.Value = "";
                    GenderCb.Value = "";
                    DOBTb.Value = "";
                    AddressTb.Value = "";
                    PatAllergiesTb.Value = "";

                }

            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;

                throw;
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PatNameTb.Value == "")
                {
                    ErrMsg.InnerText = "Please Select the Patient!!";
                }
                else
                {
                    string Query = "delete from PatientTb where PatId = {0}";
                    Query = string.Format(Query, PatGV.SelectedRow.Cells[1].Text);

                    Con.SetData(Query);
                    ShowPatients();

                    ErrMsg.InnerText = "Selected Patient Deleted!!!";
                    key = 0;

                    PatNameTb.Value = "";
                    PatPhoneTb.Value = "";
                    GenderCb.Value = "";
                    DOBTb.Value = "";
                    AddressTb.Value = "";
                    PatAllergiesTb.Value = "";


                }



            }
            catch (Exception ex)
            {

                ErrMsg.InnerText = ex.Message;
            }
        }

        
    }
}