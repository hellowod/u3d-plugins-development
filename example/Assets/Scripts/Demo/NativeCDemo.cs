using UnityEngine;
using UnityEngine.SceneManagement;

public class NativeCDemo : MonoBehaviour
{
    private int m_ret1;
    private int m_ret2;
    private int m_ret3;
    private int m_ret4;

    private void Start()
    {
        NativeCSBinder.Register();
    }

    private void CallFunction()
    {
        m_ret1 = NativeCCore.tst_add(10, 2);
        m_ret2 = NativeCCore.tst_sub(10, 2);
        m_ret3 = NativeCCore.tst_div(10, 2);
        m_ret4 = NativeCCore.tst_mul(10, 2);

        Debug.Log("10+2=" + m_ret1);
        Debug.Log("10-2=" + m_ret2);
        Debug.Log("10/2=" + m_ret3);
        Debug.Log("10*2=" + m_ret4);
    }

    private void PInvokeFunction()
    {
        NativeCCore.call_func();
    }

    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));

        int retHeight = 100;
        if (GUILayout.Button("返回Launcher", GUILayout.Height(retHeight))) {
            SceneManager.LoadScene("Launcher");
        }

        if (GUILayout.Button("调用C代码", GUILayout.Height((Screen.height - retHeight) >> 2))) {
            CallFunction();
        }

        if (GUILayout.Button("C调用CS", GUILayout.Height((Screen.height - retHeight) >> 2))) {
            PInvokeFunction();
        }

        GUILayout.TextArea(
           "10+2=" + m_ret1 + "\n" + 
           "10-2=" + m_ret2 + "\n" + 
           "10/2=" + m_ret3 + "\n" + 
           "10*2=" + m_ret4 + "\n", 
           GUILayout.Height((Screen.height - retHeight) >> 1)
        );

        GUILayout.EndArea();
    }
}
