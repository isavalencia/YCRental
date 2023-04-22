using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Report
{
    public class ReportListAlquileres
    {
        private int id_alquiler;
        private string nombre;
        private string apellidos;
        private string placa;
        private string tipo_vehiculo;
        private string marca;
        private string inicio_alquiler;
        private string finalizacion_alquiler;
        private string dias;
        private decimal precio;
        private double total_alquiler;
        private string telefono;
        private string estado;
        public int Id_alquiler { get => id_alquiler; set => id_alquiler = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Tipo_vehiculo { get => tipo_vehiculo; set => tipo_vehiculo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Inicio_alquiler { get => inicio_alquiler; set => inicio_alquiler = value; }
        public string Finalizacion_alquiler { get => finalizacion_alquiler; set => finalizacion_alquiler = value; }
        public string Dias { get => dias; set => dias = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public double Total_alquiler { get => total_alquiler; set => total_alquiler = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
