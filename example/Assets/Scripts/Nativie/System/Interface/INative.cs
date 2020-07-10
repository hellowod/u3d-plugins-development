using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 原生插件接口
/// </summary>
public interface INative
{
    /// <summary>
    /// 获取电量
    /// </summary>
    /// <returns></returns>
    int GetBattery();

    /// <summary>
    /// 获取信号强度
    /// </summary>
    /// <returns></returns>
    int GetSignal();

    /// <summary>
    /// 手机震屏
    /// </summary>
    void ShockScreen();
}
