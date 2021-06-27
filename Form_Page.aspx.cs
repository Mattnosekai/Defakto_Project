using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;


namespace Defakto_Project
{
    public partial class Form_Page : System.Web.UI.Page
    {
        //ms sql server express database connection string
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(local)\sqlexpress;Initial Catalog=Defakto;Integrated Security=True"); 

        public static int labell=0;
        protected void Page_Load(object sender, EventArgs e)
        {
            int L = txtFirstName.Text.Length + txtLastName.Text.Length + txtEmail.Text.Length;
            
            if (labell == 0 || L == 0) //If the page is loading for the first time or there is a reload, then load the red * symbols next to the 3 form fields.
            {
                labell=1;

                lblF1.Font.Bold = true;
                lblF1.ForeColor = System.Drawing.Color.Red;
                lblF1.Font.Size = 20;
                lblF1.Text = "*";

                lblF2.Font.Bold = true;
                lblF2.ForeColor = System.Drawing.Color.Red;
                lblF2.Font.Size = 20;
                lblF2.Text = "*";

                lblF3.Font.Bold = true;
                lblF3.ForeColor = System.Drawing.Color.Red;
                lblF3.Font.Size = 20;
                lblF3.Text = "*";
            }

            
        }
        
    
      

        protected void btnSendCat_Click(object sender, EventArgs e)
        {
            
            //Form Validation Code
            
            //Check for valid First Name
            
            


            string emsg1="";
            int error_count1 = 0;
            int error_count2 = 0;
            int error_count3 = 0;
            int min_len=0;
            min_len = txtFirstName.Text.Length;
            
            if(min_len<2)
            {
                error_count1++;
                
            }

            if (!Regex.IsMatch(txtFirstName.Text, @"^[a-zA-Z.-]+$"))
            { 
                error_count1++;
               
            }

            if (error_count1 > 0)
            {
                emsg1 = "Error!:Please enter a valid full First Name <br /> (Greater than 1 character in length)";
            }

            
            lblFirstName.Font.Bold = true;
            lblFirstName.ForeColor = System.Drawing.Color.Red;
            lblFirstName.Font.Size = 13;
            lblFirstName.Text = emsg1;

            if (error_count1 == 0)  // Display a green check mark if First Name Field is correct.
            {
                lblF1.Font.Bold = true;
                lblF1.ForeColor = System.Drawing.Color.Green;
                lblF1.Font.Size = 20;
                lblF1.Text = "\u2713";  
            }
            else 
            {
                lblF1.Font.Bold = true;
                lblF1.ForeColor = System.Drawing.Color.Red;
                lblF1.Font.Size = 20;
                lblF1.Text = "*";
            }


            //Check for valid Last Name

            emsg1 = "";
            min_len = txtLastName.Text.Length;

            if (min_len < 2)
            {
                error_count2++;

            }

            if (!Regex.IsMatch(txtLastName.Text, @"^[a-zA-Z.-]+$"))
            {
                error_count2++;

            }

            if (error_count2 > 0)
            {
                emsg1 = "Error!:Please enter a valid full Last Name <br /> (Greater than 1 character in length)";
            }


            lblLastName.Font.Bold = true;
            lblLastName.ForeColor = System.Drawing.Color.Red;
            lblLastName.Font.Size = 13;
            lblLastName.Text = emsg1;

            if (error_count2 == 0)  // Display a green check mark if Last Name Field is correct.
            {
                lblF2.Font.Bold = true;
                lblF2.ForeColor = System.Drawing.Color.Green;
                lblF2.Font.Size = 20;
                lblF2.Text = "\u2713";
            }
            else
            {
                lblF2.Font.Bold = true;
                lblF2.ForeColor = System.Drawing.Color.Red;
                lblF2.Font.Size = 20;
                lblF2.Text = "*";
            }


            emsg1 = "";

            //Email Validation

         
            min_len = txtEmail.Text.Length;

            if (min_len < 5)       // Minimum length of the Email Address must be 5 characters or more.       
            {
                error_count3++;

            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[a-zA-Z0-9@.]+$")) // The only allowed characters are A to Z, Numbers 0 to 9, and the @ and . characters
            {
                error_count3++;

            }

            
            if (!Regex.IsMatch(txtEmail.Text, @".*[a-zA-Z]+.*"))  // Check that at least one alphabetical character is present.
            {
                error_count3++;
            }

            
            if (!Regex.IsMatch(txtEmail.Text, @".*@+.*")) // Check that the @ sign is present.
            {
                error_count3++;
            }

            if (!Regex.IsMatch(txtEmail.Text, @".*[.]+.*")) // Check that there is at least one dot/period is present.
            {
                error_count3++;
            }

            if (txtEmail.Text.IndexOf("..") > -1) // Check to make sure that 2 or more dots are not in a row.
            {
                error_count3++;
            }

            if (txtEmail.Text.IndexOf("@") < txtEmail.Text.LastIndexOf("@")) // Check to make sure that there is only 1 @ sign.
            {
                error_count3++;
            }



            if (error_count3 > 0)
            {
                emsg1 = "Error!:Please enter a valid Email Address. <br />";
            }


            lblEmail.Font.Bold = true;
            lblEmail.ForeColor = System.Drawing.Color.Red;
            lblEmail.Font.Size = 13;
            lblEmail.Text = emsg1;

            if (error_count3 == 0)  // Display a green check mark if Email Address Field is correct.
            {
                lblF3.Font.Bold = true;
                lblF3.ForeColor = System.Drawing.Color.Green;
                lblF3.Font.Size = 20;
                lblF3.Text = "\u2713"; // Unicode number for a check mark.
            }
            else
            {
                lblF3.Font.Bold = true;
                lblF3.ForeColor = System.Drawing.Color.Red;
                lblF3.Font.Size = 20;
                lblF3.Text = "*";
            }
            //===========================================================================
            //
            //   Database Code
            //
            //===========================================================================

                int total_errors = error_count1 + error_count2 + error_count3; // Sum the error totals
            
            if(total_errors==0) // If there are no errors then save the form to the database. 
            {
                if (sqlCon.State == ConnectionState.Closed) // open db connection if it is closed
                    sqlCon.Open();

                SqlCommand sqlCmd1 = new SqlCommand("INSERT INTO Forms_Table (FirstName, LastName, EmailAddress) VALUES('" + txtFirstName.Text + "'," + "'" + txtLastName.Text + "','" + txtEmail.Text + "')", sqlCon);

                sqlCmd1.ExecuteNonQuery(); // execute query by inserting form data into the db

                sqlCon.Close(); // close the db connection
            //===========================================================================
            //
            // Final Step: Redirect to "Thank you for your submission page".

                Server.Transfer("ThankYou_Page.aspx");

            }


        }
    }
}