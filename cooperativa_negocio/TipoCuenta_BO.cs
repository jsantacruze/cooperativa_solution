using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cooperativa_datos;

namespace cooperativa_negocio
{
    public class TipoCuenta_BO
    {
        public static List<TIPO_CUENTA> GetList(string filtro)
        {
            try
            {
                return TipoCuenta_DAO.getList(filtro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
