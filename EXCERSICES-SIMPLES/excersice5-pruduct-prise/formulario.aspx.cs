using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace excersice5_pruduct_prise
{
    public partial class formulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double pricePurchase, priceSelling;
            pricePurchase = Convert.ToDouble(txtvaluePurchase.Text);
            priceSelling = (pricePurchase * 0.3) + pricePurchase;
            respuesta.Text = System.Convert.ToString(priceSelling);

        }
    }
}