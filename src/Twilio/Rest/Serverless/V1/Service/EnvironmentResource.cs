/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
/// 
/// EnvironmentResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Serverless.V1.Service 
{

    public class EnvironmentResource : Resource 
    {
        private static Request BuildReadRequest(ReadEnvironmentOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Serverless,
                "/v1/Services/" + options.PathServiceSid + "/Environments",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Environment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Environment </returns> 
        public static ResourceSet<EnvironmentResource> Read(ReadEnvironmentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<EnvironmentResource>.FromJson("environments", response.Content);
            return new ResourceSet<EnvironmentResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Environment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Environment </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<EnvironmentResource>> ReadAsync(ReadEnvironmentOptions options, 
                                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<EnvironmentResource>.FromJson("environments", response.Content);
            return new ResourceSet<EnvironmentResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Environment </returns> 
        public static ResourceSet<EnvironmentResource> Read(string pathServiceSid, 
                                                            int? pageSize = null, 
                                                            long? limit = null, 
                                                            ITwilioRestClient client = null)
        {
            var options = new ReadEnvironmentOptions(pathServiceSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Environment </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<EnvironmentResource>> ReadAsync(string pathServiceSid, 
                                                                                                    int? pageSize = null, 
                                                                                                    long? limit = null, 
                                                                                                    ITwilioRestClient client = null)
        {
            var options = new ReadEnvironmentOptions(pathServiceSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<EnvironmentResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<EnvironmentResource>.FromJson("environments", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<EnvironmentResource> NextPage(Page<EnvironmentResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Serverless,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<EnvironmentResource>.FromJson("environments", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<EnvironmentResource> PreviousPage(Page<EnvironmentResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Serverless,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<EnvironmentResource>.FromJson("environments", response.Content);
        }

        private static Request BuildFetchRequest(FetchEnvironmentOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Serverless,
                "/v1/Services/" + options.PathServiceSid + "/Environments/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Environment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Environment </returns> 
        public static EnvironmentResource Fetch(FetchEnvironmentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Environment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Environment </returns> 
        public static async System.Threading.Tasks.Task<EnvironmentResource> FetchAsync(FetchEnvironmentOptions options, 
                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Environment </returns> 
        public static EnvironmentResource Fetch(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchEnvironmentOptions(pathServiceSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Environment </returns> 
        public static async System.Threading.Tasks.Task<EnvironmentResource> FetchAsync(string pathServiceSid, 
                                                                                        string pathSid, 
                                                                                        ITwilioRestClient client = null)
        {
            var options = new FetchEnvironmentOptions(pathServiceSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateEnvironmentOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Serverless,
                "/v1/Services/" + options.PathServiceSid + "/Environments",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Environment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Environment </returns> 
        public static EnvironmentResource Create(CreateEnvironmentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Environment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Environment </returns> 
        public static async System.Threading.Tasks.Task<EnvironmentResource> CreateAsync(CreateEnvironmentOptions options, 
                                                                                         ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="uniqueName"> The unique_name </param>
        /// <param name="domainSuffix"> The domain_suffix </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Environment </returns> 
        public static EnvironmentResource Create(string pathServiceSid, 
                                                 string uniqueName, 
                                                 string domainSuffix = null, 
                                                 ITwilioRestClient client = null)
        {
            var options = new CreateEnvironmentOptions(pathServiceSid, uniqueName){DomainSuffix = domainSuffix};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="uniqueName"> The unique_name </param>
        /// <param name="domainSuffix"> The domain_suffix </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Environment </returns> 
        public static async System.Threading.Tasks.Task<EnvironmentResource> CreateAsync(string pathServiceSid, 
                                                                                         string uniqueName, 
                                                                                         string domainSuffix = null, 
                                                                                         ITwilioRestClient client = null)
        {
            var options = new CreateEnvironmentOptions(pathServiceSid, uniqueName){DomainSuffix = domainSuffix};
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a EnvironmentResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> EnvironmentResource object represented by the provided JSON </returns> 
        public static EnvironmentResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<EnvironmentResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The service_sid
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// The build_sid
        /// </summary>
        [JsonProperty("build_sid")]
        public string BuildSid { get; private set; }
        /// <summary>
        /// The unique_name
        /// </summary>
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }
        /// <summary>
        /// The domain_suffix
        /// </summary>
        [JsonProperty("domain_suffix")]
        public string DomainSuffix { get; private set; }
        /// <summary>
        /// The domain_name
        /// </summary>
        [JsonProperty("domain_name")]
        public string DomainName { get; private set; }
        /// <summary>
        /// The date_created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date_updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private EnvironmentResource()
        {

        }
    }

}