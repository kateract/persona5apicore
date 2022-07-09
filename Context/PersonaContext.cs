using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using Persona5ApiCore.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

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

  protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder) {
    configurationBuilder
      .Properties<Effectiveness>()
      .HaveConversion<EnumerationConverter<Effectiveness>>();
    
    configurationBuilder
      .Properties<AnswerType>()
      .HaveConversion<EnumerationConverter<AnswerType>>();
    
    configurationBuilder
      .Properties<Arcana>()
      .HaveConversion<EnumerationConverter<Arcana>>();

    configurationBuilder
      .Properties<DamageType>()
      .HaveConversion<EnumerationConverter<DamageType>>();
    
    configurationBuilder
      .Properties<PersonaType>()
      .HaveConversion<EnumerationConverter<PersonaType>>();
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Persona>(p => {
      p.HasOne<DamageEffectiveness>(d => d.DamageEffectiveness)
      .WithOne(d => d.Persona)
      .HasForeignKey<DamageEffectiveness>(d => d.PersonaId)
      .OnDelete(DeleteBehavior.Cascade);

      p.Property(p => p.Id)
      .ValueGeneratedOnAdd();
      
      p.Property(p => p.Arcana)
      .HasConversion(v => v!.Name, v => Arcana.GetAll<Arcana>().First(a =>a.Name == v));
    });


    modelBuilder.Entity<DamageEffectiveness>(de => {
      de.Property(p => p.Id)
      .ValueGeneratedOnAdd();
    });
      
    modelBuilder.Entity<Question>()
      .HasMany<Answer>(q => q.Answers)
      .WithOne(a => a.Question)
      .HasForeignKey(a => a.QuestionId)
      .OnDelete(DeleteBehavior.Cascade);

    modelBuilder.Entity<Answer>(a  =>  {
      a.Property(a => a.Types)
      .HasConversion(
        v => string.Join("|",v.Select(s => s.Name)), 
        v => v.Split('|', 4, StringSplitOptions.RemoveEmptyEntries).Select(s => AnswerType.FromString<AnswerType>(s)).ToList(),
        new ValueComparer<List<AnswerType>> (
          (c, v) => c.Except(v).Count() == 0, c => c.OrderBy(c => c.Id).Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
          c => c.ToList()
        ) );
    });

    base.OnModelCreating(modelBuilder);
  }
}
