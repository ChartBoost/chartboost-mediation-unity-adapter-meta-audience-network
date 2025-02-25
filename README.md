# Chartboost Mediation Unity SDK - Meta Audience Network Adapter

Provides a list of externally configurable properties pertaining to the partner SDK that can be retrieved and set by publishers. 

Dependencies for the adapter are now embedded in the package, and can be found at `com.chartboost.mediation.unity.adapter.meta-audience-network/Editor/MetaAudienceNetworkAdapterDependencies.xml`.

# Installation

## Using the public [npm registry](https://www.npmjs.com/search?q=com.chartboost.mediation.unity.adapter.meta-audience-network)

In order to add the Chartboost Mediation Unity SDK - Meta Audience Network Adapter to your project using the npm package, add the following to your Unity Project's ***manifest.json*** file. The scoped registry section is required in order to fetch packages from the NpmJS registry.

```json
"dependencies": {
    "com.chartboost.mediation.unity.adapter.meta-audience-network": "5.0.2",
    ...
},
"scopedRegistries": [
{
    "name": "NpmJS",
    "url": "https://registry.npmjs.org",
    "scopes": [
    "com.chartboost"
    ]
}
]
```
## Using the public [NuGet package](https://www.nuget.org/packages/Chartboost.CSharp.Mediation.Unity.Adapter.MetaAudienceNetwork)

To add the Chartboost Mediation Unity SDK - Meta Audience Network Adapter to your project using the NuGet package, you will first need to add the [NugetForUnity](https://github.com/GlitchEnzo/NuGetForUnity) package into your Unity Project.

This can be done by adding the following to your Unity Project's ***manifest.json***

```json
  "dependencies": {
    "com.github-glitchenzo.nugetforunity": "https://github.com/GlitchEnzo/NuGetForUnity.git?path=/src/NuGetForUnity",
    ...
  },
```

Once <code>NugetForUnity</code> is installed, search for `Chartboost.CSharp.Mediation.Unity.Adapter.MetaAudienceNetwork` in the search bar of Nuget Explorer window(Nuget -> Manage Nuget Packages).
You should be able to see the `Chartboost.CSharp.Mediation.Unity.Adapter.MetaAudienceNetwork` package. Choose the appropriate version and install.

# AndroidManifest.xml Permissions & Components

Required permissions:

```xml
<uses-permission android:name="android.permission.INTERNET" />
<uses-permission android:name="android.permission.WRITE_EXTERNAL_STORAGE"/>
<uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" />
<uses-permission android:name="android.permission.REQUEST_INSTALL_PACKAGES"/>
```

Optional permissions:

```xml
<uses-permission android:name="android.permission.ACCESS_WIFI_STATE" />
<uses-permission android:name="android.permission.ACCESS_COARSE_LOCATION" />
<uses-permission android:name="android.permission.ACCESS_FINE_LOCATION" />
```

# Usage
The following code block exemplifies usage of the `MetaAudienceNetworkAdapter.cs` configuration class.

## IPartnerAdapterConfiguration Properties

```csharp

// AdapterUnityVersion - The partner adapter Unity version, e.g: 5.0.0
Debug.Log($"Adapter Unity Version: {MetaAudienceNetworkAdapter.AdapterUnityVersion}");

// AdapterNativeVersion - The partner adapter version, e.g: 5.6.17.0.0
Debug.Log($"Adapter Native Version: {MetaAudienceNetworkAdapter.AdapterNativeVersion}");

// PartnerSDKVersion - The partner SDK version, e.g: 6.17.0
Debug.Log($"Partner SDK Version: {MetaAudienceNetworkAdapter.PartnerSDKVersion}");

// PartnerIdentifier - The partner ID for internal uses, e.g: facebook
Debug.Log($"Partner Identifier: {MetaAudienceNetworkAdapter.PartnerIdentifier}");

// PartnerDisplayName - The partner name for external uses, e.g: MetaAudienceNetwork
Debug.Log($"Partner Display Name: {MetaAudienceNetworkAdapter.PartnerDisplayName}");
```

## Test Mode
To enable test mode for the Meta Audience Network adapter, the following property has been made available:

```csharp
MetaAudienceNetworkAdapter.TestMode = true;
```

## Verbose Logging
To enable verbose logging for the Meta Audience Network adapter, the following property has been made available:

```csharp
MetaAudienceNetworkAdapter.VerboseLogging = true;
```

##
To set placement ids for the Meta Audience Network adapter, the following property has been made available:

```csharp
var placementIds = new List<string>
{
    "PLACEMENT_1",
    "PLACEMENT_2",
    "PLACEMENT_3"
};

MetaAudienceNetworkAdapter.PlacementIds = placementIds;
```