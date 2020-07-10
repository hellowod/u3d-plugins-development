using UnityEngine;

public class NativeCDemo : MonoBehaviour
{
    private int m_ret1;
    private int m_ret2;
    private int m_ret3;
    private int m_ret4;

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

    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));

        if (GUILayout.Button("调用C代码", GUILayout.Height(Screen.height >> 1))) {
            CallFunction();
        }

        GUILayout.TextArea(
           "10+2=" + m_ret1 + "\n" + 
           "10-2=" + m_ret2 + "\n" + 
           "10/2=" + m_ret3 + "\n" + 
           "10*2=" + m_ret4 + "\n", 
           GUILayout.Height(Screen.height >> 1)
        );

        GUILayout.EndArea();
    }
}
