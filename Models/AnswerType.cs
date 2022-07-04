namespace Persona5ApiCore.Models;

public class AnswerType : Enumeration {
  public static AnswerType Funny => new(0, nameof(Funny));
  public static AnswerType Kind => new(1, nameof(Kind));
  public static AnswerType Serious => new(2, nameof(Serious));
  public static AnswerType Vague => new(3, nameof(Vague));
  public AnswerType(int id, string name) : base(id, name) {

  }
}