using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car.Clases;

namespace Car
{
    public partial class ConsultaAlquileres : Form
    {
        public ConsultaAlquileres()
        {
            InitializeComponent();
        }

        Alquileres alquiler = new Alquileres();
        string operacion = "";
        //string operacion = "";
        public string id_alquiler;


        int posY = 0;
        int posX = 0;
        private void panelTituloConsultaAlquileres_MouseMove(object sender, MouseEventArgs e)
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //RegistroEdicionReservas 
            if (dgvAlquileres.SelectedRows.Count > 0)
            {

                Registro_Alquiler editalqui = new Registro_Alquiler();
                editalqui.operacion = "editar";
                editalqui.ListarClientes();
                editalqui.ListarConVehiculo();
                editalqui.ListarEstadoAlquiler();
                editalqui.id_alquiler = dgvAlquileres.CurrentRow.Cells[0].Value.ToString();
                editalqui.cbxCliente.Text = dgvAlquileres.CurrentRow.Cells[1].Value.ToString();
                editalqui.cbxCVehiculo.Text = dgvAlquileres.CurrentRow.Cells[3].Value.ToString();
                editalqui.txtCostoAlqui.Text = dgvAlquileres.CurrentRow.Cells[5].Value.ToString();
                editalqui.cbxEstadoAl.Text = dgvAlquileres.CurrentRow.Cells[6].Value.ToString();
                editalqui.dtpFechaIniAlquiler.Text = dgvAlquileres.CurrentRow.Cells[7].Value.ToString();
                editalqui.dtpFechaFinaliAlquiler.Text = dgvAlquileres.CurrentRow.Cells[8].Value.ToString();


                editalqui.ShowDialog();
                ListarAlquileres();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAlquileres.SelectedRows.Count > 0)
            {
                //if()
                //MessageBox.Show("Esta seguro que quiere eliminar el registro?");
                alquiler.Id_alquiler = Convert.ToInt32(dgvAlquileres.CurrentRow.Cells[0].Value);
                alquiler.eliminarAlquiler();
                MessageBox.Show("Se elimino satisfactoriamente");
                ListarAlquileres();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
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

        private void ConsultaAlquileres_Load(object sender, EventArgs e)
        {
            ListarAlquileres();


        }

        private void ListarAlquileres()
        {
            Alquileres mostrar = new Alquileres();
            dgvAlquileres.DataSource = mostrar.ListarAlquileres();
        }

        private void btnNuevoAlquiler_Click(object sender, EventArgs e)
        {
            Registro_Alquiler alquiler = new Registro_Alquiler();
            alquiler.operacion = "insertar";
            alquiler.ListarClientes();
            alquiler.ListarEstadoAlquiler();
            alquiler.ListarConVehiculo();
            alquiler.ShowDialog();
            ListarAlquileres();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            String dato = "%" + txtBuscar.Text + "%";
            buscarAlquiler(dato);
        }
        private void buscarAlquiler(string dato)
        {
            SqlCommand comando = Conexion.Conectar().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select * from alquileres where id_alquiler like ('" + txtBuscar.Text + "%') ";
            comando.ExecuteNonQuery();
            DataTable alquiler = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter(comando);
            data.Fill(alquiler);
            dgvAlquileres.DataSource = alquiler;
            Conexion.Conectar().Close();
        }
    }
}
