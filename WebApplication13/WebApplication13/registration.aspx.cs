using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication13
{
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTNsubmit_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string enrol = TBenrol.Text;
            string name = TBname.Text;
            string email = TBemail.Text;
            string number = TBnumber.Text;
            string blood = TBblood.Text;
            string fees = TBfees.Text;
            float percentage = Int32.Parse(TBpercentage.Text);
            string address = TBaddress.Text;
            string pincode = TBpincode.Text;
            string password = TBpassword.Text;
            string confirm = TBconfirm.Text;

            if (confirm.Equals(password))
            {
                if(blood.Equals("A+") || blood.Equals("A-") || blood.Equals("B+") || blood.Equals("B-") || blood.Equals("AB+") || blood.Equals("AB-") || blood.Equals("O+") || blood.Equals("O-"))
                {
                    if (percentage < 100 )
                    {
                        if (RegexEmail.IsValid)
                        {
                            if (RegexFees.IsValid)
                            {
                                if (RegexName.IsValid)
                                {
                                    if (RegexNumber.IsValid)
                                    {
                                        if (RegexPincode.IsValid)
                                        {
                                            flag = 1;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        error.Text = "Invalid Percentage";
                    }
                }
                else
                {
                    error.Text = "Invalid Blood Group";
                }
            } else
            {
                error.Text = "Passowrds Don't Match";
            }

            if (flag.Equals(1))
            {
                error.Text = "Registration Successfull.";
            }
        }
    }
}