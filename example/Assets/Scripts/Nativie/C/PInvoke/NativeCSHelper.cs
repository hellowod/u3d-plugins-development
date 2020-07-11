using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;

public static class NativeCSHelper
{
    public static void RegFunction(NativeCSFunction ncf)
    {
        IntPtr fn = Marshal.GetFunctionPointerForDelegate(ncf);
        NativeCCore.reg_func(fn);
    }
}
