using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 安卓系统实现
/// </summary>
public class NativeAndroid : INative
{
    private AndroidJavaClass m_JavaClass = new AndroidJavaClass("com.hellowod.example.helper.NativeHelper");

    public int Add(int a, int b)
    {
        return m_JavaClass.CallStatic<int>("add", a, b);
    }

    public int Div(int a, int b)
    {
        return m_JavaClass.CallStatic<int>("div", a, b);
    }

    public int Sub(int a, int b)
    {
        return m_JavaClass.CallStatic<int>("sub", a, b);
    }

    public int Mul(int a, int b)
    {
        return m_JavaClass.CallStatic<int>("mul", a, b);
    }

    public int GetBattery()
    {
        return m_JavaClass.CallStatic<int>("getBattery");
    }

    public int GetNetworkLevel()
    {
        return m_JavaClass.CallStatic<int>("getNetworkLevel");
    }

    public void CancelShockScreen()
    {
        m_JavaClass.CallStatic("cancelShockScreen");
    }

    public bool HasShockScreen()
    {
        return m_JavaClass.CallStatic<bool>("hasShockScreen");
    }

    public bool IsNetConnect()
    {
        return m_JavaClass.CallStatic<bool>("isNetConnect");
    }

    public bool IsWifiConnected()
    {
        return m_JavaClass.CallStatic<bool>("isWifiConnected");
    }

    public void ShockScreen(int time)
    {
        m_JavaClass.CallStatic("shockScreen", time);
    }
}
