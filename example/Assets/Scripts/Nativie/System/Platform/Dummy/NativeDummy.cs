using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 虚拟系统实现
/// </summary>
public class NativeDummy : INative
{
    public int GetBattery()
    {
        return 1;
    }

    public int GetSignal()
    {
        return 1;
    }

    public void ShockScreen()
    {
        Debug.Log("Current is dummy system.");
    }
}
