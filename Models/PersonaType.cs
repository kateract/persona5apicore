using System.Text.Json;
using System.Text.Json.Serialization;

namespace Persona5ApiCore.Models;

public class PersonaType : Enumeration
{
  public static readonly PersonaType Upbeat = new(0, 
    nameof(Upbeat), 
    AnswerType.Funny, 
    new() {AnswerType.Serious, AnswerType.Vague});
  public static readonly PersonaType Timid = new(1, 
    nameof(Timid),
    AnswerType.Kind,
    new() {AnswerType.Vague, AnswerType.Funny});
  public static readonly PersonaType Irritable = new(2, 
    nameof(Irritable),
    AnswerType.Serious,
    new() {AnswerType.Vague, AnswerType.Kind});
  public static readonly PersonaType Gloomy = new(3, 
    nameof(Gloomy),
    AnswerType.Vague,
    new() {AnswerType.Serious, AnswerType.Funny});
  public PersonaType(): base(0, "") {}
  public PersonaType (int id, string name, AnswerType like, List<AnswerType> dislike) : base(id, name) {
    Like = like;
    Dislike = dislike;
  }
  public AnswerType Like {get; init;} = AnswerType.Funny;
  public List<AnswerType> Dislike { get; init; } = new();
}

public class PersonaTypeJsonConverter : JsonConverter<PersonaType>
{
  public override PersonaType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    var value = reader.GetString();
    Console.WriteLine(value);
    var personaTypes =  Enumeration.GetAll<PersonaType>().ToList();
    Console.WriteLine(personaTypes.Count());
    Console.WriteLine(string.Join(", ", personaTypes.Select(p => p.Name)));
    var personaType = personaTypes.FirstOrDefault(p => p.Name == value);
    Console.WriteLine(personaType?.Name);
    return personaType;
  }

  public override void Write(Utf8JsonWriter writer, PersonaType value, JsonSerializerOptions options)
  {
    writer.WriteStringValue( value.Name);
  }
}