using System;
using System.Windows.Forms;

namespace Car
{
    public partial class Empleados : Form
    {
        public Empleados(String nombre)
        {
            InitializeComponent();
            lblMensajeEmpleado.Text = "Bienvenido/a  " + nombre;
        }

        private void Empleados_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Login log = new Login();
            log.Show();
        }

        private void btnMaxi_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            if (!panelMantenimi.Visible)
                panelMantenimi.Visible = true;
            else
                panelMantenimi.Visible = false;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (!panelReportes.Visible)
                panelReportes.Visible = true;
            else
                panelReportes.Visible = false;
        }

        private void btnAcercade_Click(object sender, EventArgs e)
        {
            if (!panelAcercaDe.Visible)
                panelAcercaDe.Visible = true;
            else
                panelAcercaDe.Visible = false;
        }
    }
}
