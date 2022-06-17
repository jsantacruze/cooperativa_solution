using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cooperativa_datos;

namespace cooperativa_negocio
{
    public class Credito_BO
    {
        public static List<CREDITO> getList(string filtro)
        {
            try
            {
                return Credito_DAO.getList(filtro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

    