using pryValdomeroRepaso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryValdomeroRepaso
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }



        int intentos = 0; // contador de intentos de acceso
                          // evento click del botón Aceptar

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            {
                if ((txtUsuario.Text == "Administrador" &&
                txtContrasenia.Text == "adm135$") ||
                (txtUsuario.Text == "Operador" &&
                txtContrasenia.Text == "ope246$"))
                {
                    this.Hide(); // oculta este formualrio
                    frmMenuPrincipal sistema = new frmMenuPrincipal(); // crea el frmInicio
                    sistema.Text = txtUsuario.Text; // asigna el texto de título
                    sistema.ShowDialog(); // visualiza y ejecuta el frmInicio
                    this.Show(); // visualiza nuevamente este formulario
                }
                else
                {
                    MessageBox.Show("Datos incorrectos. Acceso Denegado.");
                    intentos++; // incrementa el contador de intentos fallidos
                    if (intentos == 3) // si es 3 se cierra el formulario
                    {
                        this.Close();
                    }
                }


            }
        }

        // evento Click del botón "btnCancelar"
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmPresentacion ingresar = new frmPresentacion();// Creamos la instancia del formulario de claves
            ingresar.Show();// Lo mostramos en pantalla

            this.Hide();
            //this.Close(); // cierra el formulario



        }

       
    }
}
