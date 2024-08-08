using System.Collections.Generic;
using Chartboost.Mediation.Adapters;

namespace Chartboost.Mediation.MetaAudienceNetwork.Common
{
    /// <summary>
    /// The Chartboost Mediation MetaAudienceNetwork adapter.
    /// </summary>
    internal interface IMetaAudienceNetworkAdapter : IPartnerAdapterConfiguration
    {
        /// <summary>
        /// Enable/disable Meta Audience Network's test mode. Remember to set this to false in production.
        /// </summary>
        public bool TestMode { get; set; }
        
        /// <summary>
        /// Enable/disable AppLovin's verbose logging.
        /// </summary>
        public bool VerboseLogging { get; set; }
        
        /// <summary>
        /// Optional list of placement IDs to pass into Meta Audience Network's initialization settings.
        /// If this list should be set, it must be set before initializing <see cref="ChartboostMediation"/>.
        /// </summary>
        public IReadOnlyCollection<string> PlacementIds { get; set; }
    }
}
