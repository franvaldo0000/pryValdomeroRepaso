using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryValdomeroRepaso
{
    public partial class frmCalculo : Form
    {
        public frmCalculo()
        {
            InitializeComponent();
        }

        private void frmCalculo_Load(object sender, EventArgs e)
        {

            // Bloquea la edición manual, permitiendo solo elegir de la lista
            cmbIva.DropDownStyle = ComboBoxStyle.DropDownList;

            // Opcional: Agregar las opciones por código si aún no las cargaste en el diseñador
            /*cmbIva.Items.Add("10%");
            cmbIva.Items.Add("21%");
            cmbIva.Items.Add("No aplica");*/

        }

        private void lblIva_Click(object sender, EventArgs e)
        {

        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {

            // 

            switch (e.KeyChar)
            {
                case (char)46: // Permitir el punto decimal
                    if (txtMonto.Text.Contains("."))
                    {
                        e.Handled = true; // Si ya hay un punto, no permitir otro
                    }
                    break;
                case (char)8: // Permitir la tecla de retroceso
                    e.Handled = false;
                    break;
                default:
                    // Permitir solo números
                    if (!char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true; // Bloquear cualquier otro carácter
                    }
                    break;


            }


                 }

            
        // opcion 2
             /*// Permitir números, la tecla Backspace (control) y un único punto decimal
                if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                 {
                   e.Handled = false; // Permitir
                      }
                       else if (e.KeyChar == '.' && !txtMonto.Text.Contains("."))
                      {
                       e.Handled = false; // Permitir solo si no existe ya un punto
                       }
                       else
                       {
                       e.Handled = true;  // Bloquear cualquier otra cosa
                       }*/

        //Opcion 3
              /*
                   // Si NO es número, NO es tecla de control Y (si es punto, verifica que no esté repetido)
                   if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.' || txtMonto.Text.Contains(".")))
                   {
                    e.Handled = true; // Bloquear
                     }*/

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            {
                    // 1. Declaramos las variables primero
                    decimal monto = 0;
                    decimal resultado = 0;

                    // Obtenemos el texto seleccionado de forma directa y segura
                    string opcionIva = cmbIva.Text;

                     // 2. Validamos que el monto ingresado sea un número válido
                    if (decimal.TryParse(txtMonto.Text, out monto))
                    {
                        // Validamos que se haya seleccionado una opción en el ComboBox
                    if (cmbIva.SelectedIndex != -1)
                    {
                // 3. Realizamos el cálculo dependiendo de la opción elegida
                    switch (opcionIva)
                    {
                    case "10%":
                        resultado = monto + (monto * 0.10m);
                        break;
                    case "21%":
                        resultado = monto + (monto * 0.21m);
                        break;
                    case "No aplica":
                        resultado = monto;
                        break;
                    default:
                        resultado = monto;
                        break;
                    }

                               // 4. Mostramos el resultado en el lblResultado
                            lblResultado.Text = $"Resultado: {resultado:C2}";

                               // 5. Mostramos el mensaje de éxito requerido
                           MessageBox.Show("El cálculo se ha realizado correctamente.",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    }
                    else
                    {
                           MessageBox.Show("Por favor, seleccione una opción de IVA.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                                cmbIva.Focus();
                    }
            }
                    else
                    {
                    MessageBox.Show("Por favor, ingrese un monto numérico válido.",
                            "Error de validación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                            txtMonto.Focus();
                            txtMonto.SelectAll();
                    }
            }

        }
    }
}
