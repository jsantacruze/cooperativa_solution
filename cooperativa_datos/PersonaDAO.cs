using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cooperativa_datos
{
    public class PersonaDAO
    {
        public static List<PERSONA> getList(string filtro)
        {
            try
            {
                using (DB_CooperativaEntities db = new DB_CooperativaEntities())
                {
                    var result = db.PERSONA
                        .Where(p => p.PersonaApellidos.Contains(filtro) || p.PersonaNombres.Contains(filtro))
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
