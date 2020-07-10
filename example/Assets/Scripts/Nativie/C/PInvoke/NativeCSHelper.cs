using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

public static class NativeCSHelper
{
    public static void RegFunction(string name, NativeCSFunction ncf)
    {
        IntPtr fn = Marshal.GetFunctionPointerForDelegate(ncf);
        NativeCCore.reg_func(name, fn);
    }
}
