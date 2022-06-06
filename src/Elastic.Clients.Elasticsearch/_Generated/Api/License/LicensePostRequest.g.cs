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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.License
{
	public sealed class LicensePostRequestParameters : RequestParameters<LicensePostRequestParameters>
	{
		[JsonIgnore]
		public bool? Acknowledge { get => Q<bool?>("acknowledge"); set => Q("acknowledge", value); }
	}

	public partial class LicensePostRequest : PlainRequestBase<LicensePostRequestParameters>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.LicensePost;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public bool? Acknowledge { get => Q<bool?>("acknowledge"); set => Q("acknowledge", value); }

		[JsonInclude]
		[JsonPropertyName("license")]
		public Elastic.Clients.Elasticsearch.License.License? License { get; set; }

		[JsonInclude]
		[JsonPropertyName("licenses")]
		public IEnumerable<Elastic.Clients.Elasticsearch.License.License> Licenses { get; set; }
	}

	public sealed partial class LicensePostRequestDescriptor : RequestDescriptorBase<LicensePostRequestDescriptor, LicensePostRequestParameters>
	{
		internal LicensePostRequestDescriptor(Action<LicensePostRequestDescriptor> configure) => configure.Invoke(this);
		public LicensePostRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.LicensePost;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		public LicensePostRequestDescriptor Acknowledge(bool? acknowledge = true) => Qs("acknowledge", acknowledge);
		private Elastic.Clients.Elasticsearch.License.License? LicenseValue { get; set; }

		private LicenseDescriptor LicenseDescriptor { get; set; }

		private Action<LicenseDescriptor> LicenseDescriptorAction { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.License.License> LicensesValue { get; set; }

		private LicenseDescriptor LicensesDescriptor { get; set; }

		private Action<LicenseDescriptor> LicensesDescriptorAction { get; set; }

		private Action<LicenseDescriptor>[] LicensesDescriptorActions { get; set; }

		public LicensePostRequestDescriptor License(Elastic.Clients.Elasticsearch.License.License? license)
		{
			LicenseDescriptor = null;
			LicenseDescriptorAction = null;
			LicenseValue = license;
			return Self;
		}

		public LicensePostRequestDescriptor License(LicenseDescriptor descriptor)
		{
			LicenseValue = null;
			LicenseDescriptorAction = null;
			LicenseDescriptor = descriptor;
			return Self;
		}

		public LicensePostRequestDescriptor License(Action<LicenseDescriptor> configure)
		{
			LicenseValue = null;
			LicenseDescriptor = null;
			LicenseDescriptorAction = configure;
			return Self;
		}

		public LicensePostRequestDescriptor Licenses(IEnumerable<Elastic.Clients.Elasticsearch.License.License> licenses)
		{
			LicensesDescriptor = null;
			LicensesDescriptorAction = null;
			LicensesDescriptorActions = null;
			LicensesValue = licenses;
			return Self;
		}

		public LicensePostRequestDescriptor Licenses(LicenseDescriptor descriptor)
		{
			LicensesValue = null;
			LicensesDescriptorAction = null;
			LicensesDescriptorActions = null;
			LicensesDescriptor = descriptor;
			return Self;
		}

		public LicensePostRequestDescriptor Licenses(Action<LicenseDescriptor> configure)
		{
			LicensesValue = null;
			LicensesDescriptor = null;
			LicensesDescriptorActions = null;
			LicensesDescriptorAction = configure;
			return Self;
		}

		public LicensePostRequestDescriptor Licenses(params Action<LicenseDescriptor>[] configure)
		{
			LicensesValue = null;
			LicensesDescriptor = null;
			LicensesDescriptorAction = null;
			LicensesDescriptorActions = configure;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (LicenseDescriptor is not null)
			{
				writer.WritePropertyName("license");
				JsonSerializer.Serialize(writer, LicenseDescriptor, options);
			}
			else if (LicenseDescriptorAction is not null)
			{
				writer.WritePropertyName("license");
				JsonSerializer.Serialize(writer, new LicenseDescriptor(LicenseDescriptorAction), options);
			}
			else if (LicenseValue is not null)
			{
				writer.WritePropertyName("license");
				JsonSerializer.Serialize(writer, LicenseValue, options);
			}

			if (LicensesDescriptor is not null)
			{
				writer.WritePropertyName("licenses");
				JsonSerializer.Serialize(writer, LicensesDescriptor, options);
			}
			else if (LicensesDescriptorAction is not null)
			{
				writer.WritePropertyName("licenses");
				JsonSerializer.Serialize(writer, new LicenseDescriptor(LicensesDescriptorAction), options);
			}
			else if (LicensesDescriptorActions is not null)
			{
				writer.WritePropertyName("licenses");
				writer.WriteStartArray();
				foreach (var action in LicensesDescriptorActions)
				{
					JsonSerializer.Serialize(writer, new LicenseDescriptor(action), options);
				}

				writer.WriteEndArray();
			}
			else
			{
				writer.WritePropertyName("licenses");
				JsonSerializer.Serialize(writer, LicensesValue, options);
			}

			writer.WriteEndObject();
		}
	}
}