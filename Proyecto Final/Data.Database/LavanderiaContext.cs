using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Business.Entities;

namespace Data.Database
{
    public class LavanderiaContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
               .HasOne(u => u.Empleado)
               .WithMany(e => e.Usuarios)
               .HasForeignKey(u => u.IdEmpleado)
               .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TipoPrenda>()
                .ToTable("tipo_prendas");

            modelBuilder.Entity<InsumoProveedor>()
                .ToTable("insumos_proveedores");

            modelBuilder.Entity<ServicioTipoPrenda>()
                .ToTable("servicios_tipoprendas");

            modelBuilder.Entity<OrdenServicioTipoPrenda>()
                .ToTable("ordenes_servicios_tipoprendas");

            modelBuilder.Entity<InsumoServicioTipoPrenda>()
                .ToTable("insumos_servicios_tipoprendas");

            modelBuilder.Entity<AtributosNegocio>()
                .ToTable("atributos_negocio");

            modelBuilder.Entity<Mantenimiento>()
                .ToTable("mantenimientos");

            modelBuilder.Entity<Insumo>()
                .ToTable("insumos");

            modelBuilder.Entity<Gasto>()
                .ToTable("gastos");

            modelBuilder.Entity<TiposMaquina>()
                .ToTable("tipos_maquina");

            modelBuilder.Entity<Consumo>()
                .ToTable("consumos");

            modelBuilder.Entity<InsumoProveedor>()
                .HasOne(ip => ip.Proveedor)
                .WithMany(p => p.InsumosProveedor)
                .HasForeignKey(ip => ip.IdProveedor)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Consumo>()
                .HasOne(ip => ip.Insumo)
                .WithMany(p => p.Consumos)
                .HasForeignKey(ip => ip.IdInsumo)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Maquina>()
                .HasOne(ip => ip.TipoMaquina)
                .WithMany(p => p.Maquinas)
                .HasForeignKey(ip => ip.IdTipoMaquina)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<InsumoProveedor>()
                .HasOne(ip => ip.Insumo)
                .WithMany(i => i.InsumosProveedores)
                .HasForeignKey(ip => ip.IdInsumo)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<InsumoProveedor>()
                .HasKey(ip => new { ip.IdProveedor, ip.IdInsumo, ip.FechaIngreso });

            modelBuilder.Entity<InsumoServicioTipoPrenda>()
                .HasOne(istp => istp.Insumo)
                .WithMany(i => i.InsumoServicioTipoPrenda)
                .HasForeignKey(istp => istp.IdInsumo)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<InsumoServicioTipoPrenda>()
                .HasOne(istp => istp.ServicioTipoPrenda)
                .WithMany(stp => stp.InsumoServicioTipoPrenda)
                .HasForeignKey(istp => new { istp.IdServicio, istp.IdTipoPrenda })
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<InsumoServicioTipoPrenda>()
                .HasOne(istp => istp.TipoMaquina)
                .WithMany(stp => stp.InsumosServicioTipoPrendaTiposMaquina)
                .HasForeignKey(istp => istp.IdTipoMaquina)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<InsumoServicioTipoPrenda>()
                .HasKey(istp => new { istp.IdInsumo, istp.IdServicio, istp.IdTipoPrenda,istp.FechaDesde});

            modelBuilder.Entity<Mantenimiento>()
                .HasOne(m => m.Maquina)
                .WithMany(ma => ma.Mantenimientos)
                .HasForeignKey(m => m.IdMaquina)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Mantenimiento>()
                .HasKey(m => new { m.IdMaquina, m.FechaRealizado });

            

            modelBuilder.Entity<MaquinaOrdenServicioTipoPrenda>()
                .HasOne(m => m.Maquina)
                .WithMany(ma => ma.itemsAtendidos)
                .HasForeignKey(m => m.IdMaquina)
                .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<MaquinaOrdenServicioTipoPrenda>()
                .HasMany(m => m.Consumos)
                .WithOne(ma => ma.MaquinaOrdenServicioTipoPrenda)
                .HasForeignKey(m => new { m.IdMaquina, m.FechaConsumo})
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Consumo>()
                .HasKey(m => new { m.IdMaquina, m.FechaConsumo, m.IdInsumo });


            modelBuilder.Entity<MaquinaOrdenServicioTipoPrenda>()
                .HasOne(m => m.OrdenServicioTipoPrenda)
                .WithMany(ostp => ostp.MaquinaOrdenServicioTipoPrenda)
                .HasForeignKey(m => new {m.NroOrden,m.IdServicio,m.IdTipoPrenda,m.OrdenItem})
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<MaquinaOrdenServicioTipoPrenda>()
                .HasOne(m => m.Empleado)
                .WithMany(e => e.OrdenesAtendidas)
                .HasForeignKey(m => m.IdEmpleado)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<MaquinaOrdenServicioTipoPrenda>()
                .HasKey(m => new { m.IdMaquina, m.TiempoInicioServicio });

