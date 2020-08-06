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
#if UNITY_IOS && !UNITY_EDITOR
                s_client = new NativeIOS();
#elif UNITY_ANDROID && !UNITY_EDITOR
                s_client = new NativeAndroid();
#else
                s_client = new NativeDummy();
#endif
            }
            return s_client;
        }
    }
}
