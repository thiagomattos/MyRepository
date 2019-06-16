using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraCombustivel.Model
{
    public class Combustivel
    {
        public double Preco { get; set; }

        public double Consumo { get; set; }

        public double Gasto()
        {
            return Preco / Consumo;
        }
    }
}
