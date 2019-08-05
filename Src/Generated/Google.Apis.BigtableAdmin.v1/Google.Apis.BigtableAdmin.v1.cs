// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by google-apis-code-generator 1.5.1
//     C# generator version: 1.40.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \brief
 *   Cloud Bigtable Admin API Version v1
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://cloud.google.com/bigtable/'>Cloud Bigtable Admin API</a>
 *      <tr><th>API Version<td>v1
 *      <tr><th>API Rev<td>20190628 (1639)
 *      <tr><th>API Docs
 *          <td><a href='https://cloud.google.com/bigtable/'>
 *              https://cloud.google.com/bigtable/</a>
 *      <tr><th>Discovery Name<td>bigtableadmin
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using Cloud Bigtable Admin API can be found at
 * <a href='https://cloud.google.com/bigtable/'>https://cloud.google.com/bigtable/</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.BigtableAdmin.v1
{
    /// <summary>The BigtableAdmin Service.</summary>
    public class BigtableAdminService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public BigtableAdminService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public BigtableAdminService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {

        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "bigtableadmin"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            get { return BaseUriOverride ?? "https://bigtableadmin.googleapis.com/"; }
        #else
            get { return "https://bigtableadmin.googleapis.com/"; }
        #endif
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return ""; }
        }

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri
        {
            get { return "https://bigtableadmin.googleapis.com/batch"; }
        }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath
        {
            get { return "batch"; }
        }
        #endif




    }

    ///<summary>A base abstract class for BigtableAdmin requests.</summary>
    public abstract class BigtableAdminBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new BigtableAdminBaseServiceRequest instance.</summary>
        protected BigtableAdminBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1,
            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,
            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes BigtableAdmin parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "$.xgafv", new Google.Apis.Discovery.Parameter
                {
                    Name = "$.xgafv",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "access_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "access_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "callback", new Google.Apis.Discovery.Parameter
                {
                    Name = "callback",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "uploadType", new Google.Apis.Discovery.Parameter
                {
                    Name = "uploadType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "upload_protocol", new Google.Apis.Discovery.Parameter
                {
                    Name = "upload_protocol",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }
}

namespace Google.Apis.BigtableAdmin.v1.Data
{    

    /// <summary>A resizable group of nodes in a particular cloud location, capable of serving all Tables in the parent
    /// Instance.</summary>
    public class Cluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>(`CreationOnly`) The type of storage used by this cluster to serve its parent instance's tables,
        /// unless explicitly overridden.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultStorageType")]
        public virtual string DefaultStorageType { get; set; } 

        /// <summary>(`CreationOnly`) The location where this cluster's nodes and storage reside. For best performance,
        /// clients should be located as close as possible to this cluster. Currently only zones are supported, so
        /// values should be of the form `projects//locations/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; } 

        /// <summary>(`OutputOnly`) The unique name of the cluster. Values are of the form
        /// `projects//instances//clusters/a-z*`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The number of nodes allocated to this cluster. More nodes enable higher throughput and more
        /// consistent performance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serveNodes")]
        public virtual System.Nullable<int> ServeNodes { get; set; } 

        /// <summary>(`OutputOnly`) The current state of the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The metadata for the Operation returned by CreateCluster.</summary>
    public class CreateClusterMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time at which the operation failed or was completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishTime")]
        public virtual object FinishTime { get; set; } 

        /// <summary>The request that prompted the initiation of this CreateCluster operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalRequest")]
        public virtual CreateClusterRequest OriginalRequest { get; set; } 

        /// <summary>The time at which the original request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestTime")]
        public virtual object RequestTime { get; set; } 

        /// <summary>Keys: the full `name` of each table that existed in the instance when CreateCluster was first
        /// called, i.e. `projects//instances//tables/`. Any table added to the instance by a later API call will be
        /// created in the new cluster by that API call, not this one.
        ///
        /// Values: information on how much of a table's data has been copied to the newly-created cluster so
        /// far.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tables")]
        public virtual System.Collections.Generic.IDictionary<string,TableProgress> Tables { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for BigtableInstanceAdmin.CreateCluster.</summary>
    public class CreateClusterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The cluster to be created. Fields marked `OutputOnly` must be left blank.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual Cluster Cluster { get; set; } 

        /// <summary>The ID to be used when referring to the new cluster within its instance, e.g., just `mycluster`
        /// rather than `projects/myproject/instances/myinstance/clusters/mycluster`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; } 

        /// <summary>The unique name of the instance in which to create the new cluster. Values are of the form
        /// `projects//instances/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The metadata for the Operation returned by CreateInstance.</summary>
    public class CreateInstanceMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time at which the operation failed or was completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishTime")]
        public virtual object FinishTime { get; set; } 

        /// <summary>The request that prompted the initiation of this CreateInstance operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalRequest")]
        public virtual CreateInstanceRequest OriginalRequest { get; set; } 

        /// <summary>The time at which the original request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestTime")]
        public virtual object RequestTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for BigtableInstanceAdmin.CreateInstance.</summary>
    public class CreateInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The clusters to be created within the instance, mapped by desired cluster ID, e.g., just
        /// `mycluster` rather than `projects/myproject/instances/myinstance/clusters/mycluster`. Fields marked
        /// `OutputOnly` must be left blank. Currently, at most two clusters can be specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusters")]
        public virtual System.Collections.Generic.IDictionary<string,Cluster> Clusters { get; set; } 

        /// <summary>The instance to create. Fields marked `OutputOnly` must be left blank.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual Instance Instance { get; set; } 

        /// <summary>The ID to be used when referring to the new instance within its project, e.g., just `myinstance`
        /// rather than `projects/myproject/instances/myinstance`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceId")]
        public virtual string InstanceId { get; set; } 

        /// <summary>The unique name of the project in which to create the new instance. Values are of the form
        /// `projects/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A collection of Bigtable Tables and the resources that serve them. All tables in an instance are served
    /// from all Clusters in the instance.</summary>
    public class Instance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The descriptive name for this instance as it appears in UIs. Can be changed at any time, but should
        /// be kept globally unique to avoid confusion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Labels are a flexible and lightweight mechanism for organizing cloud resources into groups that
        /// reflect a customer's organizational needs and deployment strategies. They can be used to filter resources
        /// and aggregate metrics.
        ///
        /// * Label keys must be between 1 and 63 characters long and must conform to the regular expression:
        /// `\p{Ll}\p{Lo}{0,62}`. * Label values must be between 0 and 63 characters long and must conform to the
        /// regular expression: `[\p{Ll}\p{Lo}\p{N}_-]{0,63}`. * No more than 64 labels can be associated with a given
        /// resource. * Keys and values must both be under 128 bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string,string> Labels { get; set; } 

        /// <summary>(`OutputOnly`) The unique name of the instance. Values are of the form
        /// `projects//instances/a-z+[a-z0-9]`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>(`OutputOnly`) The current state of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; } 

        /// <summary>The type of the instance. Defaults to `PRODUCTION`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for BigtableInstanceAdmin.PartialUpdateInstance.</summary>
    public class PartialUpdateInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Instance which will (partially) replace the current value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual Instance Instance { get; set; } 

        /// <summary>The subset of Instance fields which should be replaced. Must be explicitly set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Progress info for copying a table's data to the new cluster.</summary>
    public class TableProgress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Estimate of the number of bytes copied so far for this table. This will eventually reach
        /// 'estimated_size_bytes' unless the table copy is CANCELLED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedCopiedBytes")]
        public virtual System.Nullable<long> EstimatedCopiedBytes { get; set; } 

        /// <summary>Estimate of the size of the table to be copied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedSizeBytes")]
        public virtual System.Nullable<long> EstimatedSizeBytes { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The metadata for the Operation returned by UpdateAppProfile.</summary>
    public class UpdateAppProfileMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The metadata for the Operation returned by UpdateCluster.</summary>
    public class UpdateClusterMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time at which the operation failed or was completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishTime")]
        public virtual object FinishTime { get; set; } 

        /// <summary>The request that prompted the initiation of this UpdateCluster operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalRequest")]
        public virtual Cluster OriginalRequest { get; set; } 

        /// <summary>The time at which the original request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestTime")]
        public virtual object RequestTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The metadata for the Operation returned by UpdateInstance.</summary>
    public class UpdateInstanceMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time at which the operation failed or was completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishTime")]
        public virtual object FinishTime { get; set; } 

        /// <summary>The request that prompted the initiation of this UpdateInstance operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalRequest")]
        public virtual PartialUpdateInstanceRequest OriginalRequest { get; set; } 

        /// <summary>The time at which the original request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestTime")]
        public virtual object RequestTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
