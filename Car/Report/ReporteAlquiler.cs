using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Clases;

namespace Car.Report
{
    public class ReporteAlquiler
    {
        
        public DateTime fechaReporte { get; private set; }
        public List<ReportListAlquileres> listaAlqui { get; private set; }
        public double totalNetoAlquileres { get; private set; }

        public void createReporteAlquiler()
        {
            //implementamos fecha
            fechaReporte = DateTime.Now;

            //crear Lista de Alquileres
            var alquileres = new Alquileres();
            var result = alquileres.getReportAlquileres();

            listaAlqui = new List<ReportListAlquileres>();

            foreach (System.Data.DataRow rows in result.Rows)
            {
                var alquiModel = new ReportListAlquileres()
                {
                    Id_alquiler = Convert.ToInt32(rows[0]),
                    Nombre = Convert.ToString(rows[1]),
                    Apellidos = Convert.ToString(rows[2]),
                    Placa = Convert.ToString(rows[3]),
                    Tipo_vehiculo = Convert.ToString(rows[4]),
                    Marca = Convert.ToString(rows[5]),
                    Inicio_alquiler = Convert.ToString(rows[6]),
                    Finalizacion_alquiler = Convert.ToString(rows[7]),
                    Dias = Convert.ToString(rows[8]),
                    Precio = Convert.ToDecimal(rows[9]),
                    Total_alquiler = Convert.ToDouble(rows[10]),
                    Telefono = Convert.ToString(rows[11]),
                    Estado = Convert.ToString(rows[12]),
                };

                listaAlqui.Add(alquiModel);

                //Calculo total de pago de aquileres
                totalNetoAlquileres += Convert.ToDouble(rows[10]);
            }




        }
    }
}
