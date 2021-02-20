using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.IO;

namespace GetHtmlCodeFromPage
{
    public partial class Form1 : Form
    {
        private string monedaAConvertir;
        private string monedaConvertida;
        private double monto;
        private static string url;
        private static string codigoHTML;
        VentanaError ventanaError;
        private bool continuar = true;


        public static string CodigoHTML { get => codigoHTML; private set => codigoHTML = value; }
        public static string Url { get => url; private set => url = value; }

        public Form1()
        {
            InitializeComponent();
            MensajesToolTip();
            this.btnGetHtml.Click += new EventHandler(GetHtmlCode);
        }
        private void DarValorAMonedas()
        {
            try
            {
                this.monedaAConvertir = this.cbxMonedaAConvertir.Text;
                this.monedaConvertida = this.cbxMonedaConvertida.Text;
                this.monto = Convert.ToDouble(this.tbxValorAConvertir.Text);
                continuar = true;
            }
            catch (Exception ex)
            {
                ventanaError = new VentanaError($"{ex.Message} Debe seleccionar un valor para convertir.");
                ventanaError.ShowDialog();
                continuar = false;
                return;
            }

        }

        private void GetHtmlCode(object sender, EventArgs args)
        {
            DarValorAMonedas();

            Url = $"https://www.x-rates.com/calculator/?from={this.monedaAConvertir}&to={this.monedaConvertida}&amount={this.monto}";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
            {
                CodigoHTML = streamReader.ReadToEnd();
            }
            ObtenerValor();

        }
        private string HallarString(string frase, string palabraInicial, string palabraFinal)
        {
            int indiceInicial = frase.IndexOf(palabraInicial) + palabraInicial.Length;
            int indiceFinal = frase.IndexOf(palabraFinal);
            int cantidadDatos = indiceFinal - indiceInicial;
            string valor = frase.Substring(indiceInicial, cantidadDatos);

            return valor;
        }

        private void ObtenerValor()
        {
       
            try
            {
                if(continuar)
                {
                    string valorInicial = "\"ccOutputRslt\">";
                    string valorFinal = "<span class=\"ccOutputTrail\"";
                    string valor = HallarString(CodigoHTML, valorInicial, valorFinal);
                    this.tbxValorConvertido.Text = valor;
                }
            }
            catch (Exception ex)
            {
                ventanaError = new VentanaError(ex.Message);
                ventanaError.ShowDialog();
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pnlSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            this.Opacity = 0.5;
        }
        private void pnlSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            this.Opacity = 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); 
            form2.ShowDialog(); ;
        }

        private void tbxValorAConvertir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
             if (Char.IsControl(e.KeyChar)) 
            {
                e.Handled = false;
            }
            else
            {
                ventanaError = new VentanaError("No puede escribir caracteres ajenos a dígitos.");
                ventanaError.ShowDialog();
                e.Handled = true;
            }
        }

        private void MensajesToolTip()
        {
            this.tt.SetToolTip(this.btnLista, Lista());
        }

        private string Lista()
        {
            string lista = "BWP = Botswana Pula\n BRL = Brazilian Real\n BND = Bruneian Dollar\n BGN = Bulgarian Lev\n CAD = Canadian Dollar\n CLP = Chilean Peso\n CNY = Chinese Yuan Renminbi\n BHD = Bahraini Dinar\n COP = Colombian Peso\n HRK = Croatian Kuna\n CZK = Czech Koruna\n DKK = Danish Krone\n EUR = Euro\n HKD = Hong Kong Dollar\n HUF = Hungarian Forint\n ISK = Icelandic Krona\n INR = Indian Rupee\n IDR = Indonesian Rupiah\n IRR = Iranian Rial\n ILS = Israeli Shekel\n JPY = Japanese Yen\n KZT = Kazakhstani Tenge\n KRW = South Korean Won\n KWD = Kuwaiti Dinar\n LYD = Libyan Dinar\n MYR = Malaysian Ringgit\n MUR = Mauritian Rupee\n MXN = Mexican Peso\n NPR = Nepalese Rupee\n NZD = New Zealand Dollar\n NOK = Norwegian Krone\n OMR = Omani Rial\n PKR = Pakistani Rupee\n PHP = Philippine Peso\n PLN = Polish Zloty\n QAR = Qatari Riyal\n RON = Romanian New Leu\n RUB = Russian Ruble\n SAR = Saudi Arabian Riyal\n SGD = Singapore Dollar\n ZAR = South African Rand\n LKR = Sri Lankan Rupee\n SEK = Swedish Krona\n CHF = Swiss Franc\n TWD = Taiwan New Dollar\n THB = Thai Baht\n TTD = Trinidadian Dollar\n TRY = Turkish Lira\n AED = Emirati Dirham\n GBP = British Pound\n USD = US\n";
            return lista;
        }
    }


}
