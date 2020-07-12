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

    private void CallShockScreen()
    {
        NativeSystemCore.Client.ShockScreen();
    }

    private void CallFunctionInfo()
    {
        m_ret1 = NativeSystemCore.Client.GetBattery();
        m_ret2 = NativeSystemCore.Client.GetSignal();
    }

    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));

        int retHeight = 100;
        if (GUILayout.Button("返回Launcher", GUILayout.Height(retHeight))) {
            SceneManager.LoadScene("Launcher");
        }

        if (GUILayout.Button("调用System代码-震屏", GUILayout.Height((Screen.height - retHeight) >> 2))) {
            CallShockScreen();
        }

        if (GUILayout.Button("调用System代码-信息", GUILayout.Height((Screen.height - retHeight) >> 2))) {
            CallFunctionInfo();
        }

        GUILayout.TextArea(
           "电量=" + m_ret1 + "\n" +
           "信号=" + m_ret2 + "\n",
           GUILayout.Height((Screen.height - retHeight) >> 1)
        );

        GUILayout.EndArea();
    }
}
