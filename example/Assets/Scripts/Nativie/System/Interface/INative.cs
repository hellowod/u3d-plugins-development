using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 原生插件接口
/// </summary>
public interface INative
{
    int Add(int a, int b);
    int Sub(int a, int b);
    int Div(int a, int b);
    int Mul(int a, int b);
  
    /// <summary>
    /// 手机震屏
    /// </summary>
    void ShockScreen(int time);

    /// <summary>
    /// 是否震屏
    /// </summary>
    bool HasShockScreen();

    /// <summary>
    /// 取消震屏
    /// </summary>
    void CancelShockScreen();

    /// <summary>
    /// 获取电量
    /// </summary>
    /// <returns></returns>
    int GetBattery();

    /// <summary>
    /// 获取信号强度
    /// </summary>
    /// <returns></returns>
    bool IsNetConnect();

    /// <summary>
    /// 是否为无线连接
    /// </summary>
    /// <returns></returns>
    bool IsWifiConnected();

    /// <summary>
    /// 获取网络信号强弱
    /// </summary>
    /// <returns></returns>
    int GetNetworkLevel();
}
