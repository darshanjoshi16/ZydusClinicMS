using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicMS.Views.Laboratorian
{
    public partial class LabTest : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowLabTests();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        private void ShowLabTests()
        {
            string Query = "Select * from LabTestTb";
            LabTestGV.DataSource = Con.GetData(Query);
            LabTestGV.DataBind();
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {

                string TName = LabTestNameTb.Value;
                string TCost = LabTestCostTb.Value;
                string User = Session["uid"] as string;


                string Query = "insert into LabTestTb values ('{0}','{1}','{2}')";

                Query = string.Format(Query, TName, TCost,User);
                Con.SetData(Query);
                ShowLabTests();
                ErrMsg.InnerText = "New Lab Test Record Added!!";

                LabTestNameTb.Value = "";
                LabTestCostTb.Value = "";
                

            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }

            
            }

        int key = 0;
        protected void LabTestGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabTestNameTb.Value = LabTestGV.SelectedRow.Cells[2].Text;
            LabTestCostTb.Value = LabTestGV.SelectedRow.Cells[3].Text; 

            if (LabTestNameTb.Value == "")
            {
                key = 0;
            }

            else
            {
                key = Convert.ToInt32(LabTestGV.SelectedRow.Cells[1].Text);
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (LabTestNameTb.Value == "")
                {
                    ErrMsg.InnerText = "Please Select the Test Record!!";
                }
                else
                {
                    string Query = "delete from LabTestTb where TestId = {0}";
                    Query = string.Format(Query, LabTestGV.SelectedRow.Cells[1].Text);

                    Con.SetData(Query);
                    ShowLabTests();

                    ErrMsg.InnerText = "Selected Test Record Deleted!!!";
                    key = 0;

                    LabTestNameTb.Value = "";
                    LabTestCostTb.Value = "";
                    

                }


            }
            catch (Exception ex)
            {

                ErrMsg.InnerText = ex.Message;
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (LabTestNameTb.Value == "")
                {
                    ErrMsg.InnerText = "Please Select the Test Record!!";
                }
                else
                {
                    string TName = LabTestNameTb.Value;
                    string TCost = LabTestCostTb.Value;

                    string Query = "update LabTestTb set TestName='{0}',TestCost='{1}' where TestId = {2}";

                    Query = string.Format(Query,TName,TCost, LabTestGV.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);

                    ShowLabTests();
                    ErrMsg.InnerText = "Test Record Updated!!";

                    LabTestNameTb.Value = "";
                    LabTestCostTb.Value = "";
                    
                }

            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;

               
            }
        }
    }
    
}