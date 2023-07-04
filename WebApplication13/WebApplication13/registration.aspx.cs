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

            string email = TBemail.Text;
            string enrol = TBenrol.Text;
            string number = TBnumber.Text;
            string fees = TBfees.Text;
            string address = TBaddress.Text;
            string pincode = TBpincode.Text;
            float percentage = Int32.Parse(TBpercentage.Text);
            string name = TBname.Text;
            string blood = TBblood.Text;
            string password = TBpassword.Text;
            string confirm = TBconfirm.Text;

            if (confirm.Equals(password))
            {
                if(blood.Equals("A+") || blood.Equals("A-") || blood.Equals("B+") || blood.Equals("B-") || blood.Equals("AB+") || blood.Equals("AB-") || blood.Equals("O+") || blood.Equals("O-"))
                {
                    if (percentage < 100 )
                    {
                        if (IsValidName(name))
                        {
                            if(pincode <= 999999)
                            {
                                if (!string.IsNullOrEmpty(address))
                                {
                                    if (IsValidFees(fees))
                                    {
                                        if (IsValidMobileNumber(number))
                                        {
                                            if (IsValidEnrolmentNumber)
                                            {
                                               flag = 1;
                                            }
                                            else
                                            {
                                                error.Text = "Invaid Enrolment Number";
                                            }
                                        }
                                        else
                                        {
                                            error.Text = "Invalid Mobile Number";
                                        }
                                    }
                                    else
                                    {
                                        error.Text = "Only 2 Decimal Places Allowed in Fees";
                                    }
                                }
                                else
                                {
                                    error.Text = "Enter Address";
                                }
                            }
                            else
                            {
                                error.Text = "Invalid Pincode";
                            }
                        }
                        else
                        {
                            error.Text = "Invalid Name";
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
            else
            {
                error.Text = "Registration Failed.";
            }
        }

        static bool IsValidName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }

            foreach (char c in name)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
        
            return true;
        }

        static bool IsValidFees(string input)
        {
            decimal number;

            // Check if the input can be parsed as a decimal
            if (!decimal.TryParse(input, out number))
            {
                return false;
            }

            // Check if the number has exactly two decimal digits
            int decimalPlaces = GetDecimalPlaces(number);
            if (decimalPlaces != 2)
            {
                return false;
            }

            return true;
        }

        static int GetDecimalPlaces(decimal number)
        {
            int decimalPlaces = 0;

            decimal fraction = number - Math.Truncate(number);

            while (fraction != 0 && decimalPlaces < 3)
            {
                fraction *= 10;
                fraction = fraction - Math.Truncate(fraction);
                decimalPlaces++;
            }

            return decimalPlaces;
        }

        static bool IsValidMobileNumber(string mobileNumber)
        {
            // Remove any non-digit characters from the mobile number
            string digitsOnly = Regex.Replace(mobileNumber, @"\D", "");

            // Check if the mobile number is 10 digits long
            if (digitsOnly.Length != 10)
            {
                return false;
            }

            // Check if the mobile number starts with a valid prefix
            string validPrefixPattern = @"^(0|\\+91|91)?[6789]";
            if (!Regex.IsMatch(digitsOnly, validPrefixPattern))
            {
                return false;
            }

            // Additional validation rules specific to your mobile number format can be added here

            return true;
        }

        static bool IsValidEnrolmentNumber(string input)
        {
            // Remove any non-digit characters from the input
            string digitsOnly = new string(input.ToCharArray().Where(char.IsDigit).ToArray());

            // Check if the number is 15 digits long
            if (digitsOnly.Length != 15)
            {
                return false;
            }

            return true;
        }
    }
}