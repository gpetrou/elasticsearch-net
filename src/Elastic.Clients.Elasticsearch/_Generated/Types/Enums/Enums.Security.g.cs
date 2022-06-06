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
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using Elastic.Transport;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Security
{
	[JsonConverter(typeof(AccessTokenGrantTypeConverter))]
	public enum AccessTokenGrantType
	{
		[EnumMember(Value = "refresh_token")]
		RefreshToken,
		[EnumMember(Value = "password")]
		Password,
		[EnumMember(Value = "client_credentials")]
		ClientCredentials,
		[EnumMember(Value = "_kerberos")]
		Kerberos
	}

	internal sealed class AccessTokenGrantTypeConverter : JsonConverter<AccessTokenGrantType>
	{
		public override AccessTokenGrantType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "refresh_token":
					return AccessTokenGrantType.RefreshToken;
				case "password":
					return AccessTokenGrantType.Password;
				case "client_credentials":
					return AccessTokenGrantType.ClientCredentials;
				case "_kerberos":
					return AccessTokenGrantType.Kerberos;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, AccessTokenGrantType value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case AccessTokenGrantType.RefreshToken:
					writer.WriteStringValue("refresh_token");
					return;
				case AccessTokenGrantType.Password:
					writer.WriteStringValue("password");
					return;
				case AccessTokenGrantType.ClientCredentials:
					writer.WriteStringValue("client_credentials");
					return;
				case AccessTokenGrantType.Kerberos:
					writer.WriteStringValue("_kerberos");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(ApiKeyGrantTypeConverter))]
	public enum ApiKeyGrantType
	{
		[EnumMember(Value = "password")]
		Password,
		[EnumMember(Value = "access_token")]
		AccessToken
	}

	internal sealed class ApiKeyGrantTypeConverter : JsonConverter<ApiKeyGrantType>
	{
		public override ApiKeyGrantType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "password":
					return ApiKeyGrantType.Password;
				case "access_token":
					return ApiKeyGrantType.AccessToken;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, ApiKeyGrantType value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case ApiKeyGrantType.Password:
					writer.WriteStringValue("password");
					return;
				case ApiKeyGrantType.AccessToken:
					writer.WriteStringValue("access_token");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(ClusterPrivilegeConverter))]
	public enum ClusterPrivilege
	{
		[EnumMember(Value = "transport_client")]
		TransportClient,
		[EnumMember(Value = "read_slm")]
		ReadSlm,
		[EnumMember(Value = "read_pipeline")]
		ReadPipeline,
		[EnumMember(Value = "read_ilm")]
		ReadIlm,
		[EnumMember(Value = "read_ccr")]
		ReadCcr,
		[EnumMember(Value = "monitor_watcher")]
		MonitorWatcher,
		[EnumMember(Value = "monitor_transform")]
		MonitorTransform,
		[EnumMember(Value = "monitor_text_structure")]
		MonitorTextStructure,
		[EnumMember(Value = "monitor_snapshot")]
		MonitorSnapshot,
		[EnumMember(Value = "monitor_rollup")]
		MonitorRollup,
		[EnumMember(Value = "monitor_ml")]
		MonitorMl,
		[EnumMember(Value = "monitor")]
		Monitor,
		[EnumMember(Value = "manage_watcher")]
		ManageWatcher,
		[EnumMember(Value = "manage_transform")]
		ManageTransform,
		[EnumMember(Value = "manage_token")]
		ManageToken,
		[EnumMember(Value = "manage_slm")]
		ManageSlm,
		[EnumMember(Value = "manage_service_account")]
		ManageServiceAccount,
		[EnumMember(Value = "manage_security")]
		ManageSecurity,
		[EnumMember(Value = "manage_saml")]
		ManageSaml,
		[EnumMember(Value = "manage_rollup")]
		ManageRollup,
		[EnumMember(Value = "manage_pipeline")]
		ManagePipeline,
		[EnumMember(Value = "manage_own_api_key")]
		ManageOwnApiKey,
		[EnumMember(Value = "manage_oidc")]
		ManageOidc,
		[EnumMember(Value = "manage_ml")]
		ManageMl,
		[EnumMember(Value = "manage_logstash_pipelines")]
		ManageLogstashPipelines,
		[EnumMember(Value = "manage_ingest_pipelines")]
		ManageIngestPipelines,
		[EnumMember(Value = "manage_index_templates")]
		ManageIndexTemplates,
		[EnumMember(Value = "manage_ilm")]
		ManageIlm,
		[EnumMember(Value = "manage_enrich")]
		ManageEnrich,
		[EnumMember(Value = "manage_ccr")]
		ManageCcr,
		[EnumMember(Value = "manage_api_key")]
		ManageApiKey,
		[EnumMember(Value = "manage")]
		Manage,
		[EnumMember(Value = "grant_api_key")]
		GrantApiKey,
		[EnumMember(Value = "create_snapshot")]
		CreateSnapshot,
		[EnumMember(Value = "cancel_task")]
		CancelTask,
		[EnumMember(Value = "all")]
		All
	}

	internal sealed class ClusterPrivilegeConverter : JsonConverter<ClusterPrivilege>
	{
		public override ClusterPrivilege Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "transport_client":
					return ClusterPrivilege.TransportClient;
				case "read_slm":
					return ClusterPrivilege.ReadSlm;
				case "read_pipeline":
					return ClusterPrivilege.ReadPipeline;
				case "read_ilm":
					return ClusterPrivilege.ReadIlm;
				case "read_ccr":
					return ClusterPrivilege.ReadCcr;
				case "monitor_watcher":
					return ClusterPrivilege.MonitorWatcher;
				case "monitor_transform":
					return ClusterPrivilege.MonitorTransform;
				case "monitor_text_structure":
					return ClusterPrivilege.MonitorTextStructure;
				case "monitor_snapshot":
					return ClusterPrivilege.MonitorSnapshot;
				case "monitor_rollup":
					return ClusterPrivilege.MonitorRollup;
				case "monitor_ml":
					return ClusterPrivilege.MonitorMl;
				case "monitor":
					return ClusterPrivilege.Monitor;
				case "manage_watcher":
					return ClusterPrivilege.ManageWatcher;
				case "manage_transform":
					return ClusterPrivilege.ManageTransform;
				case "manage_token":
					return ClusterPrivilege.ManageToken;
				case "manage_slm":
					return ClusterPrivilege.ManageSlm;
				case "manage_service_account":
					return ClusterPrivilege.ManageServiceAccount;
				case "manage_security":
					return ClusterPrivilege.ManageSecurity;
				case "manage_saml":
					return ClusterPrivilege.ManageSaml;
				case "manage_rollup":
					return ClusterPrivilege.ManageRollup;
				case "manage_pipeline":
					return ClusterPrivilege.ManagePipeline;
				case "manage_own_api_key":
					return ClusterPrivilege.ManageOwnApiKey;
				case "manage_oidc":
					return ClusterPrivilege.ManageOidc;
				case "manage_ml":
					return ClusterPrivilege.ManageMl;
				case "manage_logstash_pipelines":
					return ClusterPrivilege.ManageLogstashPipelines;
				case "manage_ingest_pipelines":
					return ClusterPrivilege.ManageIngestPipelines;
				case "manage_index_templates":
					return ClusterPrivilege.ManageIndexTemplates;
				case "manage_ilm":
					return ClusterPrivilege.ManageIlm;
				case "manage_enrich":
					return ClusterPrivilege.ManageEnrich;
				case "manage_ccr":
					return ClusterPrivilege.ManageCcr;
				case "manage_api_key":
					return ClusterPrivilege.ManageApiKey;
				case "manage":
					return ClusterPrivilege.Manage;
				case "grant_api_key":
					return ClusterPrivilege.GrantApiKey;
				case "create_snapshot":
					return ClusterPrivilege.CreateSnapshot;
				case "cancel_task":
					return ClusterPrivilege.CancelTask;
				case "all":
					return ClusterPrivilege.All;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, ClusterPrivilege value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case ClusterPrivilege.TransportClient:
					writer.WriteStringValue("transport_client");
					return;
				case ClusterPrivilege.ReadSlm:
					writer.WriteStringValue("read_slm");
					return;
				case ClusterPrivilege.ReadPipeline:
					writer.WriteStringValue("read_pipeline");
					return;
				case ClusterPrivilege.ReadIlm:
					writer.WriteStringValue("read_ilm");
					return;
				case ClusterPrivilege.ReadCcr:
					writer.WriteStringValue("read_ccr");
					return;
				case ClusterPrivilege.MonitorWatcher:
					writer.WriteStringValue("monitor_watcher");
					return;
				case ClusterPrivilege.MonitorTransform:
					writer.WriteStringValue("monitor_transform");
					return;
				case ClusterPrivilege.MonitorTextStructure:
					writer.WriteStringValue("monitor_text_structure");
					return;
				case ClusterPrivilege.MonitorSnapshot:
					writer.WriteStringValue("monitor_snapshot");
					return;
				case ClusterPrivilege.MonitorRollup:
					writer.WriteStringValue("monitor_rollup");
					return;
				case ClusterPrivilege.MonitorMl:
					writer.WriteStringValue("monitor_ml");
					return;
				case ClusterPrivilege.Monitor:
					writer.WriteStringValue("monitor");
					return;
				case ClusterPrivilege.ManageWatcher:
					writer.WriteStringValue("manage_watcher");
					return;
				case ClusterPrivilege.ManageTransform:
					writer.WriteStringValue("manage_transform");
					return;
				case ClusterPrivilege.ManageToken:
					writer.WriteStringValue("manage_token");
					return;
				case ClusterPrivilege.ManageSlm:
					writer.WriteStringValue("manage_slm");
					return;
				case ClusterPrivilege.ManageServiceAccount:
					writer.WriteStringValue("manage_service_account");
					return;
				case ClusterPrivilege.ManageSecurity:
					writer.WriteStringValue("manage_security");
					return;
				case ClusterPrivilege.ManageSaml:
					writer.WriteStringValue("manage_saml");
					return;
				case ClusterPrivilege.ManageRollup:
					writer.WriteStringValue("manage_rollup");
					return;
				case ClusterPrivilege.ManagePipeline:
					writer.WriteStringValue("manage_pipeline");
					return;
				case ClusterPrivilege.ManageOwnApiKey:
					writer.WriteStringValue("manage_own_api_key");
					return;
				case ClusterPrivilege.ManageOidc:
					writer.WriteStringValue("manage_oidc");
					return;
				case ClusterPrivilege.ManageMl:
					writer.WriteStringValue("manage_ml");
					return;
				case ClusterPrivilege.ManageLogstashPipelines:
					writer.WriteStringValue("manage_logstash_pipelines");
					return;
				case ClusterPrivilege.ManageIngestPipelines:
					writer.WriteStringValue("manage_ingest_pipelines");
					return;
				case ClusterPrivilege.ManageIndexTemplates:
					writer.WriteStringValue("manage_index_templates");
					return;
				case ClusterPrivilege.ManageIlm:
					writer.WriteStringValue("manage_ilm");
					return;
				case ClusterPrivilege.ManageEnrich:
					writer.WriteStringValue("manage_enrich");
					return;
				case ClusterPrivilege.ManageCcr:
					writer.WriteStringValue("manage_ccr");
					return;
				case ClusterPrivilege.ManageApiKey:
					writer.WriteStringValue("manage_api_key");
					return;
				case ClusterPrivilege.Manage:
					writer.WriteStringValue("manage");
					return;
				case ClusterPrivilege.GrantApiKey:
					writer.WriteStringValue("grant_api_key");
					return;
				case ClusterPrivilege.CreateSnapshot:
					writer.WriteStringValue("create_snapshot");
					return;
				case ClusterPrivilege.CancelTask:
					writer.WriteStringValue("cancel_task");
					return;
				case ClusterPrivilege.All:
					writer.WriteStringValue("all");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(IndexPrivilegeConverter))]
	public enum IndexPrivilege
	{
		[EnumMember(Value = "write")]
		Write,
		[EnumMember(Value = "view_index_metadata")]
		ViewIndexMetadata,
		[EnumMember(Value = "read_cross_cluster")]
		ReadCrossCluster,
		[EnumMember(Value = "read")]
		Read,
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "monitor")]
		Monitor,
		[EnumMember(Value = "manage_leader_index")]
		ManageLeaderIndex,
		[EnumMember(Value = "manage_ilm")]
		ManageIlm,
		[EnumMember(Value = "manage_follow_index")]
		ManageFollowIndex,
		[EnumMember(Value = "manage")]
		Manage,
		[EnumMember(Value = "maintenance")]
		Maintenance,
		[EnumMember(Value = "index")]
		Index,
		[EnumMember(Value = "delete_index")]
		DeleteIndex,
		[EnumMember(Value = "delete")]
		Delete,
		[EnumMember(Value = "create_index")]
		CreateIndex,
		[EnumMember(Value = "create_doc")]
		CreateDoc,
		[EnumMember(Value = "create")]
		Create,
		[EnumMember(Value = "auto_configure")]
		AutoConfigure,
		[EnumMember(Value = "all")]
		All
	}

	internal sealed class IndexPrivilegeConverter : JsonConverter<IndexPrivilege>
	{
		public override IndexPrivilege Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "write":
					return IndexPrivilege.Write;
				case "view_index_metadata":
					return IndexPrivilege.ViewIndexMetadata;
				case "read_cross_cluster":
					return IndexPrivilege.ReadCrossCluster;
				case "read":
					return IndexPrivilege.Read;
				case "none":
					return IndexPrivilege.None;
				case "monitor":
					return IndexPrivilege.Monitor;
				case "manage_leader_index":
					return IndexPrivilege.ManageLeaderIndex;
				case "manage_ilm":
					return IndexPrivilege.ManageIlm;
				case "manage_follow_index":
					return IndexPrivilege.ManageFollowIndex;
				case "manage":
					return IndexPrivilege.Manage;
				case "maintenance":
					return IndexPrivilege.Maintenance;
				case "index":
					return IndexPrivilege.Index;
				case "delete_index":
					return IndexPrivilege.DeleteIndex;
				case "delete":
					return IndexPrivilege.Delete;
				case "create_index":
					return IndexPrivilege.CreateIndex;
				case "create_doc":
					return IndexPrivilege.CreateDoc;
				case "create":
					return IndexPrivilege.Create;
				case "auto_configure":
					return IndexPrivilege.AutoConfigure;
				case "all":
					return IndexPrivilege.All;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, IndexPrivilege value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case IndexPrivilege.Write:
					writer.WriteStringValue("write");
					return;
				case IndexPrivilege.ViewIndexMetadata:
					writer.WriteStringValue("view_index_metadata");
					return;
				case IndexPrivilege.ReadCrossCluster:
					writer.WriteStringValue("read_cross_cluster");
					return;
				case IndexPrivilege.Read:
					writer.WriteStringValue("read");
					return;
				case IndexPrivilege.None:
					writer.WriteStringValue("none");
					return;
				case IndexPrivilege.Monitor:
					writer.WriteStringValue("monitor");
					return;
				case IndexPrivilege.ManageLeaderIndex:
					writer.WriteStringValue("manage_leader_index");
					return;
				case IndexPrivilege.ManageIlm:
					writer.WriteStringValue("manage_ilm");
					return;
				case IndexPrivilege.ManageFollowIndex:
					writer.WriteStringValue("manage_follow_index");
					return;
				case IndexPrivilege.Manage:
					writer.WriteStringValue("manage");
					return;
				case IndexPrivilege.Maintenance:
					writer.WriteStringValue("maintenance");
					return;
				case IndexPrivilege.Index:
					writer.WriteStringValue("index");
					return;
				case IndexPrivilege.DeleteIndex:
					writer.WriteStringValue("delete_index");
					return;
				case IndexPrivilege.Delete:
					writer.WriteStringValue("delete");
					return;
				case IndexPrivilege.CreateIndex:
					writer.WriteStringValue("create_index");
					return;
				case IndexPrivilege.CreateDoc:
					writer.WriteStringValue("create_doc");
					return;
				case IndexPrivilege.Create:
					writer.WriteStringValue("create");
					return;
				case IndexPrivilege.AutoConfigure:
					writer.WriteStringValue("auto_configure");
					return;
				case IndexPrivilege.All:
					writer.WriteStringValue("all");
					return;
			}

			writer.WriteNullValue();
		}
	}
}