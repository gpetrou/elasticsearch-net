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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	public partial class SpanMultiTermQuery : QueryDsl.QueryBase, IQueryContainerVariant, ISpanQueryVariant
	{
		[JsonIgnore]
		string QueryDsl.IQueryContainerVariant.QueryContainerVariantName => "span_multi";
		[JsonIgnore]
		string QueryDsl.ISpanQueryVariant.SpanQueryVariantName => "span_multi";
		[JsonInclude]
		[JsonPropertyName("match")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer Match { get; set; }
	}

	public sealed partial class SpanMultiTermQueryDescriptor<TDocument> : DescriptorBase<SpanMultiTermQueryDescriptor<TDocument>>
	{
		public SpanMultiTermQueryDescriptor()
		{
		}

		internal SpanMultiTermQueryDescriptor(Action<SpanMultiTermQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer MatchValue { get; private set; }

		internal float? BoostValue { get; private set; }

		internal string? QueryNameValue { get; private set; }

		internal QueryContainerDescriptor<TDocument> MatchDescriptor { get; private set; }

		internal Action<QueryContainerDescriptor<TDocument>> MatchDescriptorAction { get; private set; }

		public SpanMultiTermQueryDescriptor<TDocument> Match(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer match)
		{
			MatchDescriptor = null;
			MatchDescriptorAction = null;
			return Assign(match, (a, v) => a.MatchValue = v);
		}

		public SpanMultiTermQueryDescriptor<TDocument> Match(QueryDsl.QueryContainerDescriptor<TDocument> descriptor)
		{
			MatchValue = null;
			MatchDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.MatchDescriptor = v);
		}

		public SpanMultiTermQueryDescriptor<TDocument> Match(Action<QueryDsl.QueryContainerDescriptor<TDocument>> configure)
		{
			MatchValue = null;
			MatchDescriptorAction = null;
			return Assign(configure, (a, v) => a.MatchDescriptorAction = v);
		}

		public SpanMultiTermQueryDescriptor<TDocument> Boost(float? boost) => Assign(boost, (a, v) => a.BoostValue = v);
		public SpanMultiTermQueryDescriptor<TDocument> QueryName(string? queryName) => Assign(queryName, (a, v) => a.QueryNameValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (MatchDescriptor is not null)
			{
				writer.WritePropertyName("match");
				JsonSerializer.Serialize(writer, MatchDescriptor, options);
			}
			else if (MatchDescriptorAction is not null)
			{
				writer.WritePropertyName("match");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<TDocument>(MatchDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("match");
				JsonSerializer.Serialize(writer, MatchValue, options);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			writer.WriteEndObject();
		}
	}
}