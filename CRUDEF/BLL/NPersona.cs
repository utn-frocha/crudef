using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class NPersona
    {
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
                    lst = lst.Where(p => p.Genero == "MASCULINO");
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
        }

    }

