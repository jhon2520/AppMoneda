using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetHtmlCodeFromPage
{
    public partial class Form2 : Form
    {
        private VentanaError ventanaError;

        public Form2()
        {
            InitializeComponent();
            ObtenerValoresIniciales();

        }

        private void ObtenerValoresIniciales()
        {
            this.tbxURL.Text = Form1.Url;
            this.rtbHTTP.Text = Form1.CodigoHTML;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void pnlSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void pnlSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            this.Opacity = 1;
        }
        public void Buscar()
        {

            if(this.tbxValorABuscar.TextLength > 0)
            {
                int inicio = 0;
                int final = this.rtbHTTP.Text.LastIndexOf(this.tbxValorABuscar.Text);

                this.rtbHTTP.SelectAll();
                rtbHTTP.SelectionBackColor = Color.FromArgb(24, 24, 24);

                while (inicio < final)
                {
                    rtbHTTP.Find(this.tbxValorABuscar.Text, inicio, this.rtbHTTP.TextLength, RichTextBoxFinds.MatchCase);
                    rtbHTTP.SelectionBackColor = Color.FromArgb(50, 180, 206);
                    inicio = rtbHTTP.Text.IndexOf(this.tbxValorABuscar.Text, inicio) + 1;
                }
            }
            else
            {
                ventanaError = new VentanaError("Debe escribir la palabra que desea buscar.");
                ventanaError.ShowDialog();
            }

    
        }
    }
}
