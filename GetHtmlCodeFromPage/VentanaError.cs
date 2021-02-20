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
    public partial class VentanaError : Form
    {
        
        public VentanaError(string mensaje)
        {
            InitializeComponent();
            this.lblMensaje.Text = mensaje;
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VentanaError_MouseDown(object sender, MouseEventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void VentanaError_MouseUp(object sender, MouseEventArgs e)
        {
            this.Opacity = 1;
        }

        private void VentanaError_Load(object sender, EventArgs e)
        {
       
        }
    }
}
