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
    public class ComprasRepositorio : RepositorioBase<Compras>
    {
        public override bool Modificar(Compras entity)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            RepositorioBase<DetalleCompras> dbDetalle = new RepositorioBase<DetalleCompras>();

            try
            {
                List<DetalleCompras> anterior = new List<DetalleCompras>();
                anterior = dbDetalle.GetList(C => C.IdCompra == entity.IdCompra);
                anterior.Count();

                foreach (var item in anterior)
                {
                    if (!entity.Detalles.Any(C => C.IdDetalleCompra == item.IdDetalleCompra))
                    {
                        dbDetalle.Eliminar(item.IdDetalleCompra);
                    }
                }

                foreach (var item in entity.Detalles)
                {

                    if (item.IdDetalleCompra == 0)
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
                dbDetalle.Dispose();
            }

            return paso;
        }
    }
}