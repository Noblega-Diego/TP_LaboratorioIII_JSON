using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TPJSON.dao;
using TPJSON.models;

namespace TPJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            DBconnection dao = new DBconnection();
            MySqlCommand command = new MySqlCommand("SELECT id, nombre, apellido, dni FROM escritores") 
            {Connection = dao.getConnection()};
            MySqlDataReader reader = command.ExecuteReader();
            List<Escritor> escritores = new List<Escritor>();
            while (reader.Read())
            {
                Escritor escritor = new Escritor()
                {
                    Id = reader.GetInt64("id"),
                    Apellido = reader.GetString("apellido"),
                    Nombre = reader.GetString("nombre"),
                    Dni = reader.GetInt64("dni")
                };
                escritores.Add(escritor);
            }
            reader.Close();

            foreach(Escritor escritor in escritores)
            {
                command.CommandText = "SELECT id, nombre, anio_publicacion, editorial FROM libros where escritor_id="+ escritor.Id;
                reader = command.ExecuteReader();
                while (reader.Read()) {
                    Libro libro = new Libro()
                    {
                        Id = reader.GetInt64("id"),
                        Nombre = reader.GetString("nombre"),
                        Editorial = reader.GetString("editorial"),
                        FechaPublicacion = reader.GetDateTime("anio_publicacion")
                    };
                    escritor.Libros.Add(libro);
                }
                reader.Close();
            }
            Console.WriteLine(JsonConvert.SerializeObject(escritores.ToArray(),Formatting.Indented));
            
        }
    }
}
