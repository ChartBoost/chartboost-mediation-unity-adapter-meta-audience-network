using System;
using System.Collections.Generic;
using Chartboost.Logging;
using Chartboost.Mediation.MetaAudienceNetwork;
using Chartboost.Tests.Runtime;
using NUnit.Framework;

namespace Chartboost.Tests
{
    internal class MetaAudienceNetworkAdapterTests
    {
        [SetUp]
        public void SetUp()
            => LogController.LoggingLevel = LogLevel.Debug;

        [Test]
        public void AdapterNativeVersion()
            => TestUtilities.TestStringGetter(() => MetaAudienceNetworkAdapter.AdapterNativeVersion);

        [Test]
        public void PartnerSDKVersion()
            => TestUtilities.TestStringGetter(() => MetaAudienceNetworkAdapter.PartnerSDKVersion);

        [Test]
        public void PartnerIdentifier()
            => TestUtilities.TestStringGetter(() => MetaAudienceNetworkAdapter.PartnerIdentifier);

        [Test]
        public void PartnerDisplayName()
            => TestUtilities.TestStringGetter(() => MetaAudienceNetworkAdapter.PartnerDisplayName);

        [Test]
        public void TestMode()
            => TestUtilities.TestBooleanAccessor(() => MetaAudienceNetworkAdapter.TestMode, value => MetaAudienceNetworkAdapter.TestMode = value);
        
        [Test]
        public void VerboseLogging()
            => TestUtilities.TestBooleanAccessor(() => MetaAudienceNetworkAdapter.VerboseLogging, value => MetaAudienceNetworkAdapter.VerboseLogging = value);

        [Test]
        public void PlacementIds()
        {
            Assert.AreEqual(Array.Empty<string>(), MetaAudienceNetworkAdapter.PlacementIds);

            var placementIds = new List<string>
            {
                "PLACEMENT_1",
                "PLACEMENT_2",
                "PLACEMENT_3"
            };

            MetaAudienceNetworkAdapter.PlacementIds = placementIds;
            Assert.AreEqual(placementIds ,MetaAudienceNetworkAdapter.PlacementIds);
            LogController.Log($"Placement Ids: {Json.JsonTools.SerializeObject(MetaAudienceNetworkAdapter.PlacementIds)}", LogLevel.Debug);
            MetaAudienceNetworkAdapter.PlacementIds = null;
            Assert.AreEqual(Array.Empty<string>(), MetaAudienceNetworkAdapter.PlacementIds);
        }
    }
}
