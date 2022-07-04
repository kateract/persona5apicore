using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using Persona5ApiCore.Models;

namespace Persona5ApiCore.Context;

public class PersonaContext : DbContext
{
  public PersonaContext(DbContextOptions options) : base(options)
  {

  }

  public DbSet<Persona> Personas { get; set; } = null!;
  public DbSet<Question> Questions { get; set; } = null!;
  public DbSet<Answer> Answers { get; set; } = null!;
  public DbSet<DamageEffectiveness> DamageEffectivenesses { get; set; } = null!;

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Persona>()
      .HasOne<DamageEffectiveness>(d => d.DamageEffectiveness)
      .WithOne(d => d.Persona)
      .HasForeignKey<DamageEffectiveness>(d => d.PersonaId)
      .OnDelete(DeleteBehavior.Cascade);

    modelBuilder.Entity<Question>()
      .HasMany<Answer>(q => q.Answers)
      .WithOne(a => a.Question)
      .HasForeignKey(a => a.QuestionId)
      .OnDelete(DeleteBehavior.Cascade);

    base.OnModelCreating(modelBuilder);
  }
}
