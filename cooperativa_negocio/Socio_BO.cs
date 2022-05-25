using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cooperativa_datos;

namespace cooperativa_negocio
{
    public class Socio_BO
    {
        public static List<SOCIO> getList(string filtro)
        {
            try
            {
                return Socio_DAO.getList(filtro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
