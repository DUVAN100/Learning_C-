using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace excersice_3StudentFailOrApprove
{
    public partial class formulario1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double noteOne, noteTwo, noteThree, average;
            string name;
            name = Convert.ToString(txtname.Text);
            noteOne = Convert.ToDouble(txtcalone.Text);
            noteTwo = Convert.ToDouble(txtcaltwo.Text);
            noteThree = Convert.ToDouble(txtcalthree.Text);
            average = noteOne + noteTwo + noteThree / 3;
            if (average >= 70)
            {
                Failedorapprove.Text = System.Convert.ToString("aprovado");
                qualificationfinal.Text = System.Convert.ToString(average);
            }
            else 
            {
                Failedorapprove.Text = System.Convert.ToString("reprovado");
            }


        }
    }
}