using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicMS.Views
{
    public partial class Login : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();

        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RoleCb.SelectedIndex == 0)
            {
                ErrMsg.InnerText = "Select a Role!!";
            }
            else if (RoleCb.SelectedIndex == 1)
            {
                if(EmailTb.Value == "admin@gmail.com" && PasswordTb.Value == "adminzydus99")
                {

                    string Role = "Admin";
                    
                    string r_url = "{0}/Doctors.aspx";
                    r_url = string.Format(r_url, Role);
                    Response.Redirect(r_url);
                }

            }
            else if (RoleCb.SelectedIndex == 2)
            {
                string Query = "Select * from DoctorTb where DocEmail='{0}' and DocPassword='{1}'";
                Query = string.Format(Query, EmailTb.Value, PasswordTb.Value);
                DataTable dt = Con.GetData(Query);

                if (dt.Rows.Count == 0)
                {
                    ErrMsg.InnerText = "No Record Exist for Doctor!!";
                }
                else
                {
                    string Role = "Doctors";
                    Session["uid"] = dt.Rows[0][0].ToString();
                    Session["role"] = Role;
                    Session.Timeout = 20;

                    string r_url = "{0}/Prescription.aspx";
                    r_url = string.Format(r_url, Role);
                    Response.Redirect(r_url);
                }
            }
            else if (RoleCb.SelectedIndex == 3)
            {
                string Query = "Select * from ReceptionistTb where RecEmail='{0}' and RecPassword='{1}'";
                Query = string.Format(Query, EmailTb.Value, PasswordTb.Value);
                DataTable dt = Con.GetData(Query);

                if (dt.Rows.Count == 0)
                {
                    ErrMsg.InnerText = "No Record Exist for Receptionist!!";
                }
                else
                {
                    string Role = "Receptionist";
                    Session["uid"] = dt.Rows[0][0].ToString();
                    Session["role"] = Role;
                    Session.Timeout = 20;

                    string r_url = "{0}/Patients.aspx";
                    r_url = string.Format(r_url, Role);
                    Response.Redirect(r_url);
                }
            }
            else if (RoleCb.SelectedIndex == 4)
            {
                string Query = "Select * from LabratorianTb where LabEmail='{0}' and LabPassword='{1}'";
                Query = string.Format(Query, EmailTb.Value, PasswordTb.Value);
                DataTable dt = Con.GetData(Query);

                if (dt.Rows.Count == 0)
                {
                    ErrMsg.InnerText = "No Record Exist for Laboratorian!!";
                }
                else
                {
                    string Role = "Laboratorian";
                    Session["uid"] = dt.Rows[0][0].ToString();
                    Session["role"] = Role;
                    Session.Timeout = 20;

                    string r_url = "{0}/LabTest.aspx";
                    r_url = string.Format(r_url, Role);
                    Response.Redirect(r_url);
                }
            }


        }
    }
}