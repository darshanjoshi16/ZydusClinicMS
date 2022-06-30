using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicMS.Views.Admin
{
    public partial class Doctors : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowDoctors();

        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        private void ShowDoctors()
        {
            string Query = "Select * from DoctorTb";
            DoctorsGV.DataSource = Con.GetData(Query);
            DoctorsGV.DataBind();
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {

                string DName = DocNameTb.Value;
                string DEmail = DocEmailTb.Value;
                string DPhone = DocPhoneTb.Value;
                string DGen = GenderCb.SelectedValue;
                string DDOB = DOBTb.Value;
                string DAdd = AddressTb.Value;
                string DPassword = PasswordTb.Value;
                string DExp = DocExpTb.Value;
                string DSpec = DocSpecTb.Value; 

                string Query = "insert into DoctorTb values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')";

                Query = string.Format(Query, DName, DPhone,DExp, DSpec, DGen, DDOB, DAdd, DPassword,DEmail);
                Con.SetData(Query);
                ShowDoctors();
                ErrMsg.InnerText = "New Doctor Record Added!!";

                DocNameTb.Value = "";
                DocPhoneTb.Value = "";
                DocEmailTb.Value = "";
                GenderCb.SelectedIndex = -1;
                DOBTb.Value = "";
                AddressTb.Value = "";
                PasswordTb.Value = "";
                DocExpTb.Value = "";
                DocSpecTb.Value = "";



            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }

        }

        int key = 0;

        protected void DoctorsGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            DocNameTb.Value = DoctorsGV.SelectedRow.Cells[2].Text;
            DocPhoneTb.Value = DoctorsGV.SelectedRow.Cells[3].Text;
            DocExpTb.Value = DoctorsGV.SelectedRow.Cells[4].Text; 
            DocSpecTb.Value = DoctorsGV.SelectedRow.Cells[5].Text;
            GenderCb.SelectedValue = DoctorsGV.SelectedRow.Cells[6].Text;
            DOBTb.Value = DoctorsGV.SelectedRow.Cells[7].Text; 
            AddressTb.Value = DoctorsGV.SelectedRow.Cells[8].Text; 
            PasswordTb.Value = DoctorsGV.SelectedRow.Cells[9].Text;
            DocEmailTb.Value = DoctorsGV.SelectedRow.Cells[10].Text;

            if (DocNameTb.Value == "")
            {
                key = 0;
            }

            else
            {
                key = Convert.ToInt32(DoctorsGV.SelectedRow.Cells[1].Text);
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DocNameTb.Value == "")
                {
                    ErrMsg.InnerText = "Please Select the Doctor!!";
                }
                else
                {
                    string Query = "delete from DoctorTb where DocId = {0}";
                    Query = string.Format(Query, DoctorsGV.SelectedRow.Cells[1].Text);

                    Con.SetData(Query);
                    ShowDoctors();

                    ErrMsg.InnerText = "Selected Doctor Deleted!!!";
                    key = 0;

                    DocNameTb.Value = "";
                    DocEmailTb.Value = "";
                    DocPhoneTb.Value = "";
                    GenderCb.SelectedIndex = -1;
                    DOBTb.Value = "";
                    AddressTb.Value = "";
                    PasswordTb.Value = "";
                    DocExpTb.Value = "";
                    DocSpecTb.Value = "";

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
                if (DocNameTb.Value == "")
                {
                    ErrMsg.InnerText = "Please Select the Doctor!!";
                }
                else
                {
                    string DName = DocNameTb.Value;
                    string DPhone = DocPhoneTb.Value;
                    string DEmail = DocEmailTb.Value;
                    string DGen = GenderCb.SelectedValue;
                    string DDOB = DOBTb.Value;
                    string DAdd = AddressTb.Value;
                    string DPassword = PasswordTb.Value;
                    string DExp = DocExpTb.Value;
                    string DSpec = DocSpecTb.Value;

                    string Query = "update DoctorTb set DocName='{0}',DocPhone='{1}',DocExp='{2}',DocSpec='{3}',DocGen='{4}',DocDOB='{5}',DocAdd='{6}',DocPassword='{7}',DocEmail='{8}'";

                    Query = string.Format(Query, DName,DPhone, DExp, DSpec, DGen, DDOB, DAdd,DPassword, DEmail, DoctorsGV.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowDoctors();
                    ErrMsg.InnerText = " Doctor Record Updated!!";

                    DocNameTb.Value = "";
                    DocEmailTb.Value = "";
                    DocPhoneTb.Value = "";
                    GenderCb.SelectedIndex = -1;
                    DOBTb.Value = "";
                    AddressTb.Value = "";
                    PasswordTb.Value = "";
                    DocExpTb.Value = "";
                    DocSpecTb.Value = "";
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