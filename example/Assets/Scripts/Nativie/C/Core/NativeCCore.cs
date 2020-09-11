using System;
using System.Runtime.InteropServices;

public static class NativeCCore
{
#if UNITY_IPHONE && !UNITY_EDITOR
		private const string UNITYDLL = "__Internal";
#else
        private const string UNITYDLL = "tstunity";
#endif

    [DllImport(UNITYDLL, CallingConvention = CallingConvention.Cdecl)]
    public static extern int tst_add(int a, int b);

    [DllImport(UNITYDLL, CallingConvention = CallingConvention.Cdecl)]
    public static extern int tst_sub(int a, int b);

    [DllImport(UNITYDLL, CallingConvention = CallingConvention.Cdecl)]
    public static extern int tst_div(int a, int b);

    [DllImport(UNITYDLL, CallingConvention = CallingConvention.Cdecl)]
    public static extern int tst_mul(int a, int b);

    [DllImport(UNITYDLL, CallingConvention = CallingConvention.Cdecl)]
    public static extern void reg_func(IntPtr fn);

    [DllImport(UNITYDLL, CallingConvention = CallingConvention.Cdecl)]
    public static extern void call_func();
    
   
}
