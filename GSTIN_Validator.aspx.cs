using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSTINNumberValidator
{
    public partial class GSTIN_Validator : System.Web.UI.Page
    {
        Boolean result;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Validate_Click(object sender, EventArgs e)
        {
            
            if (txtGSTINValidator.Text != "")
            {
                result = commonFunctions.verifyCheckDigit(txtGSTINValidator.Text.ToUpper());
                if (result == false)
                {

                    txtGSTINValidator.Text = "";
                    txtGSTINValidator.Focus();
                    Response.Write("<script LANGUAGE='JavaScript' >alert('Please enter valid GSTIN  ......!')</script>");
                }
                else
                    Response.Write("<script LANGUAGE='JavaScript' >alert('GSTIN is OK  ......!')</script>");
            }
            else
            {
              
              Response.Write("<script LANGUAGE='JavaScript' >alert('Please enter GSTIN  ......!')</script>");
                 
            }
        }
    }
}