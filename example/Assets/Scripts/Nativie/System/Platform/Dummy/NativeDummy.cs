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
        throw new System.NotImplementedException();
    }

    public int GetSignal()
    {
        throw new System.NotImplementedException();
    }

    public void ShockScreen()
    {
        throw new System.NotImplementedException();
    }
}
