

namespace Persona5ApiCore.Models;

public class Arcana : Enumeration {
  public static Arcana Fool => new(0, nameof(Fool));
  public static Arcana Magician => new(1, nameof(Magician));
  public static Arcana Priestess => new(2, nameof(Priestess));
  public static Arcana Empress => new(3, nameof(Empress));
  public static Arcana Emperor => new(4, nameof(Emperor));
  public static Arcana Hierophant => new(5, nameof(Hierophant));
  public static Arcana Lovers => new(6, nameof(Lovers));
  public static Arcana Chariot => new(7, nameof(Chariot));
  public static Arcana Justice => new(8, nameof(Justice));
  public static Arcana Hermit => new(9, nameof(Hermit));
  public static Arcana Fortune => new(10, nameof(Fortune));
  public static Arcana Strength => new(11, nameof(Strength));
  public static Arcana Hanged => new(12, nameof(Hanged));
  public static Arcana Death => new(13, nameof(Death));
  public static Arcana Temperance => new(14, nameof(Temperance));
  public static Arcana Devil => new(15, nameof(Devil));
  public static Arcana Tower => new(16, nameof(Tower));
  public static Arcana Star => new(17, nameof(Star));
  public static Arcana Moon => new(18, nameof(Moon));
  public static Arcana Sun => new(19, nameof(Sun));
  public static Arcana Judgement => new(20, nameof(Judgement));
  public Arcana(int id, string name) : base(id, name) {

  }
}
