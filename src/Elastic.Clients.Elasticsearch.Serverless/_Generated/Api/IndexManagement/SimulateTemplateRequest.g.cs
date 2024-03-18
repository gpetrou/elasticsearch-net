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
using Elastic.Clients.Elasticsearch.Serverless.Requests;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.IndexManagement;

public sealed class SimulateTemplateRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>If true, the template passed in the body is only used if no existing templates match the same index patterns. If false, the simulation uses the template with the highest priority. Note that the template is not permanently added or updated in either case; it is only used for the simulation.</para>
	/// </summary>
	public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }

	/// <summary>
	/// <para>If true, returns all relevant default configurations for the index template.</para>
	/// </summary>
	public bool? IncludeDefaults { get => Q<bool?>("include_defaults"); set => Q("include_defaults", value); }

	/// <summary>
	/// <para>Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("master_timeout"); set => Q("master_timeout", value); }
}

/// <summary>
/// <para>Returns the index configuration that would be applied by a particular index template.</para>
/// </summary>
public sealed partial class SimulateTemplateRequest : PlainRequest<SimulateTemplateRequestParameters>
{
	public SimulateTemplateRequest()
	{
	}

	public SimulateTemplateRequest(Elastic.Clients.Elasticsearch.Serverless.Name? name) : base(r => r.Optional("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementSimulateTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.simulate_template";

	/// <summary>
	/// <para>If true, the template passed in the body is only used if no existing templates match the same index patterns. If false, the simulation uses the template with the highest priority. Note that the template is not permanently added or updated in either case; it is only used for the simulation.</para>
	/// </summary>
	[JsonIgnore]
	public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }

	/// <summary>
	/// <para>If true, returns all relevant default configurations for the index template.</para>
	/// </summary>
	[JsonIgnore]
	public bool? IncludeDefaults { get => Q<bool?>("include_defaults"); set => Q("include_defaults", value); }

	/// <summary>
	/// <para>Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("master_timeout"); set => Q("master_timeout", value); }
}

/// <summary>
/// <para>Returns the index configuration that would be applied by a particular index template.</para>
/// </summary>
public sealed partial class SimulateTemplateRequestDescriptor : RequestDescriptor<SimulateTemplateRequestDescriptor, SimulateTemplateRequestParameters>
{
	internal SimulateTemplateRequestDescriptor(Action<SimulateTemplateRequestDescriptor> configure) => configure.Invoke(this);

	public SimulateTemplateRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementSimulateTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.simulate_template";

	public SimulateTemplateRequestDescriptor Create(bool? create = true) => Qs("create", create);
	public SimulateTemplateRequestDescriptor IncludeDefaults(bool? includeDefaults = true) => Qs("include_defaults", includeDefaults);
	public SimulateTemplateRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Serverless.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);

	public SimulateTemplateRequestDescriptor Name(Elastic.Clients.Elasticsearch.Serverless.Name? name)
	{
		RouteValues.Optional("name", name);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}