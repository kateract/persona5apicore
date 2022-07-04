

namespace Persona5ApiCore.Models;

public class PersonaType : Enumeration
{
  public static PersonaType Upbeat => new(0, 
    nameof(Upbeat), 
    AnswerType.Funny, 
    new[] {AnswerType.Serious, AnswerType.Vague});
  public static PersonaType Timid => new(1, 
    nameof(Timid),
    AnswerType.Kind,
    new[] {AnswerType.Vague, AnswerType.Funny});
  public static PersonaType Irritable => new(2, 
    nameof(Irritable),
    AnswerType.Serious,
    new[] {AnswerType.Vague, AnswerType.Kind});
  public static PersonaType Gloomy => new(3, 
    nameof(Gloomy),
    AnswerType.Vague,
    new[] {AnswerType.Serious, AnswerType.Funny});
  public PersonaType(): base(0, "") {}
  public PersonaType (int id, string name, AnswerType like, AnswerType[] dislike) : base(id, name) {
    Like = like;
    Dislike = dislike;
  }
  public AnswerType Like {get; init;} = AnswerType.Funny;
  public AnswerType[] Dislike { get; init; } = new AnswerType[2];
}
