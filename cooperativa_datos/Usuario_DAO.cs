using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace cooperativa_datos
{
    public class Usuario_DAO
    {
        public static List<USUARIO> getList(string filtro)
        {
            try
            {
                using (DB_CooperativaEntities db = new DB_CooperativaEntities())
                {
                    var result = db.USUARIO
                        .Include(s => s.EMPLEADO.PERSONA)
                        .Where(s => s.EMPLEADO.PERSONA.PersonaNombres.Contains(filtro)
                        || s.EMPLEADO.PERSONA.PersonaApellidos.Contains(filtro))
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

