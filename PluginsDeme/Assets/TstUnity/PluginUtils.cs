using System.Runtime.InteropServices;

/***
 * PluginUtils.cs
 * 
 * @author abaojin
 */
public static class PluginUtils
{
#if UNITY_IPHONE && !UNITY_EDITOR
		private const string UNITYDLL = "__Internal";
#else
        private const string UNITYDLL = "tstunity";
#endif

    [DllImport(UNITYDLL)]
    public static extern int add(int a, int b);

    [DllImport(UNITYDLL)]
    public static extern int sub(int a, int b);

    [DllImport(UNITYDLL)]
    public static extern int div(int a, int b);

    [DllImport(UNITYDLL)]
    public static extern int mul(int a, int b);
}
