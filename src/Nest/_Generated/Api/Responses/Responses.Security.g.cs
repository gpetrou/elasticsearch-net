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
// Run the following in the root of the repository:
//
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------
using System;
using System.Text.Json.Serialization;

namespace Nest
{
    public class AuthenticateResponse : ResponseBase
    {
        [JsonPropertyName("email")]
        public string Email { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("full_name")]
        public string FullName { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("username")]
        public string Username { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("authentication_type")]
        public string AuthenticationType { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public class ChangePasswordResponse : ResponseBase
    {
    }

    public class ClearApiKeyCacheResponse : ResponseBase
    {
    }

    public class ClearCachedRealmsResponse : ResponseBase
    {
        [JsonPropertyName("cluster_name")]
        public string ClusterName { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public class ClearCachedRolesResponse : ResponseBase
    {
        [JsonPropertyName("cluster_name")]
        public string ClusterName { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public class CreateApiKeyResponse : ResponseBase
    {
        [JsonPropertyName("api_key")]
        public string ApiKey { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("expiration")]
        public long Expiration { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("name")]
        public string Name { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public class DeletePrivilegesResponse : DictionaryResponseBase
    {
    }

    public class DeleteRoleResponse : ResponseBase
    {
        [JsonPropertyName("found")]
        public bool Found { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public class DeleteRoleMappingResponse : ResponseBase
    {
        [JsonPropertyName("found")]
        public bool Found { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public class DeleteUserResponse : ResponseBase
    {
        [JsonPropertyName("found")]
        public bool Found { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public class DisableUserResponse : ResponseBase
    {
    }

    public class EnableUserResponse : ResponseBase
    {
    }

    public class GetApiKeyResponse : ResponseBase
    {
    }

    public class GetBuiltinPrivilegesResponse : ResponseBase
    {
    }

    public class GetPrivilegesResponse : DictionaryResponseBase
    {
    }

    public class GetRoleResponse : DictionaryResponseBase
    {
    }

    public class GetRoleMappingResponse : DictionaryResponseBase
    {
    }

    public class GetUserAccessTokenResponse : ResponseBase
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("expires_in")]
        public long ExpiresIn { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("scope")]
        public string Scope { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("type")]
        public string Type { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("kerberos_authentication_response_token")]
        public string KerberosAuthenticationResponseToken { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public class GetUserResponse : DictionaryResponseBase
    {
    }

    public class GetUserPrivilegesResponse : ResponseBase
    {
    }

    public class GrantApiKeyResponse : ResponseBase
    {
        [JsonPropertyName("api_key")]
        public string ApiKey { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public class HasPrivilegesResponse : ResponseBase
    {
        [JsonPropertyName("has_all_requested")]
        public bool HasAllRequested { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("username")]
        public string Username { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public class InvalidateApiKeyResponse : ResponseBase
    {
        [JsonPropertyName("error_count")]
        public int ErrorCount { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public class InvalidateUserAccessTokenResponse : ResponseBase
    {
        [JsonPropertyName("error_count")]
        public long ErrorCount { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("invalidated_tokens")]
        public long InvalidatedTokens { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("previously_invalidated_tokens")]
        public long PreviouslyInvalidatedTokens { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public class PutPrivilegesResponse : DictionaryResponseBase
    {
    }

    public class PutRoleResponse : ResponseBase
    {
    }

    public class PutRoleMappingResponse : ResponseBase
    {
        [JsonPropertyName("created")]
        public bool Created { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public class PutUserResponse : ResponseBase
    {
        [JsonPropertyName("created")]
        public bool Created { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public class GetCertificatesResponse : ResponseBase
    {
    }
}