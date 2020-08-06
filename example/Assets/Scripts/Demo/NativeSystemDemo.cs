using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NativeSystemDemo : MonoBehaviour
{
    private int m_ret1;
    private int m_ret2;
    private bool m_ret3;
    private bool m_ret4;

    private void CallShockScreen()
    {
        NativeSystemCore.Client.ShockScreen(1000);
    }

    private void CallCancelShockScreen()
    {
        NativeSystemCore.Client.CancelShockScreen();
    }

    private void CallFunctionInfo()
    {
        m_ret1 = NativeSystemCore.Client.GetBattery();
        m_ret2 = NativeSystemCore.Client.GetNetworkLevel();
        m_ret3 = NativeSystemCore.Client.IsNetConnect();
        m_ret4 = NativeSystemCore.Client.IsWifiConnected();
    }

    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));

        int retHeight = 100;
        if (GUILayout.Button("返回Launcher", GUILayout.Height(retHeight))) {
            SceneManager.LoadScene("Launcher");
        }

        if (GUILayout.Button("调用System代码-震屏-开始", GUILayout.Height((Screen.height - retHeight) >> 3))) {
            CallShockScreen();
        }

        if (GUILayout.Button("调用System代码-震屏-取消", GUILayout.Height((Screen.height - retHeight) >> 3))) {
            CallCancelShockScreen();
        }

        if (GUILayout.Button("调用System代码-设备信息", GUILayout.Height((Screen.height - retHeight) >> 3))) {
            CallFunctionInfo();
        }

        GUILayout.TextArea(
           "电量=" + m_ret1 + "\n" +
           "信号=" + m_ret2 + "\n" +
           "是否联网=" + m_ret3 + "\n" +
           "是否连Wifi=" + m_ret4 + "\n",
           GUILayout.Height((Screen.height - retHeight) >> 1)
        );

        GUILayout.EndArea();
    }
}
