

namespace Persona5ApiCore.Models;

public class DamageEffectiveness {
  public int Id { get; set; }
  public int PersonaId { get; set; }
  public Effectiveness Physical {get;set;} = Effectiveness.Normal;
  public Effectiveness Gun{get;set;} = Effectiveness.Normal;
  public Effectiveness Fire { get; set; } = Effectiveness.Normal;
  public Effectiveness Ice { get; set; } = Effectiveness.Normal;
  public Effectiveness Electric { get; set; } = Effectiveness.Normal;
  public Effectiveness Wind { get; set; } = Effectiveness.Normal;
  public Effectiveness Psychic { get; set; } = Effectiveness.Normal;
  public Effectiveness Nuclear {get;set;} = Effectiveness.Normal;
  public Effectiveness Bless { get; set; } = Effectiveness.Normal;
  public Effectiveness Curse { get; set; } = Effectiveness.Normal;
  public Effectiveness Almighty { get; set; } = Effectiveness.Normal;

  public Persona Persona {get;set;} = null!;
}