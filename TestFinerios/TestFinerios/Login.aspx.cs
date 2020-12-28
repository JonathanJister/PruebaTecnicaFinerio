using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestFinerios
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        public void ValidaLogin()
        {
            Console.WriteLine("Entro");
            if (email.Text == "jonathan.ortiz.dorantes@gmail.com")
            {
                if (password.Text == "1234Entra")
                {
                    
                    Response.Redirect("~/Movimientos");
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "PopupScript", "Error();", true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "PopupScript", "Error();", true);
            }
        }

        public void BtnEntrar_Click(object sender, EventArgs e)
        {
            ValidaLogin();
        }
    }
}