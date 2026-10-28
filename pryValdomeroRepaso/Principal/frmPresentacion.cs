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
    public partial class frmPresentacion : Form
    {
        public frmPresentacion()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            tmrHora.Interval = 1000;
            tmrHora.Start();// Inicia el temporizador para actualizar la hora cada segundo
        }

        private void frmPresentacion_Load(object sender, EventArgs e)
        {
            CentrarBoton();// Ajusta la posición del botón al cargar el formulario

            btnIngresarPrograma.Font = new Font("Segoe UI", 18, FontStyle.Bold);// Establece el tamaño de fuente del botón
            btnIngresarPrograma.Width = 450;
            btnIngresarPrograma.Height = 80;

            PosicionarHora();// Ajusta la posición del label de hora al cargar el formulario
        }

        private void CentrarBoton()// Ajusta la posición del botón
        {
            btnIngresarPrograma.Left = (this.ClientSize.Width - btnIngresarPrograma.Width) / 2;
            btnIngresarPrograma.Top = (int)(this.ClientSize.Height * 0.60); 
        }

        private void PosicionarHora()//Con esto ajustas la posisión del label
        {
            lblHora.Left = this.ClientSize.Width - lblHora.Width - 220;
            lblHora.Top = this.ClientSize.Height - lblHora.Height - 50;
        }

        private void btnIngresarPrograma_Click(object sender, EventArgs e)
        {
            frmInicioSesion sp = new frmInicioSesion();// Creamos la instancia del formulario de claves
            sp.Show();// Lo mostramos en pantalla

            this.Hide();// Opcional: Si quieres ocultar el formulario actual para que no quede atrás
        }

        private void frmPresentacion_Resize_1(object sender, EventArgs e)
        {
            CentrarBoton();
        }

        private void btnIngresarPrograma_MouseEnter(object sender, EventArgs e)// evento para cambiar el tamaño de fuente del botón al pasar el mouse por encima
        {
            btnIngresarPrograma.Font = new Font("Segoe UI", 20, FontStyle.Bold);
        }

        private void btnIngresarPrograma_MouseLeave(object sender, EventArgs e)
        {
            btnIngresarPrograma.Font = new Font("Segoe UI", 18, FontStyle.Bold);
        }

        private void tmrHora_Tick(object sender, EventArgs e)// evento para actualizar la hora cada segundo
        {
            lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");// Actualiza la hora cada segundo
        }
        private void lblHora_Click(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }  
    }
}
