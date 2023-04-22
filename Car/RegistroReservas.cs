using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car.Clases;
using System.Data.SqlClient;


namespace Car
{
    public partial class RegistroReservas : Form
    {
        Reserva reserva = new Reserva();
        //public string operacion = "insertar";
        // string idreserva;
        public RegistroReservas()
        {
            InitializeComponent();
        }

        int posY = 0;
        int posX = 0;
        //internal string idreser;
        public string operacion = "insertar";
        internal string id_reserva;
        //internal string id_alquiler;

        private void panelTituloRegistroReserva_MouseMove(object sender, MouseEventArgs e)
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
            //Administrador admin = new Administrador("nombre");
            //admin.Show();
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


        private void RegistroReservas_Load(object sender, EventArgs e)
        {
            ListarClientes();
            ListarVehiculo();
            ListarEmpleado();
        }

        public void ListarClientes()
        {
            Reserva mostrar = new Reserva();
            cbxCliente.DataSource = mostrar.ListarClientes();
            cbxCliente.DisplayMember = "nombres";
            cbxCliente.ValueMember = "id_cliente";
        }

        public void ListarVehiculo()
        {
            Reserva mostrar = new Reserva();
            cbxVehiculo.DataSource = mostrar.ListarVehiculo();
            cbxVehiculo.DisplayMember = "placa";
            cbxVehiculo.ValueMember = "id_vehiculo";
        }
        public void ListarEmpleado()
        {
            Reserva mostrar = new Reserva();
            cbxEmpleado.DataSource = mostrar.ListarEmpleado();
            cbxEmpleado.DisplayMember = "nombre";
            cbxEmpleado.ValueMember = "id_empleado";
        }
        private void btnGuardarReserva_Click(object sender, EventArgs e)
        {
            if (operacion == "insertar")
            {
                try
                {
                    reserva.Id_cliente = Convert.ToInt32(cbxCliente.SelectedValue);
                    reserva.Id_vehiculo = Convert.ToInt32(cbxVehiculo.SelectedValue);
                    reserva.Costoestimado = Convert.ToDecimal(txtPrecio.Text);
                    reserva.Id_empleado = Convert.ToInt32(cbxEmpleado.SelectedValue);
                    reserva.Hora = txtHora.Text;
                    reserva.Fecha = dtpFecha.Text;
                    reserva.insertarReserva();

                    MessageBox.Show("Datos de Reserva insertados correctamente");
                    //reserva.ListarReservas();
                }
                catch (Exception m)
                {
                    MessageBox.Show("No se  insertaron los datos de la reserva" + m);
                }
            }
            else if (operacion == "editar")
            {
                try
                {
                    reserva.Id_cliente = Convert.ToInt32(cbxCliente.SelectedValue);
                    reserva.Id_vehiculo = Convert.ToInt32(cbxVehiculo.SelectedValue);
                    reserva.Costoestimado = Convert.ToDecimal(txtPrecio.Text);
                    reserva.Id_empleado = Convert.ToInt32(cbxEmpleado.SelectedValue);
                    reserva.Hora = txtHora.Text;
                    reserva.Fecha = dtpFecha.Text;
                    reserva.Id_reserva = Convert.ToInt32(id_reserva);
                    reserva.editarReserva();


                    MessageBox.Show("Datos de Reserva editados correctamente");

                    //reserva.ListarReservas();
                }
                catch (Exception l)
                {
                    MessageBox.Show("No se  editaron los datos de la reserva" + l);
                }

            }



        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtHora.Text = "";
            this.txtPrecio.Text = "";
            cbxCliente.SelectedIndex = -1;
            cbxVehiculo.SelectedIndex = -1;

        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //insertar.insertarReserva(Convert.ToInt32(cbxCliente));
        }


    }
}
