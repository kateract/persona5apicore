using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persona5ApiCore.Models;

namespace Persona5ApiCore.Context;

public class EnumerationConverter<T> : ValueConverter<T, string> where T : Enumeration
{
  public EnumerationConverter()  : base(
    v => v.Name,
    v => Enumeration.GetAll<T>().First(t => t.Name == v)
  ){}
}