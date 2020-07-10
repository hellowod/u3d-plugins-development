using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class NativeCSBinder
{
    public static void Register()
    {
        NativeCSHelper.RegFunction(PrintMessage);
    }

    [MonoPInvokeCallback(typeof(NativeCSFunction))]
    private static void PrintMessage()
    {
        Debug.Log("PInvoke C Call PrintMessage Function.");
    }
}
