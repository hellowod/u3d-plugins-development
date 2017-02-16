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
                PluginUtils.add(i, TIMES);
                PluginUtils.sub(i, TIMES);
                PluginUtils.div(i, TIMES);
                PluginUtils.mul(i, TIMES);
            }
            endTime = Time.realtimeSinceStartup;
            Printf("native");
            Profiler.EndSample();
        }

        if (GUI.Button(new Rect(10, 100, 120, 50), "mono")) {
            Profiler.BeginSample("mono");
            startTime = Time.realtimeSinceStartup;
            for(int i = 0; i < TIMES; ++i) {
                Add(i, TIMES);
                Sub(i, TIMES);
                Div(i, TIMES);
                Mul(i, TIMES);
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

    int Add(int a, int b)
    {
        return a + b;
    }

    int Sub(int a, int b)
    {
        return a - b;
    }

    int Div(int a, int b)
    {
        return a / b;
    }

    int Mul(int a, int b)
    {
        return a * b;
    }
}
