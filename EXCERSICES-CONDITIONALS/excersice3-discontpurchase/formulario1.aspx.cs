using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace excersice3_
{
    public partial class formulario1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double valuePurchase, totalToPay, discount;
            valuePurchase = Convert.ToDouble(txtvaluepurchase.Text);

            if (valuePurchase >= 1000)
            {
                discount = valuePurchase * 0.20;
                totalToPay = valuePurchase - discount;
                totaltopay.Text = System.Convert.ToString(totalToPay);
            }
            else 
            {
                totalToPay = valuePurchase - 0;
                totaltopay.Text = System.Convert.ToString(totalToPay);
            }
        }
    }
}