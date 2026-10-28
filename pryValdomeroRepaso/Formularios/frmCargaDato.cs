namespace pryValdomeroRepaso
{
    public partial class frmCargaDato : Form
    {
        public frmCargaDato()
        {
            InitializeComponent();
        }
       


        private void frmCargaDato_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // 1. Establecemos y declaramos las variables primero
            int codigo = 0;
            string nombre = string.Empty;
            //string nombre;

            // 2. Validamos el campo numérico y asignamos el valor
            if (int.TryParse(txtCodigo.Text, out codigo))
            {
                // Asignamos el valor del nombre
                nombre = txtNombre.Text;

                // 3. Mostramos el mensaje con las variables ya listas
                MessageBox.Show($"Código: {codigo}\nNombre: {nombre}",
                                "Datos Ingresados",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido en el código.",
                                "Error de validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtCodigo.Focus();
                txtCodigo.SelectAll();
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Obtenemos el valor numérico (ASCII) del carácter presionado
            int codigoAscii = e.KeyChar;

            // Verificamos si está entre 48 y 57 (números del 0 al 9) o si es Backspace (8)
            if ((codigoAscii >= 48 && codigoAscii <= 57) || codigoAscii == 8)
            {
                // Permitimos que la tecla se escriba
                e.Handled = false;
            }
            else
            {
                // Bloqueamos cualquier otra tecla (letras, símbolos, espacios)
                e.Handled = true;
            }
        }
    }
}

//opcion 2
/* private void btnIngresar_Click(object sender, EventArgs e)
{
    try
    {
        // Intenta convertir directamente; si falla, salta al bloque catch
        int codigo = int.Parse(txtCodigo.Text);
        string nombre = txtNombre.Text;

        MessageBox.Show($"Código: {codigo}\nNombre: {nombre}", 
                        "Datos Ingresados", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
    }
    catch (FormatException)
    {
        MessageBox.Show("Por favor, ingrese un valor numérico válido en el código.", 
                        "Error de formato", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);
        
        txtCodigo.Focus();
        txtCodigo.SelectAll();
    }
}*/


