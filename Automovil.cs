using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerSistematico
{
    public partial class Automovil
    {
        public String Marca { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public double CapacidadTanque { get; set; }
        public double NivelCombustible { get; set; } = 0;

        public double RendimientoCombustible { get; set; }

        public Automovil(string marca, string placa, string modelo, string color, double capacidadTanque)
        {
            this.Marca = marca;
            this.Placa = placa;
            this.Modelo = modelo;
            this.Color = color;
            this.CapacidadTanque = capacidadTanque;

        }
    }
}
