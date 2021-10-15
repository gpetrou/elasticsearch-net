using System;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch
{
	public class StringAliasConverter<T> : JsonConverter<T>
	{
		public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var value = reader.GetString();

			var instance = (T)Activator.CreateInstance(
				typeof(T),
				BindingFlags.Instance | BindingFlags.Public,
				args: new object[] {value},
				binder: null,
				culture: null)!;

			return instance;
		}

		public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
		{
			if (value is null)
			{
				writer.WriteNullValue();
			}
			else
			{
				writer.WriteStringValue(value.ToString());
			}
		}
	}


	public class EnumStructConverter<T> : JsonConverter<T>
	{
		// TODO: Rename if not valid

		public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var value = reader.GetString();

			var instance = (T)Activator.CreateInstance(
				typeof(T),
				BindingFlags.Instance | BindingFlags.NonPublic,
				args: new object[] { value },
				binder: null,
				culture: null)!;

			return instance;
		}

		public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
		{
			var enumValue = value.ToString();

			if (!string.IsNullOrEmpty(enumValue))
				writer.WriteStringValue(value.ToString());
			else
				writer.WriteNullValue();
		}
	}
}