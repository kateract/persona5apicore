

namespace Persona5ApiCore.Models;

public class Effectiveness : Enumeration {
  public static Effectiveness Normal => new(0, nameof(Normal));
  public static Effectiveness Strong => new(1, nameof(Strong));
  public static Effectiveness Weak => new(2, nameof(Weak));
  public static Effectiveness Null => new(3, nameof(Null));
  public static Effectiveness Drain => new(4, nameof(Drain));
  public Effectiveness (int id, string name) : base(id, name) {}
}
