using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Persona5ApiCore.Models;

public abstract class Enumeration : IComparable
{
  public class EnumerationJsonConverter<T> : JsonConverter<T> where T : Enumeration
  {
    public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
      var value = reader.GetString();
      return Enumeration.GetAll<T>().FirstOrDefault(p => p.Name == value);
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
      writer.WriteStringValue(value.Name);
    }
  }
  public string Name { get; private set; }
  public int Id { get; private set; }
  protected Enumeration(int id, string name) => (Id, Name) = (id, name);
  public override string ToString() => Name;
  public static IEnumerable<T> GetAll<T>() where T : Enumeration =>
    typeof(T)
    .GetFields(
      BindingFlags.Public |
      BindingFlags.Static |
      BindingFlags.DeclaredOnly)
    .Select(f => f.GetValue(null))
    .Cast<T>();
  public override bool Equals(object? obj)
  {
    if (obj is not Enumeration otherValue)
    {
      return false;
    }

    var typeMatches = GetType().Equals(obj.GetType());
    var valueMatches = Id.Equals(otherValue.Id);

    return typeMatches && valueMatches;
  }
  public override int GetHashCode()
  {
    return base.GetHashCode();
  }
  public int CompareTo(object? obj) => Id.CompareTo(((Enumeration?)obj)?.Id);
  public static T FromString<T>(string value) where T : Enumeration{
    return GetAll<T>().First(t => t.Name == value);
  }
}

