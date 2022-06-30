using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicMS.Views.Doctors
{
    public partial class Prescription : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowPres();
            GetTest();
            GetPatient();
        }

        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        private void ShowPres()
        {
            string Query = "Select * from PresTb";
            PreGV.DataSource = Con.GetData(Query);
            PreGV.DataBind();
        }

        //Get the lab test
        private void GetTest()
        {
            string Query = "Select * from LabTestTb";
            TestCb.DataTextField = Con.GetData(Query).Columns["TestName"].ToString();
            TestCb.DataValueField = Con.GetData(Query).Columns["TestID"].ToString();
            TestCb.DataSource = Con.GetData(Query);
            TestCb.DataBind();
        }
        private void GetPatient()
        {
            string Query = "Select * from PatientTb";
            PatientCb.DataTextField = Con.GetData(Query).Columns["PatName"].ToString();
            PatientCb.DataValueField = Con.GetData(Query).Columns["PatID"].ToString();
            PatientCb.DataSource = Con.GetData(Query);
            PatientCb.DataBind();
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string User = Session["uid"] as string;
                string Patient = PatientCb.SelectedValue.ToString();
                string Medicines = MedicinesTb.Value;
                string Test = TestCb.SelectedValue.ToString();
                string Cost = CostTb.Value;




                string Query = "insert into PresTb values ({0},{1},'{2}',{3},'{4}')";

                Query = string.Format(Query, User, Patient, Medicines, Test, Cost);
                Con.SetData(Query);
                ShowPres();
                ErrMsg.InnerText = "New Prescription Added!!";

                MedicinesTb.Value = "";
                CostTb.Value = "";
                PatientCb.SelectedIndex = -1;
                TestCb.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;  
            }
            


        }
            
}
    }   
