namespace pryValdomeroRepaso
{
    partial class frmCargaDato
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCodigo = new Label();
            lblNombre = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(87, 91);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(87, 150);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(195, 83);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(102, 23);
            txtCodigo.TabIndex = 2;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(195, 142);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(201, 23);
            txtNombre.TabIndex = 3;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(252, 226);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(144, 38);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // frmCargaDato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 366);
            Controls.Add(btnIngresar);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigo);
            Name = "frmCargaDato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingresar Datos";
            Load += frmCargaDato_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblNombre;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private Button btnIngresar;
    }
}
