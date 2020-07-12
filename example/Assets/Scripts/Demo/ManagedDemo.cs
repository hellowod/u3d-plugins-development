using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagedDemo : MonoBehaviour
{
    private int m_ret1;
    private int m_ret2;
    private int m_ret3;
    private int m_ret4;

    private void CallManagedFunction()
    {
        m_ret1 = ManagedCore.Add(10, 2);
        m_ret2 = ManagedCore.Sub(10, 2);
        m_ret3 = ManagedCore.Div(10, 2);
        m_ret4 = ManagedCore.Mul(10, 2);

        Debug.Log("10+2=" + m_ret1);
        Debug.Log("10-2=" + m_ret2);
        Debug.Log("10/2=" + m_ret3);
        Debug.Log("10*2=" + m_ret4);
    }

    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));

        int retHeight = 100;
        if (GUILayout.Button("返回Launcher", GUILayout.Height(retHeight))) {
            SceneManager.LoadScene("Launcher");
        }

        if (GUILayout.Button("调用Managed代码", GUILayout.Height((Screen.height - retHeight) >> 1))) {
            CallManagedFunction();
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
