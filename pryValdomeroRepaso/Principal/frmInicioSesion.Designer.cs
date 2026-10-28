namespace pryValdomeroRepaso
{
    partial class frmInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
            btnAceptar = new Button();
            lblContrasenia = new Label();
            lblUsuario = new Label();
            txtContrasenia = new TextBox();
            txtUsuario = new TextBox();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnAceptar.Location = new Point(339, 416);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(130, 42);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            lblContrasenia.Location = new Point(58, 331);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(130, 26);
            lblContrasenia.TabIndex = 11;
            lblContrasenia.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            lblUsuario.Location = new Point(95, 268);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(93, 26);
            lblUsuario.TabIndex = 10;
            lblUsuario.Text = "Usuario";
            // 
            // txtContrasenia
            // 
            txtContrasenia.Font = new Font("Times New Roman", 15.75F);
            txtContrasenia.Location = new Point(225, 325);
            txtContrasenia.MaxLength = 10;
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(244, 32);
            txtContrasenia.TabIndex = 9;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Times New Roman", 15.75F);
            txtUsuario.ForeColor = SystemColors.MenuHighlight;
            txtUsuario.Location = new Point(225, 262);
            txtUsuario.MaxLength = 10;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(244, 32);
            txtUsuario.TabIndex = 8;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnCancelar.Location = new Point(150, 416);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 42);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IngresoSesion;
            pictureBox1.Location = new Point(178, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(594, 523);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblContrasenia);
            Controls.Add(lblUsuario);
            Controls.Add(txtContrasenia);
            Controls.Add(txtUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmInicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de sesion";
            Load += frmInicioSesion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Label lblContrasenia;
        private Label lblUsuario;
        private TextBox txtContrasenia;
        private TextBox txtUsuario;
        private Button btnCancelar;
        private PictureBox pictureBox1;
    }
}