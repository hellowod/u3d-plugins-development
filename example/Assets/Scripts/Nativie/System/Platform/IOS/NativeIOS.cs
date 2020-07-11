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


    public int GetBattery()
    {
        return (int)getBattery();
    }

    public int GetSignal()
    {
        return getSignal();
    }

    public void ShockScreen()
    {
        shockScreen();
    }
}
