using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsolaFiguraGeometrica.Interface;

namespace ConsolaFiguraGeometrica.Modelo
{
    public class Triangulo : IFiguraGeometrica
    {
        private float _base;
        private float _altura;
        private const string Nombre = "Triangulo Equilatero";
        public Triangulo(float b, float h)
        {
            _base = b;
            _altura = h;
        }

        public float CalcularArea()
        {
            return (_base * _altura) / 2;
        }

        public float CalcularPerimetro()
        {
            return _base * 3;
        }

        public string ObtenerNombre()
        {
            return Nombre;
        }
    }
}
