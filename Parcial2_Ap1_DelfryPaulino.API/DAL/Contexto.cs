using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace Parcial2_Ap1_DelfryPaulino.API.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public DbSet<Vehiculos> Vehiculos { get; set; }
    public DbSet<VehiculosDetalle> VehiculosDetalle { get; set; }
    public DbSet<Accesorios> Accesorios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Accesorios>().HasData(new List<Accesorios>() 
        { 
            new() { AccesorioId = 1, Descripción = "Camara Trasera" },
            new() { AccesorioId = 2, Descripción = "Pantalla Interior" },
            new() { AccesorioId = 3, Descripción = "Interior en Piel" },
            new() { AccesorioId = 4, Descripción = "Sun Roof" },
            new() { AccesorioId = 5, Descripción = "Aros de Lujo" }
            
        });
    }
}
