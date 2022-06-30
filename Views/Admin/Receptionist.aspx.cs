using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicMS.Views.Admin
{
    public partial class Receptionist : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowReceptionist();

        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            
        }
        private void ShowReceptionist()
        {
            string Query = "Select * from ReceptionistTb";
            RecGV.DataSource = Con.GetData(Query);
            RecGV.DataBind();
        }
        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {

                string RName = RecNameTb.Value;
                string REmail = RecEmailTb.Value;
                string RPhone = RecPhoneTb.Value;
                string RGen = GenderCb.Value;
                string RDOB = DOBTb.Value;
                string RAdd = AddressTb.Value;
                string RPassword = PasswordTb.Value;

                string Query = "insert into ReceptionistTb values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";

                Query = string.Format(Query, RName, REmail, RPhone, RGen, RDOB, RAdd, RPassword);
                Con.SetData(Query);
                ShowReceptionist();
                ErrMsg.InnerText = "New Receptionist Record Added!!";

                RecNameTb.Value = "";
                RecEmailTb.Value = "";
                RecPhoneTb.Value = "";
                GenderCb.Value = "";
                DOBTb.Value = "";
                AddressTb.Value = "";
                PasswordTb.Value = "";



            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;

                throw;
            }
        }
        int key = 0;
        protected void RecGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecNameTb.Value = RecGV.SelectedRow.Cells[2].Text;
            RecEmailTb.Value = RecGV.SelectedRow.Cells[3].Text; ;
            RecPhoneTb.Value = RecGV.SelectedRow.Cells[4].Text; ;
            GenderCb.Value = RecGV.SelectedRow.Cells[5].Text; ;
            DOBTb.Value = RecGV.SelectedRow.Cells[6].Text; ;
            AddressTb.Value = RecGV.SelectedRow.Cells[7].Text; ;
            PasswordTb.Value = RecGV.SelectedRow.Cells[8].Text; ;

            if (RecNameTb.Value == "")
            {
                key = 0;
            }

            else
            {
                key = Convert.ToInt32(RecGV.SelectedRow.Cells[1].Text);
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(RecNameTb.Value == "")
                {
                    ErrMsg.InnerText = "Please Select the Receptionist";
                }
                else
                {
                    string Query = "delete from ReceptionistTb where RecId = {0}";
                    Query = string.Format(Query, RecGV.SelectedRow.Cells[1].Text);
                    
                    Con.SetData(Query);
                    ShowReceptionist();
                    
                    ErrMsg.InnerText = "Selected Receptionist Deleted!!!";
                    key = 0;
                    
                    RecNameTb.Value = "";
                    RecEmailTb.Value = "";
                    RecPhoneTb.Value = "";
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
                if(RecNameTb.Value == "")
                {
                    ErrMsg.InnerText = "Please Select the Receptionist!!";
                }
                else 
                {
                    string RName = RecNameTb.Value;
                    string REmail = RecEmailTb.Value;
                    string RPhone = RecPhoneTb.Value;
                    string RGen = GenderCb.Value;
                    string RDOB = DOBTb.Value;
                    string RAdd = AddressTb.Value;
                    string RPassword = PasswordTb.Value;

                    string Query = "update ReceptionistTb set RecName='{0}',RecEmail='{1}',RecPhone='{2}',RecGen='{3}',RecDOB='{4}',RecAdd='{5}',RecPassword='{6}'";

                    Query = string.Format(Query, RName, REmail, RPhone, RGen, RDOB, RAdd, RPassword, RecGV.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowReceptionist();
                    ErrMsg.InnerText = " Receptionist Record Updated!!";

                    RecNameTb.Value = "";
                    RecEmailTb.Value = "";
                    RecPhoneTb.Value = "";
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