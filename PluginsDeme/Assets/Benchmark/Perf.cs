using UnityEngine;

/***
 * Perf.cs
 * 
 * @author abaojin
 * 
 * 简单加减乘除测试不代表所有
 */
public class Perf : MonoBehaviour
{
    private const int TIMES = 9000000;

    private float startTime;
    private float endTime;

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 120, 50), "native")) {
            Profiler.BeginSample("native");
            startTime = Time.realtimeSinceStartup;
            for (int i = 0; i < TIMES; ++i) {
                PluginUtils.tst_add(i, TIMES);
                PluginUtils.tst_sub(i, TIMES);
                PluginUtils.tst_div(i, TIMES);
                PluginUtils.tst_mul(i, TIMES);
            }
            endTime = Time.realtimeSinceStartup;
            Printf("native");
            Profiler.EndSample();
        }

        if (GUI.Button(new Rect(10, 100, 120, 50), "mono")) {
            Profiler.BeginSample("mono");
            startTime = Time.realtimeSinceStartup;
            for(int i = 0; i < TIMES; ++i) {
                cs_add(i, TIMES);
                cs_sub(i, TIMES);
                cs_div(i, TIMES);
                cs_mul(i, TIMES);
            }
            endTime = Time.realtimeSinceStartup;
            Printf("mono");
            Profiler.EndSample();
        }
    }

    void Printf(string type)
    {
        Debug.Log(string.Format("{0} Time: {1}", type, (endTime - startTime)));
    }

    int cs_add(int a, int b)
    {
        return a + b;
    }

    int cs_sub(int a, int b)
    {
        return a - b;
    }

    int cs_div(int a, int b)
    {
        return a / b;
    }

    int cs_mul(int a, int b)
    {
        return a * b;
    }
}
