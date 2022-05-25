using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cooperativa_datos;

namespace cooperativa_negocio
{
    public class Empleado_BO
    {
        public static List<EMPLEADO> GetList(string filtro)
        {
            try
            {
                return Empleado_DAO.getList(filtro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

      
