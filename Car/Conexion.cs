using System.Data.SqlClient;

namespace Car
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=DESKTOP-JLC5M7I;DATABASE=yalexrenta;Integrated security=true");

            cn.Open();

            return cn;
        }
    }
}
