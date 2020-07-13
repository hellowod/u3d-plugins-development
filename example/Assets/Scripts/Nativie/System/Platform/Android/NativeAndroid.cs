using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 安卓系统实现
/// </summary>
public class NativeAndroid : INative
{
    private AndroidJavaClass m_JavaClass = new AndroidJavaClass("com.plugin.UnityHelper");

    public int GetBattery()
    {
        return m_JavaClass.CallStatic<int>("getBattery");
    }

    public int GetSignal()
    {
        return m_JavaClass.CallStatic<int>("getSignal");
    }

    public void ShockScreen()
    {
        m_JavaClass.CallStatic<int>("shockScreen");
    }
}
