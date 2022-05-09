using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace excersice4_higheThanAverage
{
    public partial class formulario1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string lista = " ";
            int x=0;
            double valores=0,average=0;
            bool validacion = Convert.ToBoolean(txtvalidation.Text);
            double[] values = new double[5];
            if (validacion = true) 
            {
                for (int i = 0; i < values.Length; i++) 
                {
                    x += 1;
                    valores = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("ingrese los valores " + valores + " del vector"));
                     values[i] = valores;
                    average += values[i]/5;
                    if (values[i] > average)
                    {
                        lista = lista + " " + values[i] + ", ";
                    }

                }
                promedio.Text = System.Convert.ToString(average);
                higheThanaverage.Text = System.Convert.ToString(lista);
                numbervaluesHigheAverage.Text = x;


                                

            }

        }
    }
}