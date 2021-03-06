using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Persona5ApiCore.Models;

public class Persona { 
  public int? Id { get; set; }
  public string Name { get; set; } = "";
  public string CodeName { get; set; } = "";
  [DataType(DataType.Text)]
  [JsonConverter(typeof(PersonaTypeJsonConverter))]
  public PersonaType? Type { get; set; } = PersonaType.Gloomy;
  [DataType(DataType.Text)]
  [JsonConverter(typeof(Arcana.EnumerationJsonConverter<Arcana>))]
  public Arcana? Arcana { get; set; } = Arcana.Fool;
  public DamageEffectiveness? DamageEffectiveness {get;set;} = null!;
}
