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

namespace Car
{
    public partial class RegistroContrato : Form
    {
        public RegistroContrato()
        {
            InitializeComponent();
        }
        public string operacion = "insertar";
        internal string id_contrato;

        Contrato contra = new Contrato();
        ContratoDetalle deta = new ContratoDetalle();


        private void RegistroContrato_Load(object sender, EventArgs e)
        {
            ListarClientes();
            ListarVehiculo();
            ListarAlquileres();
        }

        private void btnGuardarContra_Click(object sender, EventArgs e)
        {

            if (operacion == "insertar")
            {

                try
                {
                    contra.Fecha = dtpFecha.Value.ToString("yyyy-MM-dd");
                    contra.Id_cliente = Convert.ToInt32(cbCliente.SelectedValue);
                    contra.Id_alquiler = Convert.ToInt32(cbAlquiler.SelectedValue);
                    contra.Dias = Convert.ToInt32(txtDias.Text);
                    contra.Precio = Convert.ToDecimal(txtPrecio.Text);
                    contra.Telefono = txtTelefono.Text;
                    contra.Correo = txtCorreo.Text;
                    contra.Referencia = txtReferencia.Text;
                    contra.Tipo_pago = txtTipoPag.Text;
                    contra.Num_referencia = txtNumeroRefe.Text;
                    contra.Total_renta = Convert.ToDecimal(txtTotalRent.Text);
                    contra.Id_vehiculo = Convert.ToInt32(cbVehiculo.SelectedValue);


                    contra.InsertarContrato();

                    MessageBox.Show("Datos de Contrato insertados correctamente");
                    deta.Show();
                    this.Hide();
                }
                catch (Exception l)
                {
                    MessageBox.Show("No se  insertaron los datos del contrato" + l);
                }
            }
            else if (operacion == "editar")
            {
                try
                {
                    contra.Fecha = dtpFecha.Value.ToString("yyyy-MM-dd");
                    contra.Dias = Convert.ToInt32(txtDias.Text);
                    contra.Id_alquiler = Convert.ToInt32(cbAlquiler.SelectedValue);
                    contra.Id_cliente = Convert.ToInt32(cbCliente.SelectedValue);
                    contra.Id_vehiculo = Convert.ToInt32(cbVehiculo.SelectedValue);
                    contra.Correo = txtCorreo.Text;
                    contra.Telefono = txtTelefono.Text;
                    contra.Precio = Convert.ToDecimal(txtPrecio.Text);
                    contra.Total_renta = Convert.ToDecimal(txtTotalRent.Text);
                    contra.Tipo_pago = txtTipoPag.Text;
                    contra.Referencia = txtReferencia.Text;
                    contra.Num_referencia = txtNumeroRefe.Text;
                    contra.Id_contrato = Convert.ToInt32(id_contrato);

                    contra.editarContrato();

                    MessageBox.Show("Datos de Contrato se actualizaron correctamente");

                    deta.Show();
                    this.Hide();
                }
                catch (Exception l)
                {
                    MessageBox.Show("No se  actualizaron los datos del contrato" + l);
                }

            }
        }

        public void ListarClientes()
        {
            Contrato mostrar = new Contrato();
            cbCliente.DataSource = mostrar.NombreCliente();
            cbCliente.DisplayMember = "nombres";
            cbCliente.ValueMember = "id_cliente";
        }

        public void ListarAlquileres()
        {
            Contrato mostrar = new Contrato();
            cbAlquiler.DataSource = mostrar.IdAlquiler();
            cbAlquiler.DisplayMember = "id_alquiler";
            cbAlquiler.ValueMember = "id_alquiler";
        }

        public void ListarVehiculo()
        {
            Contrato mostrar = new Contrato();
            cbVehiculo.DataSource = mostrar.PlacaVehiculo();
            cbVehiculo.DisplayMember = "placa";
            cbVehiculo.ValueMember = "id_vehiculo";
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ContratoDetalle mostrar = new ContratoDetalle();
            mostrar.Show();
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

        private void RegistroContrato_MouseMove(object sender, MouseEventArgs e)
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
    }
}

