using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Launcher : MonoBehaviour
{
    private void CallManaged()
    {
        SceneManager.LoadScene("Managed");
    }

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

        if (GUILayout.Button("Demo Managed", GUILayout.Height(Screen.height / 3))) {
            CallManaged();
        }

        if (GUILayout.Button("Demo C", GUILayout.Height(Screen.height / 3))) {
            CallCDemo();
        }

        if (GUILayout.Button("Demo System", GUILayout.Height(Screen.height / 3))) {
            CallSystemDemo();
        }

        GUILayout.EndArea();
    }
}
