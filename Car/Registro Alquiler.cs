using System;
using System.Windows.Forms;
using Car.Clases;

namespace Car
{
    public partial class Registro_Alquiler : Form
    {
        Alquileres alquiler = new Alquileres();
        public Registro_Alquiler()
        {
            InitializeComponent();
        }

        int posY = 0;
        int posX = 0;

        public string operacion = "insertar";
        internal string id_alquiler;
        private void panelTituloRegistroAlquiler_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Administrador admin = new Administrador("nombre");
            admin.Show();

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

        private void panelTituloRegistroAlquiler_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ListarClientes()
        {
            Alquileres mostrar = new Alquileres();
            cbxCliente.DataSource = mostrar.ListarClientes();
            cbxCliente.DisplayMember = "nombres";
            cbxCliente.ValueMember = "id_cliente";
        }

        /*public void ListarPlacaVehiculo()
        {
            Alquileres mostrar = new Alquileres();
            cbxPlacaVehi.DataSource = mostrar.ListarVehiculo();
            cbxPlacaVehi.DisplayMember = "placa";
            cbxPlacaVehi.ValueMember = "id_vehiculo";
        }*/

        public void ListarConVehiculo()
        {
            Alquileres mostrar = new Alquileres();
            cbxCVehiculo.DataSource = mostrar.ListarConVehiculo();
            cbxCVehiculo.DisplayMember = "condicion_vehiculo";
            cbxCVehiculo.ValueMember = "id_vehiculo";
        }

        public void ListarEstadoAlquiler()
        {
            Alquileres mostrar = new Alquileres();
            cbxEstadoAl.DataSource = mostrar.ListarEstadoAlquiler();
            cbxEstadoAl.DisplayMember = "estado";
            cbxEstadoAl.ValueMember = "estado";
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtCostoAlqui.Text = "";
            cbxCliente.SelectedIndex = -1;
            cbxEstadoAl.SelectedIndex = -1;
            cbxCVehiculo.SelectedIndex = -1;
        }

        private void btnGuardarAlquiler_Click(object sender, EventArgs e)
        {
            if (operacion == "insertar")
            {
                try
                {
                    alquiler.Id_cliente = Convert.ToInt32(cbxCliente.SelectedValue);
                    alquiler.Id_vehiculo = Convert.ToInt32(cbxCVehiculo.SelectedValue);
                    alquiler.Costoalquiler = Convert.ToDecimal(txtCostoAlqui.Text);
                    alquiler.Estado = cbxEstadoAl.Text;
                    alquiler.Inicio_alquiler = dtpFechaIniAlquiler.Text;
                    alquiler.Finalizacion_alquiler = dtpFechaFinaliAlquiler.Text;
                    alquiler.insertarAlquiler();

                    MessageBox.Show("Datos de Alquiler insertados correctamente");
                    //reserva.ListarReservas();
                }
                catch (Exception l)
                {
                    MessageBox.Show("No se  insertaron los datos del alquiler" + l);
                }
            }
            else if (operacion == "editar")
            {
                try
                {
                    alquiler.Id_cliente = Convert.ToInt32(cbxCliente.SelectedValue);
                    alquiler.Id_vehiculo = Convert.ToInt32(cbxCVehiculo.SelectedValue);
                    alquiler.Costoalquiler = Convert.ToDecimal(txtCostoAlqui.Text);
                    alquiler.Estado = cbxEstadoAl.Text;
                    alquiler.Inicio_alquiler = dtpFechaIniAlquiler.Text;
                    alquiler.Finalizacion_alquiler = dtpFechaFinaliAlquiler.Text;
                    alquiler.Id_alquiler = Convert.ToInt32(id_alquiler);
                    alquiler.editarAlquiler();


                    MessageBox.Show("Datos de Alquiler editados correctamente");

                    //reserva.ListarReservas();
                }
                catch (Exception l)
                {
                    MessageBox.Show("No se  editaron los datos del alquiler" + l);
                }

            }

        }

        private void Registro_Alquiler_Load(object sender, EventArgs e)
        {
            ListarClientes();
            //ListarPlacaVehiculo();
            ListarConVehiculo();
            ListarEstadoAlquiler();
        }
    }
}
