using System.Text.Json.Serialization;

namespace Persona5ApiCore.Models;

public class Answer
{
  public int Id { get; set; }
  public string Text { get; set; } = "";
  [JsonConverter(typeof(AnswerType.EnumerationJsonConverter<AnswerType>))]
  public AnswerType Types { get; set; } = AnswerType.Funny;
  public int QuestionId { get; set; }

  public Question Question {get;set;} = null!;
}
