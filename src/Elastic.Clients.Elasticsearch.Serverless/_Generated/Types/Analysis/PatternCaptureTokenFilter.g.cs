// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

#nullable restore

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Analysis;

public sealed partial class PatternCaptureTokenFilter : ITokenFilter
{
	[JsonInclude, JsonPropertyName("patterns")]
	public ICollection<string> Patterns { get; set; }
	[JsonInclude, JsonPropertyName("preserve_original")]
	[JsonConverter(typeof(StringifiedBoolConverter))]
	public bool? PreserveOriginal { get; set; }

	[JsonInclude, JsonPropertyName("type")]
	public string Type => "pattern_capture";

	[JsonInclude, JsonPropertyName("version")]
	public string? Version { get; set; }
}

public sealed partial class PatternCaptureTokenFilterDescriptor : SerializableDescriptor<PatternCaptureTokenFilterDescriptor>, IBuildableDescriptor<PatternCaptureTokenFilter>
{
	internal PatternCaptureTokenFilterDescriptor(Action<PatternCaptureTokenFilterDescriptor> configure) => configure.Invoke(this);

	public PatternCaptureTokenFilterDescriptor() : base()
	{
	}

	private ICollection<string> PatternsValue { get; set; }
	private bool? PreserveOriginalValue { get; set; }
	private string? VersionValue { get; set; }

	public PatternCaptureTokenFilterDescriptor Patterns(ICollection<string> patterns)
	{
		PatternsValue = patterns;
		return Self;
	}

	public PatternCaptureTokenFilterDescriptor PreserveOriginal(bool? preserveOriginal = true)
	{
		PreserveOriginalValue = preserveOriginal;
		return Self;
	}

	public PatternCaptureTokenFilterDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("patterns");
		JsonSerializer.Serialize(writer, PatternsValue, options);
		if (PreserveOriginalValue is not null)
		{
			writer.WritePropertyName("preserve_original");
			JsonSerializer.Serialize(writer, PreserveOriginalValue, options);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("pattern_capture");
		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}

	PatternCaptureTokenFilter IBuildableDescriptor<PatternCaptureTokenFilter>.Build() => new()
	{
		Patterns = PatternsValue,
		PreserveOriginal = PreserveOriginalValue,
		Version = VersionValue
	};
}