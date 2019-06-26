using PatronRepositorio.DAL;
using PatronRepositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.BLL
{
    public class VentasRespositorio : RepositorioBase<Ventas>
    {
        public override bool Modificar(Ventas entity)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            RepositorioBase<DetalleVentas> Detalle = new RepositorioBase<DetalleVentas>();

            try
            {

                List<DetalleVentas> anterior = new List<DetalleVentas>();
                anterior = Detalle.GetList(C => C.IdVenta == entity.IdVenta);
                anterior.Count();

                foreach (var item in anterior)
                {
                    if (!entity.Detalles.Any(C => C.IdDetalleVenta == item.IdDetalleVenta))
                    {
                        Detalle.Eliminar(item.IdDetalleVenta);
                    }
                }

                foreach (var item in entity.Detalles)
                {
                    if (item.IdDetalleVenta == 0)
                        contexto.Entry(item).State = EntityState.Added;
                    else
                        contexto.Entry(item).State = EntityState.Modified;
                }

                contexto.Entry(entity).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
                Detalle.Dispose();
            }

            return paso;
        }
    }
}
