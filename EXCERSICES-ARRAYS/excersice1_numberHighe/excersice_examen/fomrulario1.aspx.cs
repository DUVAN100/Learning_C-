using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace excersice_examen
{
    public partial class fomrulario1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string valores = " ";
            int numbermax = 0;
            int[] vector = new int[5];
            vector[0] = 2;
            vector[1] = 18;
            vector[2] = 1;
            vector[3] = 27;
            vector[4] = 16;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > numbermax)
                {
                    numbermax = vector[i];
                    numberHighe.Text = System.Convert.ToString(numbermax);
                }
                valores += vector[i] + " -";
            }
            listNumbers.Text = valores;
        }
    }
}