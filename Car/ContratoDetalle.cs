using Car.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Car.Report;

namespace Car
{
    public partial class ContratoDetalle : Form
    {
        public ContratoDetalle()
        {
            InitializeComponent();
        }
        private void ContratoDetalle_Load(object sender, EventArgs e)
        {
            MostrarContrato();
        }

        Contrato contra = new Contrato();
        private void MostrarContrato()
        {
            Contrato mostrar = new Contrato();
            dgContratos.DataSource = mostrar.MostrarContrato();
        }


        private void btnNuevoContrato_Click(object sender, EventArgs e)
        {
            RegistroContrato regis = new RegistroContrato();
            regis.Show();
            this.Close();
        }

        private void btnEditarContrato_Click(object sender, EventArgs e)
        {
            if (dgContratos.SelectedRows.Count > 0)
            {
                RegistroContrato regis = new RegistroContrato();
                regis.operacion = "editar";
                regis.ListarAlquileres();
                regis.ListarClientes();
                regis.id_contrato = dgContratos.CurrentRow.Cells[0].Value.ToString();
                regis.cbCliente.Text = dgContratos.CurrentRow.Cells[1].Value.ToString();
                regis.cbVehiculo.Text = dgContratos.CurrentRow.Cells[4].Value.ToString();
                regis.cbAlquiler.Text = dgContratos.CurrentRow.Cells[6].Value.ToString();
                regis.dtpFecha.Text = dgContratos.CurrentRow.Cells[7].Value.ToString();
                regis.txtDias.Text = dgContratos.CurrentRow.Cells[9].Value.ToString();
                regis.txtTelefono.Text = dgContratos.CurrentRow.Cells[10].Value.ToString();
                regis.txtCorreo.Text = dgContratos.CurrentRow.Cells[11].Value.ToString();
                regis.txtReferencia.Text = dgContratos.CurrentRow.Cells[12].Value.ToString();
                regis.txtNumeroRefe.Text = dgContratos.CurrentRow.Cells[13].Value.ToString();
                regis.txtPrecio.Text = dgContratos.CurrentRow.Cells[14].Value.ToString();
                regis.txtTotalRent.Text = dgContratos.CurrentRow.Cells[15].Value.ToString();
                regis.txtTipoPag.Text = dgContratos.CurrentRow.Cells[16].Value.ToString();


                regis.ShowDialog();
                MostrarContrato();
                this.Close();

            }
            else
            {
                MessageBox.Show("---- Selecciones una fila para editarla -----");
            }
        }

        private void btnEliminarContrato_Click(object sender, EventArgs e)
        {
            if (dgContratos.CurrentRow.Index > 0)
            {
                contra.Id_contrato = Convert.ToInt32(dgContratos.CurrentRow.Cells[0].Value);
                contra.eliminarContrato();
                MessageBox.Show("Registro Eliminado");
                MostrarContrato();
            }
            else
            {
                MessageBox.Show("---- Selecciones una fila para Eliminarla -----");
            }
        }


        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            string dato = "%" + txtbusqueda.Text + "%";
            getBuscar(dato);
        }

        private void getBuscar(string dato)
        {

            SqlCommand cmd = Conexion.Conectar().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT contratos.id_contrato As Id, clientes.id_cliente As Id_cliente,  clientes.nombres As Nombres, clientes.apellidos As Apellidos, vehiculo.id_vehiculo as Id_vehiculo, vehiculo.placa as Placa, alquileres.id_alquiler As Id_alquiler, contratos.Fecha As Fecha_Inicio, alquileres.finalizacion_alquiler As Fecha_Finalizacion, contratos.dias As Dias, contratos.telefono As Telefono, contratos.correo As Correo, contratos.referencia As Referencia, contratos.num_referencia As Numero_Referencia, contratos.precio As Precio, contratos.total_renta As Total_Renta, contratos.tipo_pago As Tipo_Pago, alquileres.estado As Estado FROM contratos INNER JOIN clientes ON clientes.id_cliente = contratos.id_cliente INNER JOIN alquileres ON alquileres.id_alquiler = contratos.id_alquiler INNER JOIN vehiculo ON vehiculo.id_vehiculo = contratos.id_vehiculo Where clientes.nombres like('" + txtbusqueda.Text + "%')  or clientes.apellidos like('" + txtbusqueda.Text + "%') or contratos.correo like('" + txtbusqueda.Text + "%') or vehiculo.placa like('" + txtbusqueda.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dgContratos.DataSource = dt;

            Conexion.Conectar().Close();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador("nombre");
            admin.Show();
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int posY = 0;
        int posX = 0;

        private void panel2_MouseMove(object sender, MouseEventArgs e)
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

        private void ContratoDetalle_MouseMove(object sender, MouseEventArgs e)
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

        private void btnPdfContrato_Click(object sender, EventArgs e)
        {
            //ReporteContrato report = new ReporteContrato();
            //report.Show();

        }
    }
}

