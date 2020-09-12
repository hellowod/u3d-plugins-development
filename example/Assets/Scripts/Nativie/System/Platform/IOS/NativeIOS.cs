using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

/// <summary>
/// 苹果系统实现
/// </summary>
public class NativeIOS: INative
{
    [DllImport("__Internal")]
    private static extern float getBattery();

    [DllImport("__Internal")]
    private static extern int getSignal();

    [DllImport("__Internal")]
    private static extern void shockScreen();

    [DllImport("__Internal")]
    private static extern int add(int a, int b);

    public int Add(int a, int b)
    {
       return add(a, b);
    }

    public void CancelShockScreen()
    {
        throw new System.NotImplementedException();
    }

    public int Div(int a, int b)
    {
        throw new System.NotImplementedException();
    }

    public int GetBattery()
    {
        throw new System.NotImplementedException();
    }

    public int GetNetworkLevel()
    {
        throw new System.NotImplementedException();
    }

    public bool HasShockScreen()
    {
        throw new System.NotImplementedException();
    }

    public bool IsNetConnect()
    {
        throw new System.NotImplementedException();
    }

    public bool IsWifiConnected()
    {
        throw new System.NotImplementedException();
    }

    public int Mul(int a, int b)
    {
        throw new System.NotImplementedException();
    }

    public void ShockScreen(int time)
    {
        throw new System.NotImplementedException();
    }

    public int Sub(int a, int b)
    {
        throw new System.NotImplementedException();
    }
}
