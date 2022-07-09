using System.Text.Json;
using System.Text.Json.Serialization;

namespace Persona5ApiCore.Models;

public class Answer
{
  public int? Id { get; set; }
  public string Text { get; set; } = "";

  [JsonConverter(typeof(AnswerTypeListConverter))]
  public List<AnswerType> Types { get; set; } = new ();
  public int QuestionId { get; set; }
  [JsonIgnore]
  public Question? Question {get;set;} = null!;
}

public class AnswerTypeListConverter : JsonConverter<List<AnswerType>>
{
  public override List<AnswerType>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType == JsonTokenType.Null) return null;
    else if (reader.TokenType != JsonTokenType.StartArray) throw new JsonException();
    var list = new List<AnswerType>();
    while(reader.Read()) {
                 if (reader.TokenType == JsonTokenType.EndArray)
                return list;
            else if (reader.TokenType == JsonTokenType.String)
                list.Add(AnswerType.FromString<AnswerType>(reader.GetString()!));
            else
            {
                //reader.Skip();
                throw new JsonException(); // Unexpected token;
            }
    }
    return list;
  }

  public override void Write(Utf8JsonWriter writer, List<AnswerType> value, JsonSerializerOptions options)
  {
    writer.WriteStartArray();
    value.ForEach(v => writer.WriteStringValue(v.Name));
    writer.WriteEndArray();
  }
}