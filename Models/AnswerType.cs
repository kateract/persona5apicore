namespace Persona5ApiCore.Models;

public class AnswerType : Enumeration {
  public static readonly AnswerType Funny = new(0, nameof(Funny));
  public static readonly AnswerType Kind = new(1, nameof(Kind));
  public static readonly AnswerType Serious = new(2, nameof(Serious));
  public static readonly AnswerType Vague = new(3, nameof(Vague));
  public AnswerType(int id, string name) : base(id, name) {

  }
}