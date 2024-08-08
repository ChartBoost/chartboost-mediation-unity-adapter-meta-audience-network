using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Chartboost.Constants;
using Chartboost.Mediation.MetaAudienceNetwork.Common;
using Chartboost.Mediation.Utilities;
using UnityEngine;

namespace Chartboost.Mediation.MetaAudienceNetwork.IOS
{
    internal sealed class MetaAudienceNetworkAdapter : IMetaAudienceNetworkAdapter
    {
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            MetaAudienceNetwork.MetaAudienceNetworkAdapter.Instance = new MetaAudienceNetworkAdapter();
        }

        /// <inheritdoc/>
        public string AdapterNativeVersion => _CBMMetaAudienceNetworkAdapterAdapterVersion();
        
        /// <inheritdoc/>
        public string PartnerSDKVersion => _CBMMetaAudienceNetworkAdapterPartnerSDKVersion();
        
        /// <inheritdoc/>
        public string PartnerIdentifier => _CBMMetaAudienceNetworkAdapterPartnerId();
        
        /// <inheritdoc/>
        public string PartnerDisplayName => _CBMMetaAudienceNetworkAdapterPartnerDisplayName();
        
        /// <inheritdoc/>
        public bool TestMode
        {
            get => _CBMMetaAudienceNetworkAdapterGetTestMode();
            set => _CBMMetaAudienceNetworkAdapterSetTestMode(value);
        }
        
        /// <inheritdoc/>
        public bool VerboseLogging
        {
            get => _CBMMetaAudienceNetworkAdapterGetVerboseLogging();
            set => _CBMMetaAudienceNetworkAdapterSetVerboseLogging(value);
        }
        
        /// <inheritdoc/>
        public IReadOnlyCollection<string> PlacementIds
        {
            get
            {
                var testDeviceIds = _CBMAdMobAdapterGetPlacementIds();
                return string.IsNullOrEmpty(testDeviceIds) ? Array.Empty<string>() : testDeviceIds.ToList();
            }
            set
            {
                if (value == null || value.Count == 0)
                {
                    _CBMAdMobAdapterSetPlacementIds(Array.Empty<string>(), 0);
                    return;
                }
                _CBMAdMobAdapterSetPlacementIds(value.ToArray(), value.Count);
            }
        }
        
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMMetaAudienceNetworkAdapterAdapterVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMMetaAudienceNetworkAdapterPartnerSDKVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMMetaAudienceNetworkAdapterPartnerId();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMMetaAudienceNetworkAdapterPartnerDisplayName();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern bool _CBMMetaAudienceNetworkAdapterGetTestMode();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern void _CBMMetaAudienceNetworkAdapterSetTestMode(bool testMode);
        [DllImport(SharedIOSConstants.DLLImport)] private static extern bool _CBMMetaAudienceNetworkAdapterGetVerboseLogging();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern void _CBMMetaAudienceNetworkAdapterSetVerboseLogging(bool verboseLogging);
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMAdMobAdapterGetPlacementIds();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern void _CBMAdMobAdapterSetPlacementIds(string[] placementIds, int placementIdsCount);
    }
}
