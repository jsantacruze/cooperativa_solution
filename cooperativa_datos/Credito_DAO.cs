using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace cooperativa_datos
{
    public class Credito_DAO
    {
        public static List<CREDITO> getList(string filtro)
        {
            try
            {
                using (DB_CooperativaEntities db = new DB_CooperativaEntities())
                {
                    var result = db.CREDITO
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
