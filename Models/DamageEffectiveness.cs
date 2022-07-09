using System.Text.Json.Serialization;

namespace Persona5ApiCore.Models;

public class DamageEffectiveness {
  public int? Id { get; set; }
  public int PersonaId { get; set; }
  [JsonConverter(typeof(Effectiveness.EnumerationJsonConverter<Effectiveness>))]
  public Effectiveness Physical {get;set;} = Effectiveness.Normal;
  [JsonConverter(typeof(Effectiveness.EnumerationJsonConverter<Effectiveness>))]
  public Effectiveness Gun{get;set;} = Effectiveness.Normal;
  [JsonConverter(typeof(Effectiveness.EnumerationJsonConverter<Effectiveness>))]
  public Effectiveness Fire { get; set; } = Effectiveness.Normal;
  [JsonConverter(typeof(Effectiveness.EnumerationJsonConverter<Effectiveness>))]
  public Effectiveness Ice { get; set; } = Effectiveness.Normal;
  [JsonConverter(typeof(Effectiveness.EnumerationJsonConverter<Effectiveness>))]
  public Effectiveness Electric { get; set; } = Effectiveness.Normal;
  [JsonConverter(typeof(Effectiveness.EnumerationJsonConverter<Effectiveness>))]
  public Effectiveness Wind { get; set; } = Effectiveness.Normal;
  [JsonConverter(typeof(Effectiveness.EnumerationJsonConverter<Effectiveness>))]
  public Effectiveness Psychic { get; set; } = Effectiveness.Normal;
  [JsonConverter(typeof(Effectiveness.EnumerationJsonConverter<Effectiveness>))]
  public Effectiveness Nuclear {get;set;} = Effectiveness.Normal;
  [JsonConverter(typeof(Effectiveness.EnumerationJsonConverter<Effectiveness>))]
  public Effectiveness Bless { get; set; } = Effectiveness.Normal;
  [JsonConverter(typeof(Effectiveness.EnumerationJsonConverter<Effectiveness>))]
  public Effectiveness Curse { get; set; } = Effectiveness.Normal;
  [JsonConverter(typeof(Effectiveness.EnumerationJsonConverter<Effectiveness>))]
  public Effectiveness Almighty { get; set; } = Effectiveness.Normal;
  [JsonIgnore]
  public Persona? Persona {get;set;} = null!;
}