namespace Persona5ApiCore.Models;

public class Arcana : Enumeration {
  public static readonly Arcana Fool = new(0, nameof(Fool));
  public static readonly Arcana Magician = new(1, nameof(Magician));
  public static readonly Arcana Priestess = new(2, nameof(Priestess));
  public static readonly Arcana Empress = new(3, nameof(Empress));
  public static readonly Arcana Emperor = new(4, nameof(Emperor));
  public static readonly Arcana Hierophant = new(5, nameof(Hierophant));
  public static readonly Arcana Lovers = new(6, nameof(Lovers));
  public static readonly Arcana Chariot = new(7, nameof(Chariot));
  public static readonly Arcana Justice = new(8, nameof(Justice));
  public static readonly Arcana Hermit = new(9, nameof(Hermit));
  public static readonly Arcana Fortune = new(10, nameof(Fortune));
  public static readonly Arcana Strength = new(11, nameof(Strength));
  public static readonly Arcana Hanged = new(12, nameof(Hanged));
  public static readonly Arcana Death = new(13, nameof(Death));
  public static readonly Arcana Temperance = new(14, nameof(Temperance));
  public static readonly Arcana Devil = new(15, nameof(Devil));
  public static readonly Arcana Tower = new(16, nameof(Tower));
  public static readonly Arcana Star = new(17, nameof(Star));
  public static readonly Arcana Moon = new(18, nameof(Moon));
  public static readonly Arcana Sun = new(19, nameof(Sun));
  public static readonly Arcana Judgement = new(20, nameof(Judgement));
  public Arcana(int id, string name) : base(id, name) {

  }
}
