using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//cuando te dice que un obj puede ser NULL es porque te pide que no instancies ese objeto!!!
// ¿es necesario siempre hacerlo? NO, solo si lo necesitas
namespace NuevoLogin
{
    public class Alumno
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int telefono;
        private string direccion;

        //constructor minimo que necesito
        public Alumno(string nombre, string apellido, int dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
                        
        }
        //datos extras
        public Alumno(string nombre, string apellido, int dni, int telefono, string direccion): this(nombre, apellido,dni)
        {
            this.Telefono = telefono;
            this.Dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Apellido: {Apellido}");
            sb.AppendLine($"Dni: {Dni}");
            sb.AppendLine($"Telefono: {Telefono}");
            sb.AppendLine($"Direccion: {Direccion}");

            return sb.ToString();
        }









    }
}
