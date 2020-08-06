using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 虚拟系统实现
/// </summary>
public class NativeDummy : INative
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public void CancelShockScreen()
    {
        Debug.Log("CancelShockScreen");
    }

    public int Div(int a, int b)
    {
        return a / b;
    }

    public int GetBattery()
    {
        return 0;
    }

    public int GetNetworkLevel()
    {
        return 0;
    }

    public bool HasShockScreen()
    {
        return false;
    }

    public bool IsNetConnect()
    {
        return true;
    }

    public bool IsWifiConnected()
    {
        return true;
    }

    public int Mul(int a, int b)
    {
        return a * b;
    }

    public void ShockScreen(int time)
    {
        Debug.Log("ShockScreen");
    }

    public int Sub(int a, int b)
    {
        return a - b;
    }
}
