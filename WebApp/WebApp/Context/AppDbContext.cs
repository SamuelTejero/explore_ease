using Microsoft.EntityFrameworkCore;
using WebApp.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApp.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        public DbSet<Usuarios> Usiarios { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Encuesta> Encuesta { get; set; }
        public DbSet<Actividades> Actividades { get; set; }
        public DbSet<Itinerarios> Itinerarios { get; set;  }
        public DbSet<Notificaciones> Notificaciones { get; set; }
        public DbSet<Retroalimentacion> Retroalimentacions { get; set; }
        public DbSet<Auditorias> Auditorias { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        EntityConfiguration(modelBuilder);
    }

    private void EntityConfiguration(ModelBuilder modelBuilder)
    {
            // Tabla Auditorias
            modelBuilder.Entity<Auditorias>().ToTable("Auditorias");
            modelBuilder.Entity<Auditorias>().HasKey(a => a.Id);
            modelBuilder.Entity<Auditorias>().Property(a => a.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            modelBuilder.Entity<Auditorias>().Property(a => a.UsuarioId).HasColumnName("UsuarioId");
            modelBuilder.Entity<Auditorias>().Property(a => a.Accion).HasColumnName("Accion");
            modelBuilder.Entity<Auditorias>().Property(a => a.FechaAccion).HasColumnName("FechaAccion");

            // Tabla Usuarios
            modelBuilder.Entity<Usuarios>().ToTable("Usuarios");
            modelBuilder.Entity<Usuarios>().HasKey(u => u.Id);
            modelBuilder.Entity<Usuarios>().Property(u => u.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            modelBuilder.Entity<Usuarios>().Property(u => u.Nombre).HasColumnName("Nombre");
            modelBuilder.Entity<Usuarios>().Property(u => u.CorreoElectronico).HasColumnName("CorreoElectronico");
            modelBuilder.Entity<Usuarios>().Property(u => u.Contraseña).HasColumnName("Contraseña");
            modelBuilder.Entity<Usuarios>().Property(u => u.FechaRegistro).HasColumnName("FechaRegistro");
            modelBuilder.Entity<Usuarios>().Property(u => u.TipoRegistro).HasColumnName("TipoRegistro");

            // Tabla Perfil
            modelBuilder.Entity<Perfil>().ToTable("Perfil");
            modelBuilder.Entity<Perfil>().HasKey(p => p.Id);
            modelBuilder.Entity<Perfil>().Property(p => p.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            modelBuilder.Entity<Perfil>().Property(p => p.UsuarioId).HasColumnName("UsuarioId");
            modelBuilder.Entity<Perfil>().Property(p => p.Preferencias).HasColumnName("Preferencias");
            modelBuilder.Entity<Perfil>().Property(p => p.Disponibilidad).HasColumnName("Disponibilidad");

            // Tabla Encuesta
            modelBuilder.Entity<Encuesta>().ToTable("Encuesta");
            modelBuilder.Entity<Encuesta>().HasKey(e => e.Id);
            modelBuilder.Entity<Encuesta>().Property(e => e.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            modelBuilder.Entity<Encuesta>().Property(e => e.UsuarioId).HasColumnName("UsuarioId");
            modelBuilder.Entity<Encuesta>().Property(e => e.GustoActividades).HasColumnName("GustoActividades");
            modelBuilder.Entity<Encuesta>().Property(e => e.FrecuenciaActividades).HasColumnName("FrecuenciaActividades");
            modelBuilder.Entity<Encuesta>().Property(e => e.HorariosDisponibles).HasColumnName("HorariosDisponibles");

            // Tabla Actividades
            modelBuilder.Entity<Actividades>().ToTable("Actividades");
            modelBuilder.Entity<Actividades>().HasKey(a => a.Id);
            modelBuilder.Entity<Actividades>().Property(a => a.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            modelBuilder.Entity<Actividades>().Property(a => a.NombreActividad).HasColumnName("NombreActividad");
            modelBuilder.Entity<Actividades>().Property(a => a.Descripcion).HasColumnName("Descripcion");
            modelBuilder.Entity<Actividades>().Property(a => a.Categoria).HasColumnName("Categoria");
            modelBuilder.Entity<Actividades>().Property(a => a.Subcategoria).HasColumnName("Subcategoria");

            // Tabla Itinerarios
            modelBuilder.Entity<Itinerarios>().ToTable("Itinerarios");
            modelBuilder.Entity<Itinerarios>().HasKey(i => i.Id);
            modelBuilder.Entity<Itinerarios>().Property(i => i.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            modelBuilder.Entity<Itinerarios>().Property(i => i.UsuarioId).HasColumnName("UsuarioId");
            modelBuilder.Entity<Itinerarios>().Property(i => i.FechaCreacion).HasColumnName("FechaCreacion");
            modelBuilder.Entity<Itinerarios>().Property(i => i.ContenidoItinerario).HasColumnName("ContenidoItinerario");

            // Tabla Notificaciones
            modelBuilder.Entity<Notificaciones>().ToTable("Notificaciones");
            modelBuilder.Entity<Notificaciones>().HasKey(n => n.Id);
            modelBuilder.Entity<Notificaciones>().Property(n => n.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            modelBuilder.Entity<Notificaciones>().Property(n => n.UsuarioId).HasColumnName("UsuarioId");
            modelBuilder.Entity<Notificaciones>().Property(n => n.TipoNotificacion).HasColumnName("TipoNotificacion");
            modelBuilder.Entity<Notificaciones>().Property(n => n.Mensaje).HasColumnName("Mensaje");
            modelBuilder.Entity<Notificaciones>().Property(n => n.FechaEnvio).HasColumnName("FechaEnvio");

            // Tabla Retroalimentacion
            modelBuilder.Entity<Retroalimentacion>().ToTable("Retroalimentacion");
            modelBuilder.Entity<Retroalimentacion>().HasKey(r => r.Id);
            modelBuilder.Entity<Retroalimentacion>().Property(r => r.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            modelBuilder.Entity<Retroalimentacion>().Property(r => r.UsuarioId).HasColumnName("UsuarioId");
            modelBuilder.Entity<Retroalimentacion>().Property(r => r.ActividadId).HasColumnName("ActividadId");
            modelBuilder.Entity<Retroalimentacion>().Property(r => r.Comentarios).HasColumnName("Comentarios");
            modelBuilder.Entity<Retroalimentacion>().Property(r => r.Calificacion).HasColumnName("Calificacion");
        }
        public async Task<bool> SaveAsync()
        {
            return await SaveChangesAsync() > 0;
        }

    }
}

