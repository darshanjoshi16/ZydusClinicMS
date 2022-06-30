using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicMS.Views.Admin
{
    public partial class Laboratorians : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowLaboratorians();

        }

        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        private void ShowLaboratorians()
        {
            string Query = "Select * from LabratorianTb";
            LabGV.DataSource = Con.GetData(Query);
            LabGV.DataBind();
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {

                string LName = LabNameTb.Value;
                string LPhone = LabPhoneTb.Value;
                string LEmail = LabEmailTb.Value;
                string LGen = GenderCb.Value;
                string LDOB = DOBTb.Value;
                string LAdd = AddressTb.Value;
                string LPassword = PasswordTb.Value;
                

                string Query = "insert into LabratorianTb values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";

                Query = string.Format(Query, LName, LEmail, LPhone, LGen, LDOB, LAdd,LPassword);
                Con.SetData(Query);
                ShowLaboratorians();
                ErrMsg.InnerText = "New labratorian Record Added!!";

                LabNameTb.Value = "";
                LabPhoneTb.Value = "";
                LabEmailTb.Value = "";
                GenderCb.Value = "";
                DOBTb.Value = "";
                AddressTb.Value = "";
                PasswordTb.Value = "";
               
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }



        }

        int key = 0;
        protected void LabGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabNameTb.Value = LabGV.SelectedRow.Cells[2].Text;
            LabEmailTb.Value = LabGV.SelectedRow.Cells[3].Text;
            LabPhoneTb.Value= LabGV.SelectedRow.Cells[4].Text;
            GenderCb.Value = LabGV.SelectedRow.Cells[5].Text;
            DOBTb.Value = LabGV.SelectedRow.Cells[6].Text;
            AddressTb.Value = LabGV.SelectedRow.Cells[7].Text;
            PasswordTb.Value = LabGV.SelectedRow.Cells[8].Text;

            if (LabNameTb.Value == "")
            {
                key = 0;
            }

            else
            {
                key = Convert.ToInt32(LabGV.SelectedRow.Cells[1].Text);
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (LabNameTb.Value == "")
                {
                    ErrMsg.InnerText = "Please Select the Labratorian!!";
                }
                else
                {
                    string Query = "delete from LabratorianTb where LabId = {0}";
                    Query = string.Format(Query, LabGV.SelectedRow.Cells[1].Text);

                    Con.SetData(Query);
                    ShowLaboratorians();

                    ErrMsg.InnerText = "Selected Laboratorian Deleted!!!";
                    key = 0;

                    LabNameTb.Value = "";
                    LabPhoneTb.Value = "";
                    LabEmailTb.Value = "";
                    GenderCb.Value = "";
                    DOBTb.Value = "";
                    AddressTb.Value = "";
                    PasswordTb.Value = "";

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
                if (LabNameTb.Value == "")
                {
                    ErrMsg.InnerText = "Please Select the Laboratorian!!";
                }
                else
                {
                    string LName = LabNameTb.Value;
                    string LPhone = LabPhoneTb.Value;
                    string LEmail = LabEmailTb.Value;
                    string LGen = GenderCb.Value;
                    string LDOB = DOBTb.Value;
                    string LAdd = AddressTb.Value;
                    string LPassword = PasswordTb.Value;

                    string Query = "update LabratorianTb set LabName='{0}',LabEmail='{1}',LabPhone='{2}',LabGen='{3}',LabDOB='{4}',LabAdd='{5}',LabPassword='{6}'";

                    Query = string.Format(Query, LName,LEmail,LPhone,LGen, LDOB, LAdd, LPassword, LabGV.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    
                    ShowLaboratorians();
                    ErrMsg.InnerText = "Laboratorian Record Updated!!";

                    LabNameTb.Value = "";
                    LabPhoneTb.Value = "";
                    LabEmailTb.Value = "";
                    GenderCb.Value = "";
                    DOBTb.Value = "";
                    AddressTb.Value = "";
                    PasswordTb.Value = "";
                }

            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;

                throw;
            }
        }
    }
}