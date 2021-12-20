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
namespace Elastic.Clients.Elasticsearch.Ingest
{
	public partial class ForeachProcessor : Ingest.ProcessorBase, IProcessorContainerVariant
	{
		[JsonIgnore]
		string Ingest.IProcessorContainerVariant.ProcessorContainerVariantName => "foreach";
		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("ignore_missing")]
		public bool? IgnoreMissing { get; set; }

		[JsonInclude]
		[JsonPropertyName("processor")]
		public Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer Processor { get; set; }
	}

	public sealed partial class ForeachProcessorDescriptor<TDocument> : DescriptorBase<ForeachProcessorDescriptor<TDocument>>
	{
		public ForeachProcessorDescriptor()
		{
		}

		internal ForeachProcessorDescriptor(Action<ForeachProcessorDescriptor<TDocument>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Field FieldValue { get; private set; }

		internal bool? IgnoreMissingValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer ProcessorValue { get; private set; }

		internal string? IfValue { get; private set; }

		internal bool? IgnoreFailureValue { get; private set; }

		internal IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailureValue { get; private set; }

		internal string? TagValue { get; private set; }

		internal ProcessorContainerDescriptor<TDocument> ProcessorDescriptor { get; private set; }

		internal Action<ProcessorContainerDescriptor<TDocument>> ProcessorDescriptorAction { get; private set; }

		public ForeachProcessorDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field) => Assign(field, (a, v) => a.FieldValue = v);
		public ForeachProcessorDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field) => Assign(field, (a, v) => a.FieldValue = v);
		public ForeachProcessorDescriptor<TDocument> IgnoreMissing(bool? ignoreMissing = true) => Assign(ignoreMissing, (a, v) => a.IgnoreMissingValue = v);
		public ForeachProcessorDescriptor<TDocument> Processor(Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer processor)
		{
			ProcessorDescriptor = null;
			ProcessorDescriptorAction = null;
			return Assign(processor, (a, v) => a.ProcessorValue = v);
		}

		public ForeachProcessorDescriptor<TDocument> Processor(Ingest.ProcessorContainerDescriptor<TDocument> descriptor)
		{
			ProcessorValue = null;
			ProcessorDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.ProcessorDescriptor = v);
		}

		public ForeachProcessorDescriptor<TDocument> Processor(Action<Ingest.ProcessorContainerDescriptor<TDocument>> configure)
		{
			ProcessorValue = null;
			ProcessorDescriptorAction = null;
			return Assign(configure, (a, v) => a.ProcessorDescriptorAction = v);
		}

		public ForeachProcessorDescriptor<TDocument> If(string? ifValue) => Assign(ifValue, (a, v) => a.IfValue = v);
		public ForeachProcessorDescriptor<TDocument> IgnoreFailure(bool? ignoreFailure = true) => Assign(ignoreFailure, (a, v) => a.IgnoreFailureValue = v);
		public ForeachProcessorDescriptor<TDocument> OnFailure(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? onFailure) => Assign(onFailure, (a, v) => a.OnFailureValue = v);
		public ForeachProcessorDescriptor<TDocument> Tag(string? tag) => Assign(tag, (a, v) => a.TagValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			if (IgnoreMissingValue.HasValue)
			{
				writer.WritePropertyName("ignore_missing");
				writer.WriteBooleanValue(IgnoreMissingValue.Value);
			}

			if (ProcessorDescriptor is not null)
			{
				writer.WritePropertyName("processor");
				JsonSerializer.Serialize(writer, ProcessorDescriptor, options);
			}
			else if (ProcessorDescriptorAction is not null)
			{
				writer.WritePropertyName("processor");
				JsonSerializer.Serialize(writer, new Ingest.ProcessorContainerDescriptor<TDocument>(ProcessorDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("processor");
				JsonSerializer.Serialize(writer, ProcessorValue, options);
			}

			if (!string.IsNullOrEmpty(IfValue))
			{
				writer.WritePropertyName("if");
				writer.WriteStringValue(IfValue);
			}

			if (IgnoreFailureValue.HasValue)
			{
				writer.WritePropertyName("ignore_failure");
				writer.WriteBooleanValue(IgnoreFailureValue.Value);
			}

			if (OnFailureValue is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, OnFailureValue, options);
			}

			if (!string.IsNullOrEmpty(TagValue))
			{
				writer.WritePropertyName("tag");
				writer.WriteStringValue(TagValue);
			}

			writer.WriteEndObject();
		}
	}
}