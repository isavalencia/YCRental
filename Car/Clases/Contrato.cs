using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Car.Clases
{
    class Contrato
    {

        private SqlCommand comando = new SqlCommand();
        private SqlDataReader listasContratos;

        private int id_contrato;
        private string fecha;
        private int id_cliente;
        private int id_alquiler;
        private int dias;
        private decimal precio;
        private string telefono;
        private string correo;
        private string referencia;
        private string tipo_pago;
        private string num_referencia;
        private decimal total_renta;
        private int id_vehiculo;

        private string nombres;
        private string apellidos;
        private string placa;

        public int Id_contrato { get => id_contrato; set => id_contrato = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_alquiler { get => id_alquiler; set => id_alquiler = value; }
        public int Dias { get => dias; set => dias = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Referencia { get => referencia; set => referencia = value; }
        public string Tipo_pago { get => tipo_pago; set => tipo_pago = value; }
        public string Num_referencia { get => num_referencia; set => num_referencia = value; }
        public decimal Total_renta { get => total_renta; set => total_renta = value; }
        public int Id_vehiculo { get => id_vehiculo; set => id_vehiculo = value; }

        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Placa { get => placa; set => placa = value; }

        public void InsertarContrato()
        {
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "InsertarContratos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@id_cliente", id_cliente);
            comando.Parameters.AddWithValue("@id_alquiler", id_alquiler);
            comando.Parameters.AddWithValue("@dias", dias);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@referencia", referencia);
            comando.Parameters.AddWithValue("@tipopago", tipo_pago);
            comando.Parameters.AddWithValue("@numrefe", num_referencia);
            comando.Parameters.AddWithValue("@totalrenta", total_renta);
            comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);

            comando.ExecuteNonQuery();

        }

        public void editarContrato()
        {
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "ActualizarContratos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_contrato", id_contrato);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@id_cliente", id_cliente);
            comando.Parameters.AddWithValue("@id_alquiler", id_alquiler);
            comando.Parameters.AddWithValue("@dias", dias);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@Correo", correo);
            comando.Parameters.AddWithValue("@referencia", referencia);
            comando.Parameters.AddWithValue("@tipopago", tipo_pago);
            comando.Parameters.AddWithValue("@numrefe", num_referencia);
            comando.Parameters.AddWithValue("@totalrenta", total_renta);
            comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);

            comando.ExecuteNonQuery();
            Conexion.Conectar().Close();
        }

        public void eliminarContrato()
        {
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "EliminarContratos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_contrato", id_contrato);

            comando.ExecuteNonQuery();
            Conexion.Conectar().Close();
        }

        public DataTable MostrarContrato()
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "MostrarContrato";
            comando.CommandType = CommandType.StoredProcedure;
            listasContratos = comando.ExecuteReader();
            tabla.Load(listasContratos);
            listasContratos.Close();
            Conexion.Conectar().Close();
            return tabla;
        }



        public DataTable IdAlquiler()
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "MostrarAlquiler";
            comando.CommandType = CommandType.StoredProcedure;
            listasContratos = comando.ExecuteReader();
            tabla.Load(listasContratos);
            listasContratos.Close();
            Conexion.Conectar().Close();
            return tabla;
        }

        public DataTable NombreCliente()
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "ListadoNombreCliente";
            comando.CommandType = CommandType.StoredProcedure;
            listasContratos = comando.ExecuteReader();
            tabla.Load(listasContratos);
            listasContratos.Close();
            Conexion.Conectar().Close();
            return tabla;
        }

        public DataTable PlacaVehiculo()
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "PlacaVehiculo";
            comando.CommandType = CommandType.StoredProcedure;
            listasContratos = comando.ExecuteReader();
            tabla.Load(listasContratos);
            listasContratos.Close();
            Conexion.Conectar().Close();
            return tabla;
        }

        public DataTable MostrarContratoEmpleado()
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "MostrarContratoEmple";
            comando.CommandType = CommandType.StoredProcedure;
            listasContratos = comando.ExecuteReader();
            tabla.Load(listasContratos);
            listasContratos.Close();
            Conexion.Conectar().Close();
            return tabla;
        }
    }
}
