using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace cooperativa_datos
{
    public class TipoCuenta_DAO
    {
        public static List<TIPO_CUENTA> getList(string filtro)
        {
            try
            {
                using (DB_CooperativaEntities db = new DB_CooperativaEntities())
                {
                    var result = db.TIPO_CUENTA
                        .Where(t => t.TipoCuentaID.Contains(filtro) 
                        || t.TipoCuentaNombre.Contains(filtro))
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

