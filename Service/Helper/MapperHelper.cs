using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Service.Helper
{
    public static class MapperHelper
    {
        private static Dictionary<Type, Dictionary<string, PropertyInfo>> _cachePropriedades;

        public static T Mapper<T>(object payload) where T : new()
        {
            if (payload == null) return default(T);

            var tipo = typeof(T);

            // Cache das propriedades para performance
            if (!_cachePropriedades.ContainsKey(tipo))
            {
                _cachePropriedades[tipo] = tipo.GetProperties()
                    .Where(p => p.CanWrite)
                    .ToDictionary(p => p.Name.ToLowerInvariant(), p => p);
            }

            var propriedades = _cachePropriedades[tipo];
            var obj = new T();

            // Mapear de Dictionary
            if (payload is Dictionary<string, object> dict)
            {
                foreach (var kvp in dict)
                {
                    var nomePropriedade = kvp.Key.ToLowerInvariant();

                    if (propriedades.ContainsKey(nomePropriedade))
                    {
                        var propriedade = propriedades[nomePropriedade];
                        DefinirValorPropriedade(obj, propriedade, kvp.Value);
                    }
                }
            }
            // Mapear de objeto anônimo ou outro objeto
            else
            {
                var propriedadesPayload = payload.GetType().GetProperties();

                foreach (var propPayload in propriedadesPayload)
                {
                    var nomePropriedade = propPayload.Name.ToLowerInvariant();

                    if (propriedades.ContainsKey(nomePropriedade))
                    {
                        var propriedadeDestino = propriedades[nomePropriedade];
                        var valor = propPayload.GetValue(payload);
                        DefinirValorPropriedade(obj, propriedadeDestino, valor);
                    }
                }
            }

            return obj;
        }

        private static void DefinirValorPropriedade(object obj, PropertyInfo propriedade, dynamic valor)
        {
            if (valor == null) return;

            try
            {
                var tipoDestino = Nullable.GetUnderlyingType(propriedade.PropertyType) ?? propriedade.PropertyType;

                if (tipoDestino == typeof(string))
                {
                    propriedade.SetValue(obj, valor.ToString());
                }
                else if (tipoDestino.IsEnum)
                {
                    var valorEnum = Enum.Parse(tipoDestino, valor.ToString());
                    propriedade.SetValue(obj, valorEnum);
                }
                else if (tipoDestino == typeof(DateTime))
                {
                    if (DateTime.TryParse(valor.ToString(), out DateTime dataConvertida))
                    {
                        propriedade.SetValue(obj, dataConvertida);
                    }
                }
                else if (tipoDestino == typeof(Guid))
                {
                    if (Guid.TryParse(valor.ToString() , out Guid guidConvertido))
                    {
                        propriedade.SetValue(obj, guidConvertido);
                    }
                }
                else if (tipoDestino == typeof(bool))
                {
                    if (bool.TryParse(valor.ToString(), out bool boolConvertido))
                    {
                        propriedade.SetValue(obj, boolConvertido);
                    }
                }
                else if (tipoDestino == typeof(int) || tipoDestino == typeof(long) || tipoDestino == typeof(double) || tipoDestino == typeof(decimal))
                {
                    var valorNumerico = Convert.ToDecimal(valor);
                    propriedade.SetValue(obj, Convert.ChangeType(valorNumerico, tipoDestino));
                }
                else if (tipoDestino.BaseType == typeof(Object) || tipoDestino == typeof(object[]))
                {
                    // Se for um objeto genérico ou array de objetos, converte para string
                    if (valor.Data is IEnumerable<object> lista)
                    {
                        var value = valor.Data.FirstOrDefault();

                        var listaConvertida = lista.Select(x => x.ToString()).ToList();
                        var t = Type.GetType($"Service.Models.{tipoDestino.Name}");
                       // JsonConvert.DeserializeObject<t>(json, settings);

                        propriedade.SetValue(obj, listaConvertida);
                    }
                    else
                    {
                        propriedade.SetValue(obj, valor.ToString());
                    }
                }        
                else
                {
                    var valorConvertido = Convert.ChangeType(valor, tipoDestino);
                    propriedade.SetValue(obj, valorConvertido);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao definir valor para {propriedade.Name}: {ex.Message}");
            }
        }
    }

}


