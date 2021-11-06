using System;

namespace TPJSON.models
{
    class Libro
    {
        private long id;
        private string nombre;
        private DateTime fechaPublicacion;
        private string editorial;
        private Escritor autor;

        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaPublicacion { get => fechaPublicacion; set => fechaPublicacion = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        internal long Id { get => id; set => id = value; }
        internal Escritor Autor { get => autor; set => autor = value; }
    }
}