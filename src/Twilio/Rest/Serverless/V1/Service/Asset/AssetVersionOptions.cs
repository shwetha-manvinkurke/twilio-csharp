/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Serverless.V1.Service.Asset 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// ReadAssetVersionOptions
    /// </summary>
    public class ReadAssetVersionOptions : ReadOptions<AssetVersionResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The asset_sid
        /// </summary>
        public string PathAssetSid { get; }

        /// <summary>
        /// Construct a new ReadAssetVersionOptions
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathAssetSid"> The asset_sid </param>
        public ReadAssetVersionOptions(string pathServiceSid, string pathAssetSid)
        {
            PathServiceSid = pathServiceSid;
            PathAssetSid = pathAssetSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// FetchAssetVersionOptions
    /// </summary>
    public class FetchAssetVersionOptions : IOptions<AssetVersionResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The asset_sid
        /// </summary>
        public string PathAssetSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchAssetVersionOptions
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathAssetSid"> The asset_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchAssetVersionOptions(string pathServiceSid, string pathAssetSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathAssetSid = pathAssetSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// CreateAssetVersionOptions
    /// </summary>
    public class CreateAssetVersionOptions : IOptions<AssetVersionResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The asset_sid
        /// </summary>
        public string PathAssetSid { get; }
        /// <summary>
        /// The path
        /// </summary>
        public string Path { get; }
        /// <summary>
        /// The visibility
        /// </summary>
        public AssetVersionResource.VisibilityEnum Visibility { get; }

        /// <summary>
        /// Construct a new CreateAssetVersionOptions
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathAssetSid"> The asset_sid </param>
        /// <param name="path"> The path </param>
        /// <param name="visibility"> The visibility </param>
        public CreateAssetVersionOptions(string pathServiceSid, 
                                         string pathAssetSid, 
                                         string path, 
                                         AssetVersionResource.VisibilityEnum visibility)
        {
            PathServiceSid = pathServiceSid;
            PathAssetSid = pathAssetSid;
            Path = path;
            Visibility = visibility;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Path != null)
            {
                p.Add(new KeyValuePair<string, string>("Path", Path));
            }

            if (Visibility != null)
            {
                p.Add(new KeyValuePair<string, string>("Visibility", Visibility.ToString()));
            }

            return p;
        }
    }

}