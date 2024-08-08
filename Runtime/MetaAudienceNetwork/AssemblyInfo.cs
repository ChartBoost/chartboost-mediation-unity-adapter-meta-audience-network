using System.Runtime.CompilerServices;
using Chartboost.Mediation.MetaAudienceNetwork;
using UnityEngine.Scripting;

[assembly: AlwaysLinkAssembly]
[assembly: InternalsVisibleTo(AssemblyInfo.MetaAudienceNetworkAssemblyInfoAndroid)]
[assembly: InternalsVisibleTo(AssemblyInfo.MetaAudienceNetworkAssemblyInfoIOS)]

namespace Chartboost.Mediation.MetaAudienceNetwork
{
    internal class AssemblyInfo
    {
        public const string MetaAudienceNetworkAssemblyInfoAndroid = "Chartboost.Mediation.MetaAudienceNetwork.Android";
        public const string MetaAudienceNetworkAssemblyInfoIOS = "Chartboost.Mediation.MetaAudienceNetwork.IOS";
    }
}
