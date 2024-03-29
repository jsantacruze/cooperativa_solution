﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace cooperativa_datos
{
    public class Socio_DAO
    {
        public static List<SOCIO> getList(string filtro)
        {
            try
            {
                using (DB_CooperativaEntities db = new DB_CooperativaEntities())
                {
                    var result = db.SOCIO
                        .Include(s => s.PERSONA)
                        .Where(s => s.PERSONA.PersonaNombres.Contains(filtro)
                        || s.PERSONA.PersonaApellidos.Contains(filtro))
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
