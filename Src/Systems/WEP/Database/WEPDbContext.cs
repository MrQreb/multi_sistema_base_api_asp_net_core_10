using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WepAPI.Src.WEP.Modules.Users.Entities;

namespace WepAPI.Src.WEP.Database;

/// <summary>
/// Contexto de base de datos que representa las tablas de la aplicación.
/// </summary>
/// <typeparam name="WEPContext"></typeparam>
public class WEPContext(DbContextOptions<WEPContext> options) : DbContext(options)
{

    /// <summary>
    /// Tabla de usuarios.
    /// </summary>
    public DbSet<User> Users => Set<User>();

    /// <summary>
    /// Configura las entidades y sus relaciones.
    /// </summary>
    /// <param name="modelBuilder">Constructor de modelos de Entity Framework.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {


        modelBuilder.Entity<User>();


        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(modelBuilder);
    }
}