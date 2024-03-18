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
using Elastic.Transport.Products.Elasticsearch;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless;

public sealed partial class ReindexResponse : ElasticsearchResponse
{
	[JsonInclude, JsonPropertyName("batches")]
	public long? Batches { get; init; }
	[JsonInclude, JsonPropertyName("created")]
	public long? Created { get; init; }
	[JsonInclude, JsonPropertyName("deleted")]
	public long? Deleted { get; init; }
	[JsonInclude, JsonPropertyName("failures")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.BulkIndexByScrollFailure>? Failures { get; init; }
	[JsonInclude, JsonPropertyName("noops")]
	public long? Noops { get; init; }
	[JsonInclude, JsonPropertyName("requests_per_second")]
	public float? RequestsPerSecond { get; init; }
	[JsonInclude, JsonPropertyName("retries")]
	public Elastic.Clients.Elasticsearch.Serverless.Retries? Retries { get; init; }
	[JsonInclude, JsonPropertyName("slice_id")]
	public int? SliceId { get; init; }
	[JsonInclude, JsonPropertyName("task")]
	public Elastic.Clients.Elasticsearch.Serverless.TaskId? Task { get; init; }
	[JsonInclude, JsonPropertyName("throttled_millis")]
	public long? ThrottledMillis { get; init; }
	[JsonInclude, JsonPropertyName("throttled_until_millis")]
	public long? ThrottledUntilMillis { get; init; }
	[JsonInclude, JsonPropertyName("timed_out")]
	public bool? TimedOut { get; init; }
	[JsonInclude, JsonPropertyName("took")]
	public long? Took { get; init; }
	[JsonInclude, JsonPropertyName("total")]
	public long? Total { get; init; }
	[JsonInclude, JsonPropertyName("updated")]
	public long? Updated { get; init; }
	[JsonInclude, JsonPropertyName("version_conflicts")]
	public long? VersionConflicts { get; init; }
}