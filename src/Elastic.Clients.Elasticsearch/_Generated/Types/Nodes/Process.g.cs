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
namespace Elastic.Clients.Elasticsearch.Nodes
{
	public partial class Process
	{
		[JsonInclude]
		[JsonPropertyName("cpu")]
		public Elastic.Clients.Elasticsearch.Nodes.Cpu? Cpu { get; init; }

		[JsonInclude]
		[JsonPropertyName("max_file_descriptors")]
		public int? MaxFileDescriptors { get; init; }

		[JsonInclude]
		[JsonPropertyName("mem")]
		public Elastic.Clients.Elasticsearch.Nodes.MemoryStats? Mem { get; init; }

		[JsonInclude]
		[JsonPropertyName("open_file_descriptors")]
		public int? OpenFileDescriptors { get; init; }

		[JsonInclude]
		[JsonPropertyName("timestamp")]
		public long? Timestamp { get; init; }
	}
}