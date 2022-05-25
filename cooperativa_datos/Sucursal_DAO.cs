using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace cooperativa_datos
{
    public class Sucursal_DAO
    {
        public static List<SUCURSAL> getList(string filtro)
        {
            try
            {
                using (DB_CooperativaEntities db = new DB_CooperativaEntities())
                {
                    var result = db.SUCURSAL
                        .Where(s => s.SucursalNombre.Contains(filtro) ||
                        s.SucursalDireccion.Contains(filtro))
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
