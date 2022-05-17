using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cooperativa_datos;

namespace cooperativa_negocio
{
    public class PersonaBO
    {
        public static List<PERSONA> getList(string filtro)
        {
            try
            {
                return PersonaDAO.getList(filtro);  
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
