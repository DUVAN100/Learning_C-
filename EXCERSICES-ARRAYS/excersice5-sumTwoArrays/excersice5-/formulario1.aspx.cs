using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace excersice5_
{
    public partial class formulario1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int tamano = 0;

            int numberOne = 0, numberTwo = 0;
            string valora = " ";
            string valorb = " ";
            string valors = " ";
            tamano = Convert.ToInt32(txttamano.Text);
            int[] sumar = new int[tamano];
            int[] vectorA = new int[tamano];
            for (int i = 0; i < vectorA.Length; i++)
            {
                //con este for estamos piiendo los valores del primer vector
                numberOne = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Digite un numero: " + numberOne+ "en el vector A"));
                vectorA[i] = numberOne;
            }
            int[] vectorB = new int[tamano];
            for (int i = 0; i < vectorB.Length; i++) 
            {
                //con este for estamos piiendo los valores del segundo vector 
                numberTwo = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Digite un numero: " + numberTwo+ "en el vector B"));
                vectorB[i] = numberTwo;

            }
            for (int i = 0; i <sumar.Length; i++)
            {
                // le asigno el valor de manera que me deje un espaciado con cada valor
                valora += vectorA[i] + " - ";
                valorb += vectorB[i] + " -";
                //aqui lo que hago es sumar los valores en cada posicion correspondiente
                sumar[i] = vectorA[i] + vectorB[i];
                //asigno el resultado dejando el espaciado
                valors += sumar[i] + " ,";
            }
            //imprimo los valores obtenidos y los asocio con las herramientas del formulario 
            vectora.Text = valora;
            vectorb.Text = valorb;
            respuesta.Text = valors;
        }
    }
}