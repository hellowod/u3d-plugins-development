using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 系统插件接口
/// </summary>
public static class NativeSystemCore
{
    private static INative s_client;

    public static INative Client
    {
        get {
            if (s_client == null) {
                switch (Application.platform) {
                    case RuntimePlatform.Android:
                        s_client = new NativeAndroid();
                        break;
                    case RuntimePlatform.IPhonePlayer:
                        s_client = new NativeIOS();
                        break;
                    default:
                        s_client = new NativeDummy();
                        break;
                }
            }
            return s_client;
        }
    }
}
