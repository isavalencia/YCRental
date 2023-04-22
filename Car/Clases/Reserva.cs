using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Car.Clases
{

    class Reserva
    {
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader leerfilas;
        internal string operacion;

        //ENCAPSULAMIENTO
        //ATRIBUTOS 
        private int id_reserva;
        private int id_cliente;
        private int id_vehiculo;
        private decimal costoestimado;
        private int id_empleado;
        private string hora;
        private string fecha;

        public int Id_reserva { get => id_reserva; set => id_reserva = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_vehiculo { get => id_vehiculo; set => id_vehiculo = value; }
        public decimal Costoestimado { get => costoestimado; set => costoestimado = value; }
        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Fecha { get => fecha; set => fecha = value; }


        //metodos/funciones


        public static DataTable consultaReserva()
        {
            DataTable listaReservas = new DataTable();
            SqlCommand comando = new SqlCommand("select reserva.id_reserva, reserva.fecha, clientes.id_cliente,clientes.nombres, vehiculo.id_vehiculo,vehiculo.placa, reserva.costoestimado, empleado.id_empleado,empleado.nombre, reserva.hora from reserva INNER JOIN clientes ON clientes.id_cliente = reserva.id_cliente INNER JOIN vehiculo ON vehiculo.id_vehiculo = reserva.id_vehiculo INNER JOIN empleado ON empleado.id_empleado = reserva.id_empleado", Conexion.Conectar());

            try
            {
                SqlDataAdapter adap = new SqlDataAdapter(comando);
                adap.Fill(listaReservas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Consulta de Reserva" + ex);
            }
            finally
            {
                Conexion.Conectar().Close();
            }

            return listaReservas;
        }


        public DataTable ListarClientes()
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "ListarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            leerfilas = comando.ExecuteReader();
            tabla.Load(leerfilas);
            leerfilas.Close();
            Conexion.Conectar().Close();
            return tabla;
        }


        public DataTable ListarVehiculo()
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "ListarVehiculo";
            comando.CommandType = CommandType.StoredProcedure;
            leerfilas = comando.ExecuteReader();
            tabla.Load(leerfilas);
            leerfilas.Close();
            Conexion.Conectar().Close();
            return tabla;
        }

        public DataTable ListarEmpleado()
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "ListarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            leerfilas = comando.ExecuteReader();
            tabla.Load(leerfilas);
            leerfilas.Close();
            Conexion.Conectar().Close();
            return tabla;
        }

        public DataTable ListarReservas()
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "ListarReserva";
            comando.CommandType = CommandType.StoredProcedure;
            leerfilas = comando.ExecuteReader();
            tabla.Load(leerfilas);
            leerfilas.Close();
            Conexion.Conectar().Close();
            return tabla;
        }



        public void insertarReserva()
        {

            comando.Connection = Conexion.Conectar();
            comando.CommandText = "InsertarReserva";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_cliente", id_cliente);
            comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);
            comando.Parameters.AddWithValue("@costoestimado", costoestimado);
            comando.Parameters.AddWithValue("@id_empleado", id_empleado);
            comando.Parameters.AddWithValue("@hora", hora);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.ExecuteNonQuery();
            //comando.Parameters.Clear();


        }

        public void editarReserva()
        {
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "update reserva set id_cliente=" + id_cliente + ",id_vehiculo=" + id_vehiculo + ",costoestimado=" + costoestimado + ", id_empleado=" + id_empleado + ",hora='" + hora + "',fecha='" + fecha + "' where id_reserva=" + id_reserva + "";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            Conexion.Conectar().Close();
        }

        public void eliminarReserva()
        {
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "delete reserva where id_reserva=" + id_reserva;
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            Conexion.Conectar().Close();
        }



        //public List<Object> buscarReserva(String dato)
        //{
        //    Conexion.Conectar();
        //    DataSet ds = new DataSet();
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("")
        //    }
        //}


    }
}
