using System.Collections;
using System.Collections.Generic;
using TstUnity;
using UnityEngine;

public static class ManagedCore
{
    public static int Add(int a, int b)
    {
        return MathHelper.Add(a, b);
    }

    public static int Sub(int a, int b)
    {
        return MathHelper.Sub(a, b);
    }

    public static int Div(int a, int b)
    {
        return MathHelper.Div(a, b);
    }

    public static int Mul(int a, int b)
    {
        return MathHelper.Mul(a, b);
    }
}
