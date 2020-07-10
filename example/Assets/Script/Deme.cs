using UnityEngine;

/***
 * Deme.cs
 * 
 * @author abaojin
 */
public class Deme : MonoBehaviour
{
    private int res1;
    private int res2;
    private int res3;
    private int res4;

    void CallTstUnityPlugins()
    {
        res1 = NativeC.tst_add(10, 2);
        res2 = NativeC.tst_sub(10, 2);
        res3 = NativeC.tst_div(10, 2);
        res4 = NativeC.tst_mul(10, 2);

        Debug.Log("10+2=" + res1);
        Debug.Log("10-2=" + res2);
        Debug.Log("10/2=" + res3);
        Debug.Log("10*2=" + res4);
    }

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));

        if (GUILayout.Button("调用原生插件测试", GUILayout.Height(Screen.height >> 1))) {
            CallTstUnityPlugins();
        }

        GUILayout.TextArea(
           "10+2=" + res1 + "\n" + 
           "10-2=" + res2 + "\n" + 
           "10/2=" + res3 + "\n" + 
           "10*2=" + res4 + "\n", 
           GUILayout.Height(Screen.height >> 1)
        );

        GUILayout.EndArea();
    }
}
