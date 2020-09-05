using Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA.Cantons
{
    public class Repository
    {
        public static ObjectResponse<List<Canton>> GetAll(bool includeDeleteItems)
        {
            try
            {
                using (var db = new AppContext())
                {
                    var cantons = db.Cantons.ToList();
                    if (!includeDeleteItems)
                        cantons = cantons.Where(x => !x.Deleted).ToList();

                    return new ObjectResponse<List<Canton>>(true, "Consulta exitosa", cantons);
                }
            }
            catch (Exception e)
            {
                return new ObjectResponse<List<Canton>>(false, $"Consulta fallida {e.InnerException}");
            }

        }

        public static ObjectResponse<Canton> Get(int cantonId)
        {
            try
            {
                using (var db = new AppContext())
                {
                    var canton = db.Cantons.Find(cantonId);

                    return new ObjectResponse<Canton>(true, "Consulta exitosa", canton);
                }
            }
            catch (Exception e)
            {
                return new ObjectResponse<Canton>(false, $"Consulta fallida {e.InnerException}");
            }

        }

        public static ObjectResponse<bool> Create(Canton canton)
        {
            try
            {
                using (var db = new AppContext())
                {
                    db.Cantons.Add(canton);
                    db.SaveChanges();
                    return new ObjectResponse<bool>(true, "Creacion exitosa");
                }
            }
            catch (Exception e)
            {
                return new ObjectResponse<bool>(false, $"Creacion fallida {e.InnerException}");
            }
        }

        public static ObjectResponse<bool> Update(Canton canton)
        {
            try
            {
                using (var db = new AppContext())
                {
                    db.Entry(canton).State = EntityState.Modified;
                    db.SaveChanges();
                    return new ObjectResponse<bool>(true, "Edicion exitosa");
                }
            }
            catch (Exception e)
            {
                return new ObjectResponse<bool>(false, $"Edicion fallida {e.InnerException}");
            }

        }

        public static ObjectResponse<bool> Delete(int cantonId)
        {
            try
            {
                var canton = Get(cantonId);
                if (!canton.IsSuccess)
                    return new ObjectResponse<bool>(false, $"No ha sido posible eliminar este canton: {canton.Message}");

                canton.Data.Deleted = true;
                var response = Update(canton.Data);
                if (!response.IsSuccess)
                    return new ObjectResponse<bool>(false, $"No ha sido posible eliminar este canton: {canton.Message}");

                return new ObjectResponse<bool>(true, "Eliminacion exitosa");

            }
            catch (Exception e)
            {
                return new ObjectResponse<bool>(false, $"Eliminacion fallida {e.InnerException}");
            }

        }

    }
}
