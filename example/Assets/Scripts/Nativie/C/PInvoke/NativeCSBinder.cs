using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class NativeCSBinder
{
    public static void Register()
    {
        NativeCSHelper.RegFunction("NewGameObject", NewGameObject);
        NativeCSHelper.RegFunction("GetGameObject", GetGameObject);
        NativeCSHelper.RegFunction("PrintMessage", PrintMessage);
    }

    [MonoPInvokeCallback(typeof(NativeCSFunction))]
    private static void NewGameObject()
    {
        GameObject go = new GameObject("PInvoke");
    }

    [MonoPInvokeCallback(typeof(NativeCSFunction))]
    private static void GetGameObject()
    {
        GameObject go = GameObject.Find("PInvoke");
        if (go != null) {
            Debug.Log("Find PInvoke GameObject!");
        }
    }

    [MonoPInvokeCallback(typeof(NativeCSFunction))]
    private static void PrintMessage()
    {
        Debug.Log("PInvoke Print Message.");
    }
}
