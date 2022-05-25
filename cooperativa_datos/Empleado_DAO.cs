using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace cooperativa_datos
{
    public class Empleado_DAO
    {
       
            public static List<EMPLEADO> getList(string filtro)
            {
                try
                {
                    using (DB_CooperativaEntities db = new DB_CooperativaEntities())
                    {
                        var result = db.EMPLEADO
                            .Include(s => s.PERSONA)
                            .Where(s => s.PERSONA.PersonaNombres.Contains(filtro)
                            || s.PERSONA.PersonaApellidos.Contains(filtro))
                            .ToList();
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }

    }



