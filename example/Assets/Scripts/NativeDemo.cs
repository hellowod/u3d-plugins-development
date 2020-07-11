using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NativeDemo : MonoBehaviour
{
    private void CallCDemo()
    {
        SceneManager.LoadScene("C");
    }

    private void CallSystemDemo()
    {
        SceneManager.LoadScene("System");
    }

    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));

        if (GUILayout.Button("Demo C", GUILayout.Height(Screen.height >> 1)))
        {
            CallCDemo();
        }

        if (GUILayout.Button("Demo System", GUILayout.Height(Screen.height >> 1)))
        {
            CallSystemDemo();
        }

        GUILayout.EndArea();
    }
}
