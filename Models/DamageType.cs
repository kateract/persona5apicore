

namespace Persona5ApiCore.Models;

public class DamageType : Enumeration {
  public static DamageType Physical => new(0, nameof(Physical));
  public static DamageType Gun => new(1, nameof(Gun));
  public static DamageType Fire => new(2, nameof(Fire));
  public static DamageType Ice => new(3, nameof(Ice));
  public static DamageType Electric => new(4, nameof(Electric));
  public static DamageType Wind => new(5, nameof(Wind));
  public static DamageType Psychic => new(6, nameof(Psychic));
  public static DamageType Nuclear => new(7, nameof(Nuclear));
  public static DamageType Bless => new(8, nameof(Bless));
  public static DamageType Curse => new(9, nameof(Curse));
  public static DamageType Almighty => new(10, nameof(Almighty));
  public DamageType (int id, string name) : base(id, name) {}
}