            modelBuilder.Entity<MaquinaOrdenServicioTipoPrenda>()
                .ToTable("maquinas_ordenes_servicios_tipoprendas");

            modelBuilder.Entity<Orden>()
                .HasOne(m => m.Cliente)
                .WithMany(c => c.Ordenes)
                .HasForeignKey( m => m.IdCliente)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Orden>()
                .HasOne(m => m.Empleado)
                .WithMany(e => e.OrdenesRegistradas)
                .HasForeignKey(m => m.IdEmpleado)
                .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<Orden>()
                .HasOne(m => m.Factura)
                .WithMany()
                .HasForeignKey(m => m.NroFactura)
                .OnDelete(DeleteBehavior.Cascade);
           
            modelBuilder.Entity<OrdenServicioTipoPrenda>()
                .HasOne(m => m.Orden)
                .WithMany(o => o.ItemsPedidos)
                .HasForeignKey(m => m.NroOrden)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<OrdenServicioTipoPrenda>()
                .HasOne(m => m.ServicioTipoPrenda)
                .WithMany(stp => stp.ItemsPedidos)
                .HasForeignKey(m => new { m.IdServicio, m.IdTipoPrenda})
                .OnDelete(DeleteBehavior.NoAction);
           
            modelBuilder.Entity<OrdenServicioTipoPrenda>()
                .HasKey(m => new { m.NroOrden, m.IdServicio, m.IdTipoPrenda, m.OrdenItem });

            modelBuilder.Entity<Pago>()
                .HasOne(m => m.Factura)
                .WithMany(f => f.Pagos)
                .HasForeignKey(m => m.NroFactura)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Pago>()
                .HasKey(m => new { m.NroFactura, m.FechaPago });

            modelBuilder.Entity<Precio>()
                .HasOne(m => m.ServicioTipoPrenda)
                .WithMany(stp => stp.HistoricoPrecios)
                .HasForeignKey( m => new {m.IdServicio,m.IdTipoPrenda})
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Precio>()
                .HasKey(m => new { m.IdServicio, m.IdTipoPrenda, m.FechaDesde });

            modelBuilder.Entity<ServicioTipoPrenda>()
                .HasOne(m => m.Servicio)
                .WithMany(s => s.ServicioTipoPrenda)
                .HasForeignKey(m => m.IdServicio)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ServicioTipoPrenda>()
                .HasOne(m => m.TipoPrenda)
                .WithMany(tp => tp.ServicioTipoPrenda)
                .HasForeignKey( m=> m.IdTipoPrenda)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ServicioTipoPrenda>()
                .HasKey(m => new { m.IdServicio, m.IdTipoPrenda });
        }

        public override int SaveChanges()
        {
            foreach (var item in ChangeTracker.Entries().Where(e => e.State == EntityState.Deleted && e.Metadata.GetProperties().Any(x => x.Name == "Borrado")))
            {
                item.State = EntityState.Unchanged;
                item.CurrentValues["Borrado"] = true;      
            }
            return base.SaveChanges();
        }

        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<TipoPrenda>? TipoPrendas { get; set; }
        public DbSet<Empleado>? Empleados { get; set; }
        public DbSet<Factura>? Facturas { get; set; }
        public DbSet<Insumo>? Insumos { get; set; }
        public DbSet<InsumoProveedor>? InsumosProveedores { get; set; }
        public DbSet<InsumoServicioTipoPrenda>? InsumosServiciosTipoPrendas { get; set; }
        public DbSet<Mantenimiento>? Mantenimientos { get; set; }
        public DbSet<Maquina>? Maquinas { get; set; }
        public DbSet<MaquinaOrdenServicioTipoPrenda>? MaquinasOrdenesServiciosTipoPrendas { get; set; }
        public DbSet<Orden>? Ordenes { get; set; }
        public DbSet<OrdenServicioTipoPrenda>? OrdenesServiciosTipoPrendas { get; set; }
        public DbSet<Pago>? Pagos { get; set; }
        public DbSet<Precio>? Precios { get; set; }
        public DbSet<Proveedor>? Proveedores { get; set; }
        public DbSet<Servicio>? Servicios { get; set; }
        public DbSet<ServicioTipoPrenda>? ServiciosTipoPrendas { get; set; }
        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<AtributosNegocio> AtributosNegocio { get; set; }
        public DbSet<Gasto>? Gastos { get; set; }
        public DbSet<TiposMaquina>? TiposMaquinas { get; set; }
        public DbSet<Consumo>? Consumos { get; set; }
        public LavanderiaContext() {}
        public LavanderiaContext(DbContextOptions<LavanderiaContext> options) : base(options) {}
    }
}
