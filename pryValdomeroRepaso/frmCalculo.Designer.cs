namespace pryValdomeroRepaso
{
    partial class frmCalculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalcular = new Button();
            txtMonto = new TextBox();
            lblIva = new Label();
            lblMonto = new Label();
            lblResultado = new Label();
            cmbIva = new ComboBox();

            SuspendLayout();
            // 
            // btnCalcular
            // 

            btnCalcular.Location = new Point(241, 208);
            btnCalcular.Location = new Point(267, 234);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(144, 38);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(189, 82);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(196, 23);
            txtMonto.TabIndex = 7;
            txtMonto.KeyPress += txtMonto_KeyPress;
            // 
            // lblIva
            // 
            lblIva.AutoSize = true;
            lblIva.Location = new Point(116, 149);
            lblIva.Name = "lblIva";
            lblIva.Size = new Size(22, 15);
            lblIva.TabIndex = 6;
            lblIva.Text = "Iva";
            lblIva.Click += lblIva_Click;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(95, 90);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 5;
            lblMonto.Text = "Monto";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(76, 293);
            lblResultado.Location = new Point(76, 299);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 10;
            lblResultado.Text = "Resultado:";
            // 
            // cmbIva
            // 
            cmbIva.FormattingEnabled = true;
            cmbIva.Items.AddRange(new object[] { "10%", "21%", "No Aplica" });
            cmbIva.Location = new Point(189, 141);
            cmbIva.Name = "cmbIva";
            cmbIva.Size = new Size(156, 23);
            cmbIva.TabIndex = 11;
            // 
            // frmCalculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 408);
            Controls.Add(comboBox1);
            Controls.Add(cmbIva);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtMonto);
            Controls.Add(lblIva);
            Controls.Add(lblMonto);
            Name = "frmCalculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculo Monto-Iva";
            Load += frmCalculo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtMonto;
        private Label lblIva;
        private Label lblMonto;
        private Label lblResultado;

        private ComboBox comboBox1;

        private ComboBox cmbIva;

    }
}