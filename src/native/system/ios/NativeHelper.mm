#import "ShortVibrator.h"
#import <AudioToolbox/AudioServices.h>
@implementation ShortVibrator

// 获取电量
+(float)getBattery(){
    [[UIDevice currentDevice] setBatteryMonitoringEnabled:YES];
    return [[UIDevice currentDevice] batteryLevel];
}

//获取手机信号
 +(BOOL)getSignal{
	CTTelephonyNetworkInfo *info = [[CTTelephonyNetworkInfo alloc] init];
	NSString *mConnectType = info.currentRadioAccessTechnology;
	if (mConnectType != nil) {
		return true;
	} else {
		return false;
	}
}

//手机震屏
+(void)shockScreen(){
    AudioServicesPlaySystemSound();
}

@end
