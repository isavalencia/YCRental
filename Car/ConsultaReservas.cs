using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Car.Clases;
using System;


using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO; //guadado de archivos

namespace Car
{
    public partial class ConsultaReservas : Form
    {
        public ConsultaReservas()
        {
            InitializeComponent();
        }

        Reserva reserva = new Reserva();
        string operacion = "";
        //string operacion = "";
        public string id_reserva;
        //public string DateTime;
        private void panelTituloRegistroAlquiler_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, System.EventArgs e)
        {
            this.Close();
            Administrador admin = new Administrador("nombre");
            admin.Show();
        }


        private void panelTituloRegistroAlquiler_MouseHover(object sender, System.EventArgs e)
        {

        }

        private void panelTituloRegistroAlquiler_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnMaxi_Click(object sender, System.EventArgs e)
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

        private void btnMinim_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ConsultaAlquileres_Load(object sender, System.EventArgs e)
        {
            ListarReservas();
            //dgvReservas.DataSource = Reserva.consultaReserva();


        }
        int posY = 0;
        int posX = 0;
        private void panelTituloConsultaReservas_MouseMove(object sender, MouseEventArgs e)
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


        private void btnEditar_Click(object sender, System.EventArgs e)
        {

            //RegistroEdicionReservas 
            if (dgvReservas.SelectedRows.Count > 0)
            {

                RegistroReservas editreserva = new RegistroReservas();
                editreserva.operacion = "editar";
                editreserva.ListarClientes();
                editreserva.ListarVehiculo();
                editreserva.ListarEmpleado();
                editreserva.id_reserva = dgvReservas.CurrentRow.Cells[0].Value.ToString();
                editreserva.cbxCliente.Text = dgvReservas.CurrentRow.Cells[3].Value.ToString();
                editreserva.cbxVehiculo.Text = dgvReservas.CurrentRow.Cells[5].Value.ToString();
                editreserva.txtPrecio.Text = dgvReservas.CurrentRow.Cells[6].Value.ToString();
                editreserva.cbxEmpleado.Text = dgvReservas.CurrentRow.Cells[8].Value.ToString();
                editreserva.txtHora.Text = dgvReservas.CurrentRow.Cells[9].Value.ToString();
                editreserva.dtpFecha.Text = dgvReservas.CurrentRow.Cells[1].Value.ToString();

                editreserva.ShowDialog();
                ListarReservas();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void txtBuscar_TextChanged(object sender, System.EventArgs e)
        {
            String dato = "%" + txtBuscar.Text + "%";
            buscarReserva(dato);
        }

        private void buscarReserva(string dato)
        {
            SqlCommand comando = Conexion.Conectar().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select * from reserva where id_reserva like ('" + txtBuscar.Text + "%') ";
            comando.ExecuteNonQuery();
            DataTable reserva = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter(comando);
            data.Fill(reserva);
            dgvReservas.DataSource = reserva;
            Conexion.Conectar().Close();
        }


        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            //Conexion.Conectar();

            //string consulta = "select * from reserva where id_reserva like "+txtBuscar.Text +" ";

            //SqlDataAdapter adaptador = new SqlDataAdapter(consulta, Conexion.Conectar());
            //DataTable dt = new DataTable();
            //adaptador.Fill(dt);
            //dgvReservas.DataSource = dt;
            //SqlCommand comando = new SqlCommand(consulta, Conexion.Conectar());
            //SqlDataReader lector;
            //lector = comando.ExecuteReader();


            //Conexion.Conectar().Close();


        }

        private void dgvReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*RegistroReservas reservas = new RegistroReservas();

            reserva.editarReserva(
                reserva.
                
                );
            DataGridViewRow rellenar = dgvReservas.Rows[e.RowIndex];
            reservas.txtHora.Text = rellenar.Cells[""].Value.ToString();
            reservas.txtPrecio.Text = rellenar.Cells[""].Value.ToString();
            reservas.Show();*/

        }

        private void btnNuevaReserva_Click(object sender, System.EventArgs e)
        {
            RegistroReservas reservas = new RegistroReservas();
            reservas.operacion = "insertar";
            reservas.ListarClientes();
            reservas.ListarVehiculo();
            reservas.ListarEmpleado();
            reservas.ShowDialog();
            ListarReservas();



        }

        private void ListarReservas()
        {
            Reserva mostrar = new Reserva();
            dgvReservas.DataSource = mostrar.ListarReservas();
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {


            if (dgvReservas.SelectedRows.Count > 0)
            {
                //if()
                //MessageBox.Show("Esta seguro que quiere eliminar el registro?");
                reserva.Id_reserva = Convert.ToInt32(dgvReservas.CurrentRow.Cells[0].Value);
                reserva.eliminarReserva();
                MessageBox.Show("Se elimino satisfactoriamente");
                ListarReservas();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }

        }

        private void ConsultaReservas_Load(object sender, EventArgs e)
        {
            ListarReservas();
        }

        private void btnReporteReserva_Click(object sender, EventArgs e)
        {


        }
    }
}
