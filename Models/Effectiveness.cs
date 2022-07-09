namespace Persona5ApiCore.Models;

public class Effectiveness : Enumeration {
  public static readonly Effectiveness Normal = new(0, nameof(Normal));
  public static readonly Effectiveness Strong = new(1, nameof(Strong));
  public static readonly Effectiveness Weak = new(2, nameof(Weak));
  public static readonly Effectiveness Null = new(3, nameof(Null));
  public static readonly Effectiveness Drain = new(4, nameof(Drain));
  public Effectiveness (int id, string name) : base(id, name) {}
}
