using Chartboost.Editor;
using Chartboost.Logging;
using Chartboost.Mediation.MetaAudienceNetwork;
using NUnit.Framework;

namespace Chartboost.Tests.Editor
{
    internal class VersionValidator
    {
        private const string UnityPackageManagerPackageName = "com.chartboost.mediation.unity.adapter.meta-audience-network";
        private const string NuGetPackageName = "Chartboost.CSharp.Mediation.Unity.Adapter.MetaAudienceNetwork";
        
        [SetUp]
        public void SetUp() 
            => LogController.LoggingLevel = LogLevel.Debug;
            
        [Test]
        public void ValidateVersion() 
            => VersionCheck.ValidateVersions(UnityPackageManagerPackageName, NuGetPackageName, MetaAudienceNetworkAdapter.AdapterUnityVersion);
    }
}
