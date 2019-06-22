﻿using PatronRepositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.DAL
{
    public class Contexto: DbContext
    {
        public DbSet<Personas> Persona { get; set; }
        public DbSet<TiposPersonas> TiposPersona { get; set; }
        public DbSet<Cargos> Cargo { get; set; }
        public DbSet<Proveedores> Proveedor { get; set; }
        public DbSet<Clientes> Cliente { get; set; }
        public DbSet<Empleados> Empleado { get; set; }
        public DbSet<Estados> Estado { get; set; }
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Compras> Compra { get; set; }
        public DbSet<DetalleCompras> DetalleCompra { get; set; }
        public DbSet<Modelos> Modelo { get; set; }
        public DbSet<Permisos> Permiso { get; set; }
        public DbSet<Productos> Producto { get; set; }
        public DbSet<Categorias> Categoria { get; set; }
        public DbSet<Marcas> Marca { get; set; }
        public DbSet<Imagenes> Imagen { get; set; }
        public DbSet<TiposComprobantes> TiposComprobante { get; set; }
        public DbSet<UnidadesMedidas> UnidadesMedida { get; set; }
        public DbSet<UsuarioHasPermisos> UsuarioHasPermiso { get; set; }
        public DbSet<Ventas> Venta { get; set; }
        public DbSet<DetalleVentas> DetalleVenta { get; set; }

        public Contexto() : base("Constr")
        {

        }
    }
}
