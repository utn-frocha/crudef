using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{


    public class EPersona
    {
        public int Id { get; set; }
        public int? Codigo { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Genero { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Email { get; set; }


        public EPersona()
        {

        }
        public EPersona(int id, int? codigo, string cedula, string nombre, string apellido1, 
            string apellido2, string genero, DateTime? fechaNacimiento, string email)
        {
            Id = id;
            Codigo = codigo;
            Cedula = cedula;
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Genero = genero;
            FechaNacimiento = fechaNacimiento;
            Email = email;
        }
    }
}
