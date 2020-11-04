using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Collections;

namespace BLL
{
    public class NPersona
    {
        /*Metodo para traer los datos a traves del EF*/
        public List<EPersona> cargarPersonas(string pgenero)
        {
            List<EPersona> listado = new List<EPersona>();
            using (UTNEntities db = new UTNEntities())
            {
                /*    var lst = from p in db.PERSONAS
                              select p;*/

                var lst = from d in db.PERSONAS.ToList()
                          select new EPersona
                          {
                              Id = d.ID,
                              Codigo = d.CODIGO,
                              Cedula = d.CEDULA,
                              Nombre = d.NOMBRE,
                              Apellido1 = d.APELLIDO1,
                              Apellido2 = d.APELLIDO2,
                              Genero = (new Func<string>(() =>
                              {
                                  if (d.GENERO == 1)
                                  { return "MASCULINO"; }
                                  else
                                  { return "FEMENINO"; }
                              })
                                 )(),
                              FechaNacimiento = d.FECHA_NACIMIENTO,
                              Email = d.EMAIL
                          };

                if (!string.IsNullOrEmpty(pgenero))
                {
                    lst = lst.Where(p => p.Genero == pgenero);
                }
                /*    if (!string.IsNullOrEmpty(pcedula))
                    {
                        lst = lst.Where(p => p.Cedula == pcedula);
                    }*/

                foreach (var i in lst)
                {
                    listado.Add(new EPersona(i.Id, i.Codigo, i.Cedula, i.Nombre, i.Apellido1, i.Apellido2,
                        i.Genero, i.FechaNacimiento, i.Email));
                }
            }
            return listado;
        }

        public void GuardarPersona(int codigo, string cedula, string nombre, string apellido1, string apellido2, DateTime fecha,
            int genero, string email,int pid = 0)
        {
            using (UTNEntities db = new UTNEntities())
            {
                PERSONAS persona = null;
                if (pid==0)
                {
                    persona = new PERSONAS();
                }
                else
                {
                    persona = db.PERSONAS.Find(pid);
                }
                persona.CODIGO = codigo;
                persona.CEDULA = cedula;
                persona.NOMBRE = nombre;
                persona.APELLIDO1 = apellido1;
                persona.APELLIDO2 = apellido2;
                persona.GENERO = genero;
                persona.FECHA_NACIMIENTO = fecha;
                persona.EMAIL = email;

                if (pid == 0)
                {
                    db.PERSONAS.Add(persona);
                }
                else
                {
                    db.Entry(persona).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
            }
        }
                
        /*Eliminar persona con EF */
        public void EliminaPersona(int pid) {
            using (UTNEntities db = new UTNEntities()) {
                PERSONAS persona;
                persona = db.PERSONAS.Find(pid);
                db.PERSONAS.Remove(persona);
                db.SaveChanges();
            }


        }

        public ArrayList TelefonosPersona() {

            ArrayList lstTelefono = new ArrayList();
            using (UTNEntities db = new UTNEntities())
            {
                var qs= (from pe in db.PERSONAS 
                         join te in db.TELEFONOS
                         on pe.ID equals te.IDCLIENTE
                         where te.ESTADO==1
                         select new ETelefono { 
                         Id=te.ID,
                         Cedula=pe.CEDULA,
                         Nombre= pe.NOMBRE,
                         Telefono= te.TELEFONO
                        
                         }).ToList();
                foreach (var i in qs)
                {
                    lstTelefono.Add(i);
                }
            } return lstTelefono;
        }



        /*CArgar datos desde un SP de sql server*/

        public List<SPCompras> CargaCompras() {
            using (var lst = new UTNEntities()) {
           return     lst.Database.SqlQuery<SPCompras>("PA_COMPRAS").ToList();
            }
        }


        public void AplicarDescuentos(int descuento) {
            using (var d = new UTNEntities()) {
                d.Database.ExecuteSqlCommand("PA_APLICA_DESCUENTO @P0", descuento);
            
            }
        }
    }

}

