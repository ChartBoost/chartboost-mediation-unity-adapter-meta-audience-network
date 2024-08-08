using System;
using System.Collections.Generic;
using Chartboost.Mediation.MetaAudienceNetwork.Common;

namespace Chartboost.Mediation.MetaAudienceNetwork.Default
{
    internal class MetaAudienceNetworkDefault : IMetaAudienceNetworkAdapter
    {
        /// <inheritdoc/>
        public string AdapterNativeVersion => MetaAudienceNetworkAdapter.AdapterUnityVersion;

        /// <inheritdoc/>
        public string PartnerSDKVersion => MetaAudienceNetworkAdapter.AdapterUnityVersion;
        
        /// <inheritdoc/>
        public string PartnerIdentifier => "facebook";
        
        /// <inheritdoc/>
        public string PartnerDisplayName => "Meta Audience Network";

        /// <inheritdoc/>
        public bool TestMode { get; set; }
        
        /// <inheritdoc/>
        public bool VerboseLogging { get; set; }

        /// <inheritdoc/>
        public IReadOnlyCollection<string> PlacementIds
        {
            get => _placementIds ??= Array.Empty<string>();
            set => _placementIds = value;
        }

        private IReadOnlyCollection<string> _placementIds;
    }
}
