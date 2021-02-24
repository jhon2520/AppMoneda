
namespace GetHtmlCodeFromPage
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGetHtml = new System.Windows.Forms.Button();
            this.cbxMonedaAConvertir = new System.Windows.Forms.ComboBox();
            this.cbxMonedaConvertida = new System.Windows.Forms.ComboBox();
            this.tbxValorAConvertir = new System.Windows.Forms.TextBox();
            this.tbxValorConvertido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLista = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dragForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetHtml
            // 
            this.btnGetHtml.FlatAppearance.BorderSize = 0;
            this.btnGetHtml.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGetHtml.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnGetHtml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetHtml.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetHtml.ForeColor = System.Drawing.Color.White;
            this.btnGetHtml.Location = new System.Drawing.Point(354, 83);
            this.btnGetHtml.Name = "btnGetHtml";
            this.btnGetHtml.Size = new System.Drawing.Size(128, 67);
            this.btnGetHtml.TabIndex = 0;
            this.btnGetHtml.Text = "Convertir Moneda";
            this.btnGetHtml.UseVisualStyleBackColor = true;
            // 
            // cbxMonedaAConvertir
            // 
            this.cbxMonedaAConvertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(151)))), ((int)(((byte)(162)))));
            this.cbxMonedaAConvertir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMonedaAConvertir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxMonedaAConvertir.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMonedaAConvertir.ForeColor = System.Drawing.Color.White;
            this.cbxMonedaAConvertir.FormattingEnabled = true;
            this.cbxMonedaAConvertir.Items.AddRange(new object[] {
            "AED",
            "BGN",
            "BHD",
            "BND",
            "BRL",
            "BWP",
            "CAD",
            "CHF",
            "CLP",
            "CNY",
            "COP",
            "CZK",
            "DKK",
            "EUR",
            "GBP",
            "HKD",
            "HRK",
            "HUF",
            "IDR",
            "ILS",
            "INR",
            "IRR",
            "ISK",
            "JPY",
            "KRW",
            "KWD",
            "KZT",
            "LKR",
            "LYD",
            "MUR",
            "MXN",
            "MYR",
            "NOK",
            "NPR",
            "NZD",
            "OMR",
            "PHP",
            "PKR",
            "PLN",
            "QAR",
            "RON",
            "RUB",
            "SAR",
            "SEK",
            "SGD",
            "THB",
            "TRY",
            "TTD",
            "TWD",
            "USD",
            "ZAR"});
            this.cbxMonedaAConvertir.Location = new System.Drawing.Point(212, 77);
            this.cbxMonedaAConvertir.Name = "cbxMonedaAConvertir";
            this.cbxMonedaAConvertir.Size = new System.Drawing.Size(71, 24);
            this.cbxMonedaAConvertir.TabIndex = 7;
            // 
            // cbxMonedaConvertida
            // 
            this.cbxMonedaConvertida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(151)))), ((int)(((byte)(162)))));
            this.cbxMonedaConvertida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxMonedaConvertida.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMonedaConvertida.ForeColor = System.Drawing.Color.White;
            this.cbxMonedaConvertida.FormattingEnabled = true;
            this.cbxMonedaConvertida.Items.AddRange(new object[] {
            "BWP",
            "BRL",
            "BND",
            "BGN",
            "CAD",
            "CLP",
            "CNY",
            "BHD",
            "COP",
            "HRK",
            "CZK",
            "DKK",
            "EUR",
            "HKD",
            "HUF",
            "ISK",
            "INR",
            "IDR",
            "IRR",
            "ILS",
            "JPY",
            "KZT",
            "KRW",
            "KWD",
            "LYD",
            "MYR",
            "MUR",
            "MXN",
            "NPR",
            "NZD",
            "NOK",
            "OMR",
            "PKR",
            "PHP",
            "PLN",
            "QAR",
            "RON",
            "RUB",
            "SAR",
            "SGD",
            "ZAR",
            "LKR",
            "SEK",
            "CHF",
            "TWD",
            "THB",
            "TTD",
            "TRY",
            "AED",
            "GBP",
            "USD"});
            this.cbxMonedaConvertida.Location = new System.Drawing.Point(212, 161);
            this.cbxMonedaConvertida.Name = "cbxMonedaConvertida";
            this.cbxMonedaConvertida.Size = new System.Drawing.Size(71, 24);
            this.cbxMonedaConvertida.TabIndex = 8;
            // 
            // tbxValorAConvertir
            // 
            this.tbxValorAConvertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tbxValorAConvertir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxValorAConvertir.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxValorAConvertir.ForeColor = System.Drawing.Color.White;
            this.tbxValorAConvertir.Location = new System.Drawing.Point(80, 83);
            this.tbxValorAConvertir.Name = "tbxValorAConvertir";
            this.tbxValorAConvertir.Size = new System.Drawing.Size(108, 15);
            this.tbxValorAConvertir.TabIndex = 9;
            this.tbxValorAConvertir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxValorAConvertir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxValorAConvertir_KeyPress);
            // 
            // tbxValorConvertido
            // 
            this.tbxValorConvertido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tbxValorConvertido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxValorConvertido.Cursor = System.Windows.Forms.Cursors.No;
            this.tbxValorConvertido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxValorConvertido.ForeColor = System.Drawing.Color.White;
            this.tbxValorConvertido.Location = new System.Drawing.Point(80, 164);
            this.tbxValorConvertido.Name = "tbxValorConvertido";
            this.tbxValorConvertido.Size = new System.Drawing.Size(108, 15);
            this.tbxValorConvertido.TabIndex = 10;
            this.tbxValorConvertido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(77, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Valor a convertir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(209, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Moneda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(209, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Moneda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(77, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Valor convertido";
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlSuperior.Controls.Add(this.pictureBox1);
            this.pnlSuperior.Controls.Add(this.btnCerrar);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(553, 36);
            this.pnlSuperior.TabIndex = 16;
            this.pnlSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSuperior_MouseDown);
            this.pnlSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlSuperior_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GetHtmlCodeFromPage.Properties.Resources.money_bag_52px;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCerrar.BackgroundImage = global::GetHtmlCodeFromPage.Properties.Resources.close;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(525, -2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 28);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.btnLista);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnGetHtml);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbxValorAConvertir);
            this.panel1.Controls.Add(this.cbxMonedaConvertida);
            this.panel1.Controls.Add(this.cbxMonedaAConvertir);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbxValorConvertido);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 239);
            this.panel1.TabIndex = 17;
            // 
            // btnLista
            // 
            this.btnLista.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLista.BackgroundImage = global::GetHtmlCodeFromPage.Properties.Resources.question_mark_512px;
            this.btnLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLista.FlatAppearance.BorderSize = 0;
            this.btnLista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLista.Location = new System.Drawing.Point(290, 81);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(20, 20);
            this.btnLista.TabIndex = 19;
            this.btnLista.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackgroundImage = global::GetHtmlCodeFromPage.Properties.Resources.question_mark_512px1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(521, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(80, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(108, 1);
            this.panel3.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(80, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(108, 1);
            this.panel2.TabIndex = 16;
            // 
            // dragForm
            // 
            this.dragForm.Fixed = true;
            this.dragForm.Horizontal = true;
            this.dragForm.TargetControl = this.pnlSuperior;
            this.dragForm.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 6;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 6;
            this.bunifuElipse2.TargetControl = this.btnGetHtml;
            // 
            // tt
            // 
            this.tt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tt.ForeColor = System.Drawing.Color.White;
            this.tt.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tt.ToolTipTitle = "Información:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 275);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetHtml;
        private System.Windows.Forms.ComboBox cbxMonedaAConvertir;
        private System.Windows.Forms.ComboBox cbxMonedaConvertida;
        private System.Windows.Forms.TextBox tbxValorAConvertir;
        private System.Windows.Forms.TextBox tbxValorConvertido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuDragControl dragForm;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.ToolTip tt;
    }
}

