using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
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
               .WithMany()
               .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Consumo>()
                .HasOne(c => c.Insumo)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<Consumo>()
                .HasOne(c => c.Servicio)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Consumo>()
                .HasOne(c => c.TipoPrenda)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Consumo>()
                .HasKey(c => new { c.IdInsumo, c.IdServicio,c.IdTipoPrenda,c.FechaDesde});

            modelBuilder.Entity<InsumoProveedor>()
                .HasOne(ip => ip.Proveedor)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<InsumoProveedor>()
                .HasOne(ip => ip.Insumo)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<InsumoProveedor>()
                .HasKey(ip => new { ip.IdInsumo, ip.CuitProveedor, ip.FechaIngreso });

            modelBuilder.Entity<InsumoServicioTipoPrenda>()
                .HasOne(istp => istp.Insumo)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<InsumoServicioTipoPrenda>()
                .HasOne(istp => istp.Servicio)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<InsumoServicioTipoPrenda>()
                .HasOne(istp => istp.TipoPrenda)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<InsumoServicioTipoPrenda>()
                .HasKey(istp => new { istp.IdInsumo, istp.IdServicio, istp.IdTipoPrenda });

            modelBuilder.Entity<Mantenimiento>()
                .HasOne(m => m.Maquina)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Mantenimiento>()
                .HasKey(m => new { m.IdMaquina, m.FechaRealizado });

            modelBuilder.Entity<MaquinaOrdenServicioTipoPrenda>()
                .HasOne(m => m.Maquina)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<MaquinaOrdenServicioTipoPrenda>()
                .HasOne(m => m.Orden)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<MaquinaOrdenServicioTipoPrenda>()
                .HasOne(m => m.Servicio)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<MaquinaOrdenServicioTipoPrenda>()
                .HasOne(m => m.TipoPrenda)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<MaquinaOrdenServicioTipoPrenda>()
                .HasKey(m => new { m.IdMaquina, m.FechaHoraServicio });

            modelBuilder.Entity<Orden>()
                .HasOne(m => m.Cliente)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Orden>()
                .HasOne(m => m.Empleado)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Orden>()
                .HasOne(m => m.Factura)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Orden>()
                .HasOne(m => m.EmpleadoAtencion)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<OrdenServicioTipoPrenda>()
                .HasOne(m => m.Orden)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<OrdenServicioTipoPrenda>()
                .HasOne(m => m.Servicio)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<OrdenServicioTipoPrenda>()
                .HasOne(m => m.TipoPrenda)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<OrdenServicioTipoPrenda>()
                .HasKey(m => new { m.NroOrden, m.IdServicio, m.IdTipoPrenda, m.OrdenItem });

            modelBuilder.Entity<Pago>()
                .HasOne(m => m.Factura)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Pago>()
                .HasKey(m => new { m.NroFactura, m.FechaPago });

            modelBuilder.Entity<Precio>()
                .HasOne(m => m.Servicio)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Precio>()
                .HasOne(m => m.TipoPrenda)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Precio>()
                .HasKey(m => new { m.IdServicio, m.IdTipoPrenda, m.FechaDesde });

            modelBuilder.Entity<ServicioTipoPrenda>()
                .HasOne(m => m.Servicio)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ServicioTipoPrenda>()
                .HasOne(m => m.TipoPrenda)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<ServicioTipoPrenda>()
                .HasKey(m => new { m.IdServicio, m.IdTipoPrenda });
        }
        public DbSet<Consumo>? Consumos { get; set; }
        public DbSet<InsumoProveedor>? InsumosProveedores { get; set; }
        public DbSet<InsumoServicioTipoPrenda>? InsumosServiciosTipoPrendas { get; set; }
        public DbSet<Mantenimiento>? Mantenimientos { get; set; }
        public DbSet<MaquinaOrdenServicioTipoPrenda>? MaquinasOrdenesServiciosTipoPrendas { get; set; }
        public DbSet<Orden>? Ordenes { get; set; }
        public DbSet<OrdenServicioTipoPrenda>? OrdenesServiciosTipoPrendas { get; set; }
        public DbSet<Pago>? Pagos { get; set; }
        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Precio>? Precios { get; set; }
        public DbSet<ServicioTipoPrenda>? ServiciosTipoPrendas { get; set; }
        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<Empleado>? Empleados { get; set; }
        public LavanderiaContext() {}
        public LavanderiaContext(DbContextOptions<LavanderiaContext> options) : base(options) {}
    }
}
