using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPJSON.models
{
    class Escritor
    {
        private long id;
        private string nombre;
        private string apellido;
        private long dni;
        private List<Libro> libros = new List<Libro>();

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public long Dni { get => dni; set => dni = value; }
        public long Id { get => id; set => id = value; }
        public List<Libro> Libros { get => libros; set => libros = value; }
    }
}
