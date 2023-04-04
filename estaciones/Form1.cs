using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult msj = MessageBox.Show("¿Deseas salir del programa?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (msj == DialogResult.OK)
            {
                Close();
            }
            else
            {

                btnVerano.Focus();

            }
        }

        private void btnReseteo_Click(object sender, EventArgs e)
        {
            try
            {

                btnVerano.Enabled = true;
                btnPrimavera.Enabled = true;
                btnOtono.Enabled = true;
                btnInvierno.Enabled = true;
                btnMiFoto.Enabled = true;

                btnAtras.Enabled = false;
                btnReseteo.Enabled = false;

                btnAtras.BackColor = Color.Transparent;
                btnVerano.BackColor = Color.Transparent;
                btnPrimavera.BackColor = Color.Transparent;
                btnOtono.BackColor = Color.Transparent;
                btnInvierno.BackColor = Color.Transparent;
                btnMiFoto.BackColor = Color.Transparent;

                btnSiguiente.BackColor = Color.Transparent;
                btnAtras.BackColor = Color.Transparent;
                btnReseteo.BackColor = Color.Transparent;
                btnSalir.BackColor = Color.Transparent;

                lblTitulo.Text = "Estaciones del año";
                lblTitulo.BackColor = Color.Transparent;

                ptbInicio.Visible = true;
                ptbVerano.Visible = false;
                ptbPrimavera.Visible = false;
                ptbOtono.Visible = false;
                ptbInvierno.Visible = false;
                ptbFoto.Visible = false;

                MessageBox.Show("Se ha reseteado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch {
                MessageBox.Show("No se pudo completar la tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

            if (lblTitulo.Text == "Olguin Jimenez Ariel Victor")
            {
                Invierno();
            }
            else if (lblTitulo.Text == "Invierno")
            {
                Otoño();
            }
            else if (lblTitulo.Text == "Otoño")
            {
                Primavera();
            }
            else
            {
                Verano();
            }


        }

        private void btnVerano_Click(object sender, EventArgs e)
        {

            Verano();

        }

        private void btnPrimavera_Click(object sender, EventArgs e)
        {
            Primavera();
        }

        private void btnOtono_Click(object sender, EventArgs e)
        {
            Otoño();
        }

        private void btnInvierno_Click(object sender, EventArgs e)
        {
            Invierno();
        }

        private void btnMiFoto_Click(object sender, EventArgs e)
        {
            MiFoto();
        }

        private void Verano()
        {

            btnVerano.Enabled = false;
            btnPrimavera.Enabled = true;
            btnOtono.Enabled = true;
            btnInvierno.Enabled = true;
            btnMiFoto.Enabled = true;

            btnSiguiente.Enabled = true;
            btnAtras.Enabled = false;
            btnReseteo.Enabled = true;

            btnAtras.BackColor = Color.LightSteelBlue;
            btnVerano.BackColor = Color.LightSteelBlue;
            btnPrimavera.BackColor = Color.LightSteelBlue;
            btnOtono.BackColor = Color.LightSteelBlue;
            btnInvierno.BackColor = Color.LightSteelBlue;
            btnMiFoto.BackColor = Color.LightSteelBlue;

            btnSiguiente.BackColor = Color.LightSteelBlue;
            btnAtras.BackColor = Color.LightSteelBlue;
            btnReseteo.BackColor = Color.LightSteelBlue;
            btnSalir.BackColor = Color.LightSteelBlue;


            lblTitulo.Text = "Verano";
            lblTitulo.BackColor = Color.LightSteelBlue;

            ptbInicio.Visible = false;
            ptbVerano.Visible = true;
            ptbPrimavera.Visible = false;
            ptbOtono.Visible = false;
            ptbInvierno.Visible = false;
            ptbFoto.Visible = false;

        }

        private void Primavera()
        {

            btnVerano.Enabled = true;
            btnPrimavera.Enabled = false;
            btnOtono.Enabled = true;
            btnInvierno.Enabled = true;
            btnMiFoto.Enabled = true;

            btnSiguiente.Enabled = true;
            btnAtras.Enabled = true;
            btnReseteo.Enabled = true;

            btnAtras.BackColor = Color.Khaki;
            btnVerano.BackColor = Color.Khaki;
            btnPrimavera.BackColor = Color.Khaki;
            btnOtono.BackColor = Color.Khaki;
            btnInvierno.BackColor = Color.Khaki;
            btnMiFoto.BackColor = Color.Khaki;

            btnSiguiente.BackColor = Color.Khaki;
            btnAtras.BackColor = Color.Khaki;
            btnReseteo.BackColor = Color.Khaki;
            btnSalir.BackColor = Color.Khaki;

            lblTitulo.Text = "Primavera";
            lblTitulo.BackColor = Color.Khaki;

            ptbInicio.Visible = false;
            ptbVerano.Visible = false;
            ptbPrimavera.Visible = true;
            ptbOtono.Visible = false;
            ptbInvierno.Visible = false;
            ptbFoto.Visible = false;

        }

        private void Otoño()
        {

            btnVerano.Enabled = true;
            btnPrimavera.Enabled = true;
            btnOtono.Enabled = false;
            btnInvierno.Enabled = true;
            btnMiFoto.Enabled = true;

            btnSiguiente.Enabled = true;
            btnAtras.Enabled = true;
            btnReseteo.Enabled = true;

            btnAtras.BackColor = Color.AntiqueWhite;
            btnVerano.BackColor = Color.AntiqueWhite;
            btnPrimavera.BackColor = Color.AntiqueWhite;
            btnOtono.BackColor = Color.AntiqueWhite;
            btnInvierno.BackColor = Color.AntiqueWhite;
            btnMiFoto.BackColor = Color.AntiqueWhite;
            btnReseteo.BackColor = Color.AntiqueWhite;
            btnSalir.BackColor = Color.AntiqueWhite;

            btnSiguiente.BackColor = Color.AntiqueWhite;
            btnAtras.BackColor = Color.AntiqueWhite;

            lblTitulo.Text = "Otoño";
            lblTitulo.BackColor = Color.AntiqueWhite;

            ptbInicio.Visible = false;
            ptbVerano.Visible = false;
            ptbPrimavera.Visible = false;
            ptbOtono.Visible = true;
            ptbInvierno.Visible = false;
            ptbFoto.Visible = false;

        }
        private void Invierno()
        {

            btnVerano.Enabled = true;
            btnPrimavera.Enabled = true;
            btnOtono.Enabled = true;
            btnInvierno.Enabled = false;
            btnMiFoto.Enabled = true;

            btnSiguiente.Enabled = true;
            btnAtras.Enabled = true;
            btnReseteo.Enabled = true;

            btnAtras.BackColor = Color.LightCyan;
            btnVerano.BackColor = Color.LightCyan;
            btnPrimavera.BackColor = Color.LightCyan;
            btnOtono.BackColor = Color.LightCyan;
            btnInvierno.BackColor = Color.LightCyan;
            btnMiFoto.BackColor = Color.LightCyan;

            btnSiguiente.BackColor = Color.LightCyan;
            btnAtras.BackColor = Color.LightCyan;
            btnReseteo.BackColor = Color.LightCyan;
            btnSalir.BackColor = Color.LightCyan;

            lblTitulo.Text = "Invierno";
            lblTitulo.BackColor = Color.LightCyan;

            ptbInicio.Visible = false;
            ptbVerano.Visible = false;
            ptbPrimavera.Visible = false;
            ptbOtono.Visible = false;
            ptbInvierno.Visible = true;
            ptbFoto.Visible = false;

        }

        private void MiFoto()
        {
            btnVerano.Enabled = true;
            btnPrimavera.Enabled = true;
            btnOtono.Enabled = true;
            btnInvierno.Enabled = true;
            btnMiFoto.Enabled = false;

            btnSiguiente.Enabled = false;
            btnAtras.Enabled = true;
            btnReseteo.Enabled = true;

            btnAtras.BackColor = Color.Pink;
            btnVerano.BackColor = Color.Pink;
            btnPrimavera.BackColor = Color.Pink;
            btnOtono.BackColor = Color.Pink;
            btnInvierno.BackColor = Color.Pink;
            btnMiFoto.BackColor = Color.Pink;

            btnSiguiente.BackColor = Color.Pink;
            btnAtras.BackColor = Color.Pink;
            btnReseteo.BackColor = Color.Pink;
            btnSalir.BackColor = Color.Pink;

            lblTitulo.Text = "Olguin Jimenez Ariel Victor";
            lblTitulo.BackColor = Color.Pink;

            ptbInicio.Visible = false;
            ptbVerano.Visible = false;
            ptbPrimavera.Visible = false;
            ptbOtono.Visible = false;
            ptbInvierno.Visible = false;
            ptbFoto.Visible = true;

        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
       
            if (lblTitulo.Text == "Estaciones del año")
            {
                Verano();
            }
            else if (lblTitulo.Text == "Verano")
            {
                Primavera();
            }
            else if (lblTitulo.Text == "Primavera")
            {
                Otoño();
            }
            else if (lblTitulo.Text == "Otoño")
            {
                Invierno();
            }
            else
            {
                MiFoto();
            }

        }

    }
}
