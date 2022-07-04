namespace Persona5ApiCore.Models;

public class Answer
{
  public int Id { get; set; }
  public string Text { get; set; } = "";
  public AnswerType Types { get; set; } = AnswerType.Funny;
  public int QuestionId { get; set; }

  public Question Question {get;set;} = null!;
}
