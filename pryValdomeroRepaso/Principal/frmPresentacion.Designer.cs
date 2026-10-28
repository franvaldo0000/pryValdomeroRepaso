namespace pryValdomeroRepaso
{
    partial class frmPresentacion
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresentacion));
            btnIngresarPrograma = new Button();
            tmrHora = new System.Windows.Forms.Timer(components);
            lblHora = new Label();
            SuspendLayout();
            // 
            // btnIngresarPrograma
            // 
            btnIngresarPrograma.BackColor = Color.Blue;
            btnIngresarPrograma.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresarPrograma.ForeColor = Color.White;
            btnIngresarPrograma.Location = new Point(191, 166);
            btnIngresarPrograma.Margin = new Padding(4);
            btnIngresarPrograma.Name = "btnIngresarPrograma";
            btnIngresarPrograma.Size = new Size(809, 159);
            btnIngresarPrograma.TabIndex = 0;
            btnIngresarPrograma.Text = "Ingresar a Lab1_SP1";
            btnIngresarPrograma.UseVisualStyleBackColor = false;
            btnIngresarPrograma.Click += btnIngresarPrograma_Click;
            btnIngresarPrograma.MouseEnter += btnIngresarPrograma_MouseEnter;
            btnIngresarPrograma.MouseLeave += btnIngresarPrograma_MouseLeave;
            // 
            // tmrHora
            // 
            tmrHora.Interval = 1000;
            tmrHora.Tick += tmrHora_Tick;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.MidnightBlue;
            lblHora.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.ForeColor = Color.White;
            lblHora.Location = new Point(802, 406);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(96, 40);
            lblHora.TabIndex = 1;
            lblHora.Text = "Hora";
            lblHora.Click += lblHora_Click;
            // 
            // frmPresentacion
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            BackgroundImage = Properties.Resources.Foto_de_portadaED1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1013, 461);
            Controls.Add(lblHora);
            Controls.Add(btnIngresarPrograma);
            DoubleBuffered = true;
            Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = Color.WhiteSmoke;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmPresentacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienbenido A ValdomeroSP1";
            WindowState = FormWindowState.Maximized;
            Load += frmPresentacion_Load;
            Resize += frmPresentacion_Resize_1;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarPrograma;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.Label lblHora;
    }
}