using System.Collections.Generic;
using Chartboost.Constants;
using Chartboost.Mediation.MetaAudienceNetwork.Common;
using UnityEngine;

namespace Chartboost.Mediation.MetaAudienceNetwork.Android
{
    internal sealed class MetaAudienceNetworkAdapter : IMetaAudienceNetworkAdapter
    {
        private const string MetaAudienceNetworkAdapterConfiguration = "com.chartboost.mediation.metaaudiencenetworkadapter.MetaAudienceNetworkAdapterConfiguration";
        private const string MetaAudienceNetworkAdSettings = "com.facebook.ads.AdSettings";
        private const string FunctionGetPlacementIds = "getPlacementIds";
        private const string FunctionSetPlacementIds = "setPlacementIds";
        private const string FunctionSetDebugBuild = "setDebugBuild";
        
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            MetaAudienceNetwork.MetaAudienceNetworkAdapter.Instance = new MetaAudienceNetworkAdapter();
        }
        
        /// <inheritdoc/>
        public string AdapterNativeVersion
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(MetaAudienceNetworkAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetAdapterVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerSDKVersion 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(MetaAudienceNetworkAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerSdkVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerIdentifier
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(MetaAudienceNetworkAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerId);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerDisplayName 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(MetaAudienceNetworkAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerDisplayName);
            }
        }

        /// <inheritdoc/>
        public bool TestMode
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(MetaAudienceNetworkAdapterConfiguration);
                return adapterConfiguration.Call<bool>(SharedAndroidConstants.FunctionGetTestMode);
            }
            set
            {
                using var adapterConfiguration = new AndroidJavaObject(MetaAudienceNetworkAdapterConfiguration);
                adapterConfiguration.Call(SharedAndroidConstants.FunctionSetTestMode, value);
            }
        }
        
        /// <inheritdoc/>
        public bool VerboseLogging 
        {
            get => _verboseLogging;
            set
            {
                using var adapterConfiguration = new AndroidJavaClass(MetaAudienceNetworkAdSettings);
                adapterConfiguration.CallStatic(FunctionSetDebugBuild, value);
                _verboseLogging = value;
            }
        }

        // TODO - android does not provide getters for properties, keeping track of it on Unity for the time being. NOT IDEAL.
        private bool _verboseLogging;
        
        /// <inheritdoc/>
        public IReadOnlyCollection<string> PlacementIds
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(MetaAudienceNetworkAdapterConfiguration);
                return adapterConfiguration.Call<AndroidJavaObject>(FunctionGetPlacementIds).NativeListToList();
            }
            set
            {
                using var adapterConfiguration = new AndroidJavaObject(MetaAudienceNetworkAdapterConfiguration);
                adapterConfiguration.Call(FunctionSetPlacementIds, value.EnumerableToNativeList());
            }
        }
    }
}
