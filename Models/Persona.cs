namespace Persona5ApiCore.Models;

public class Persona { 
  public int Id { get; set; }
  public string Name { get; set; } = "";
  public string CodeName { get; set; } = "";
  public PersonaType Type { get; set; } = PersonaType.Gloomy;
  public Arcana Arcana { get; set; } = Arcana.Fool;
  public DamageEffectiveness DamageEffectiveness {get;set;} = null!;
}
