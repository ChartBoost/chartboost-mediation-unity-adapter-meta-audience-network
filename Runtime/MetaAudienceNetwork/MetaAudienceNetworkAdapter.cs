using System.Collections.Generic;
using Chartboost.Mediation.Adapters;
using Chartboost.Mediation.MetaAudienceNetwork.Common;
using Chartboost.Mediation.MetaAudienceNetwork.Default;

namespace Chartboost.Mediation.MetaAudienceNetwork
{
    /// <inheritdoc cref="IMetaAudienceNetworkAdapter"/>
    public static class MetaAudienceNetworkAdapter 
    {
        internal static IMetaAudienceNetworkAdapter Instance = new MetaAudienceNetworkDefault();
        
        /// <summary>
        /// The partner adapter Unity version.
        /// </summary>
        public const string AdapterUnityVersion = "5.0.4";
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.AdapterNativeVersion"/>
        public static string AdapterNativeVersion => Instance.AdapterNativeVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerSDKVersion"/>
        public static string PartnerSDKVersion => Instance.PartnerSDKVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerIdentifier"/>
        public static string PartnerIdentifier => Instance.PartnerIdentifier;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerDisplayName"/>
        public static string PartnerDisplayName => Instance.PartnerDisplayName;

        /// <inheritdoc cref="IMetaAudienceNetworkAdapter.TestMode"/>
        public static bool TestMode
        {
            get => Instance.TestMode;
            set => Instance.TestMode = value;
        }
        
        /// <inheritdoc cref="IMetaAudienceNetworkAdapter.VerboseLogging"/>
        public static bool VerboseLogging
        {
            get => Instance.VerboseLogging;
            set => Instance.VerboseLogging = value;
        }

        /// <inheritdoc cref="IMetaAudienceNetworkAdapter.PlacementIds"/>
        public static IReadOnlyCollection<string> PlacementIds
        {
            get => Instance.PlacementIds;
            set => Instance.PlacementIds = value;
        }
    }
}
