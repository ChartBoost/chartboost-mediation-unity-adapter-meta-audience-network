#import "CBMDelegates.h"
#import "ChartboostUnityUtilities.h"
#import <ChartboostMediationAdapterMetaAudienceNetwork/ChartboostMediationAdapterMetaAudienceNetwork-Swift.h>

extern "C" {

    const char * _CBMMetaAudienceNetworkAdapterAdapterVersion(){
        return toCStringOrNull([MetaAudienceNetworkAdapterConfiguration adapterVersion]);
    }

    const char * _CBMMetaAudienceNetworkAdapterPartnerSDKVersion(){
        return toCStringOrNull([MetaAudienceNetworkAdapterConfiguration partnerSDKVersion]);
    }

    const char * _CBMMetaAudienceNetworkAdapterPartnerId(){
        return toCStringOrNull([MetaAudienceNetworkAdapterConfiguration partnerID]);
    }

    const char * _CBMMetaAudienceNetworkAdapterPartnerDisplayName(){
        return toCStringOrNull([MetaAudienceNetworkAdapterConfiguration partnerDisplayName]);
    }

    BOOL _CBMMetaAudienceNetworkAdapterGetTestMode(){
        return [MetaAudienceNetworkAdapterConfiguration testMode];
    }

    void _CBMMetaAudienceNetworkAdapterSetTestMode(BOOL testMode){
        [MetaAudienceNetworkAdapterConfiguration setTestMode:testMode];
    }

    BOOL _CBMMetaAudienceNetworkAdapterGetVerboseLogging(){
        return [MetaAudienceNetworkAdapterConfiguration verboseLogging];
    }

    void _CBMMetaAudienceNetworkAdapterSetVerboseLogging(BOOL verboseLogging){
        [MetaAudienceNetworkAdapterConfiguration setVerboseLogging:verboseLogging];
    }

    const char * _CBMAdMobAdapterGetPlacementIds(){
        return toJSON([MetaAudienceNetworkAdapterConfiguration placementIDs]);
    }

    void _CBMAdMobAdapterSetPlacementIds(const char** placementIds, int placementIdsCount){
        if (placementIdsCount > 0)
            [MetaAudienceNetworkAdapterConfiguration setPlacementIDs:toNSMutableArray(placementIds, placementIdsCount)];
        else
            [MetaAudienceNetworkAdapterConfiguration setPlacementIDs:[NSArray new]];
    }
}
