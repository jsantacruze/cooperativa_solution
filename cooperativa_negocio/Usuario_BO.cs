using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cooperativa_datos;

namespace cooperativa_negocio
{
    public class Usuario_BO
    {
        public static List<USUARIO> getList(string filtro)
        {
            try
            {
                return Usuario_DAO.getList(filtro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
