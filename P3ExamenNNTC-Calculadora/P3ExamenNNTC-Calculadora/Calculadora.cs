using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3ExamenNNTC_Calculadora
{
    public partial class Calculadora : Form
    {
        operationOption op;//Variable que almacena el estado del operador actual
        double resInitVal, resFinalVal;//Variables que almacenan el valor inicial y el valor final del resultado mostrado

        public Calculadora()
        {
            InitializeComponent();
            resBox.Text = "0"; //Se inicializa el valor mostrado en la ventana de la calculadora en 0
            op = operationOption.none; //Se inicializa el operador inicial en 0, el cual quiere decir que no hay operador
            resInitVal = 0; resFinalVal = 0; //Se inicializan los resultados de la calculadora en 0
        }

        public enum operationOption
        {
            none = 0,//No hay ningun operador
            perc = 1,//Porcentual 
            addt = 2,//Adición
            sbst = 3,//Substracción
            mlt = 4,//Producto
            dvsn = 5//Division
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (resBox.Text != "0")
            {
                resBox.Text += "0"; // Se concatena un 0 al valor actual de la cadena
            }
        }

        private void isItIntlzd(String val)
        {
            if (resBox.Text == "0")
            {
                resBox.Text = val;//Si el valor mostrado es 0 o nulo, se muestra el valor del boton presionado
            }
            else
            {
                resBox.Text += val;//Se concatena el valor del boton presionado a la cadena
            }
        }

        /*Función que controla la operación a realizar en base a los valores de los resultados*/
        private double operation()
        {
            double result = 0;//Se inicializa la variable que alamacenara el valor del resultado actual en 0
            switch (op)
            {
                case operationOption.perc:
                    result = (resInitVal * resFinalVal) / 100;// Se alamacena el valor de la operación correspondiente al porcentaje 
                    break;
                case operationOption.addt:
                    result = resInitVal + resFinalVal;// Se alamacena el valor de la operación correspondiente a la adición 
                    break;
                case operationOption.sbst:
                    result = resInitVal - resFinalVal;// Se alamacena el valor de la operación correspodiente a la substracción
                    break;
                case operationOption.mlt:
                    result = resInitVal * resFinalVal;//Se almacena el valor correspondiente al producto
                    break;
                case operationOption.dvsn:
                    result = resInitVal / resFinalVal;//Se almacena el valor correspondiente a la division
                    break;
            }
            return result;//Se retorna el valor del resultado
        }

        private void execOperatiom(char oper)
        {
            String res = resBox.Text; //Se inicializa el resultado de la operación como el valor actual de la ventana
            String[] opers = ["+", "-", "*", "/", "%"];
            if (opers.Any(op => lbsRes.Text.Contains(op)))
            {
                if (lbsRes.Text.Contains("="))
                {
                    //Si el label del resultado contiene el operador igual dentro de la cadena 
                    resInitVal = Convert.ToDouble(res); //El valor inicial toma el valor del valor actual de la ventana
                    lbsRes.Text = res + oper; //Se actualiza el valor del label al valor del resultado concatenado con el operador actual
                }
                else
                {
                    lbsRes.Text = res;
                }
            }
            else if (resBox.Text == resInitVal.ToString()) { 
                return;
            }
            else
            {
                resInitVal = Convert.ToDouble(res); //EL valor inicial toma el valor de la variable del resultado
                lbsRes.Text += res + oper; //Se concatena al valor del label el valor de la entana mas el operador
                resBox.Text = "0"; //Se actualiza el valor de la ventana a 0
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            isItIntlzd("1"); //Valor al del boton presionado
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            isItIntlzd("2"); //Valor al del boton presionado
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            isItIntlzd("3"); //Valor al del boton presionado
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            isItIntlzd("4"); //Valor al del boton presionado
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            isItIntlzd("5"); //Valor al del boton presionado
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            isItIntlzd("6"); //Valor al del boton presionado
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            isItIntlzd("7"); //Valor al del boton presionado
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            isItIntlzd("8"); //Valor al del boton presionado
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            isItIntlzd("9"); //Valor al del boton presionado
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            String dot = "."; //Se incializa el valor de una variable que contiene un .
            if (!resBox.Text.Contains(dot))
            {
                resBox.Text += dot; // Se concatena un punto al valor de la ventana 
            }
        }

        private void btnPrctg_Click(object sender, EventArgs e)
        {
            op = operationOption.perc; //Se actualiza la variable del operador actual 
            execOperatiom('%'); //Se pasa como parametro de la operación a ejecutar el operador correspondientes
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            op = operationOption.addt;//Se actualiza la variable del operador actual 
            execOperatiom('+');//Se pasa como parametro de la operación a ejecutar el operador correspondientes
        }

        private void btnSbst_Click(object sender, EventArgs e)
        {
            op = operationOption.sbst; //Se actualiza la variable del operador actual 
            execOperatiom('-'); //Se pasa como parametro de la operación a ejecutar el operador correspondientes
        }

        private void btnMltp_Click(object sender, EventArgs e)
        {
            op = operationOption.mlt;//Se actualiza la variable del operador actual 
            execOperatiom('*'); //Se pasa como parametro de la operación a ejecutar el operador correspondientes
        }

        private void btnDvs_Click(object sender, EventArgs e)
        {
            op = operationOption.dvsn;//Se actualiza la variable del operador actual 
            execOperatiom('/'); //Se pasa como parametro de la operación a ejecutar el operador correspondientes
        }


        private void btnEquals_Click(object sender, EventArgs e)
        {
            double result; //Se declara una variable auxiliar que almacena el valor del resultado actual 
            if (resFinalVal == 0)
            {
                if (lbsRes.Text.Contains("=")|lbsRes.Text=="0")
                {
                    return; //Si el la cadena del label ya contiene un igual, no se efectua cambio alguno
                }
                else if (lbsRes.Text.Contains("/") && resBox.Text == "0")
                {
                    resBox.Text = "No se puede dividir entre 0";
                }
                else if (resBox.Text == "No se puede dividir entre 0") {
                    lbsRes.Text = "0"; resBox.Text = "0";
                    resInitVal = 0; resFinalVal = 0;
                }
                else
                {
                    resFinalVal = Convert.ToDouble(resBox.Text); //Se actualiza el valor del resultado final al valor actual de la ventana 
                    lbsRes.Text += resFinalVal + "="; //Se concatena el valor final y un igual al valor del label
                    result = operation(); //Se inicializa el valor del resultado con el valor que devuelve la llamada del metodo operation
                    resInitVal = 0; resFinalVal = 0; //Se actualizan los valores de los resultados a 0
                    resBox.Text = result.ToString(); //Se actualiza el valor de la cadena de la ventana,  tomando el valor de la variable auxiliar
                }
            }
        }

        //Metodo encargado del borrado del valor de la ventana 
        private void btnCE_Click(object sender, EventArgs e)
        {
            if (resBox.Text.Length >= 1)
            {
                resBox.Text = "0"; //Si el tamaño de la cadena de la ventana es igual o mayor a 1, se actualiza el valor de la ventana a 0
            }
        }

        //Metodo encargado de borrar todos los valores
        private void btnC_Click(object sender, EventArgs e)
        {
            resBox.Text = "0";//Se setea el valor de la cadena de la ventana en 0
            lbsRes.Text = null;// Se setea el valor del label del resultado como nulo
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string res;
            if (resBox.Text.Length > 1)
            {
                res=resBox.Text;
                res=res.Substring(0, res.Length - 1);
                if (resBox.Text.Length == 2 && resBox.Text.Contains("-")) 
                    resBox.Text = "0";
                else 
                    resBox.Text = res;
            }
            else {
                resBox.Text = "0";
            }
        }
    }
}
