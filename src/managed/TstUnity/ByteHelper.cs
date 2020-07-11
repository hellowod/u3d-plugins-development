using System;

namespace TstUnity
{
    public static class ByteHelper
    {
        /// <summary>
        /// 获取字符串字节编码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static byte[] String2ByteArray(string str)
        {
            return System.Text.UTF8Encoding.UTF8.GetBytes(str);
        }

        /// <summary>
        /// 将字节编码转化为UTF-8字符串
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string ByteArray2String(byte[] bytes)
        {
            return System.Text.UTF8Encoding.UTF8.GetString(bytes);
        }

        /// <summary>
        /// 将Short转换为无符号Int
        /// </summary>
        /// <returns>The short2 integer.</returns>
        /// <param name="s">S.</param>
        public static int ConvertShort2Integer(short s)
        {
            return 0x0000ffff & s;
        }

        /// <summary>
        /// 转换Short数组为Byte数组
        /// </summary>
        /// <returns>The short array2 byte array.</returns>
        /// <param name="s">S.</param>
        public static byte[] ConvertShortArray2ByteArray(short[] s)
        {
            if (s == null || s.Length <= 0) {
                return null;
            }
            byte[] ret = new byte[s.Length * 2];
            for (int i = 0; i < s.Length; i++) {
                ret[i * 4] = (byte)(s[i] >> 24);
                ret[i * 4 + 1] = (byte)(s[i] >> 16);
                ret[i * 4 + 2] = (byte)(s[i] >> 8);
                ret[i * 4 + 3] = (byte)s[i];
            }
            return ret;
        }

        /// <summary>
        /// 将Byte数组转换为Int数组
        /// </summary>
        /// <returns>The byte array2 int array.</returns>
        /// <param name="s">S.</param>
        public static int[] ConvertByteArray2IntArray(byte[] s)
        {
            if (s == null || s.Length <= 0) {
                return null;
            }
            int[] ret = new int[s.Length / 4];
            for (int i = 0; i < ret.Length; i++) {
                ret[i] = ToInt(s[i * 4], s[i * 4 + 1], s[i * 4 + 2], s[i * 4 + 3]);
            }
            return ret;
        }

        /// <summary>
        /// 将Byte数组转换成Short数组
        /// </summary>
        /// <returns>The byte array2 short array.</returns>
        /// <param name="s">S.</param>
        public static short[] ConvertByteArray2ShortArray(byte[] s)
        {
            if (s == null || s.Length <= 0) {
                return null;
            }
            short[] ret = new short[s.Length / 2];
            for (int i = 0; i < ret.Length; i++) {
                ret[i] = (short)ToInt(s[i * 2], s[i * 2 + 1]);
            }
            return ret;
        }

        /// <summary>
        /// 将2-Byte转换成Short
        /// </summary>
        /// <returns>The short.</returns>
        /// <param name="a1">A1.</param>
        /// <param name="a2">A2.</param>
        public static int ToInt(byte a1, byte a2)
        {
            return (a1 << 8) & 0x0000ff00 | a2 & 0x000000ff;
        }

        /// <summary>
        /// 将4-Byte转换成1-Int
        /// </summary>
        /// <returns>The int.</returns>
        /// <param name="a1">A1.</param>
        /// <param name="a2">A2.</param>
        /// <param name="a3">A3.</param>
        /// <param name="a4">A4.</param>
        public static int ToInt(byte a1, byte a2, byte a3, byte a4)
        {
            return (a1 << 24) | (a2 << 16) & 0x00ff0000 | (a3 << 8) & 0x0000ff00 | a4 & 0x000000ff;
        }

        /// <summary>
        /// 将十六进制字符转换成数组
        /// </summary>
        /// <returns>The hpy char2 byte.</returns>
        /// <param name="c">C.</param>
        public static byte ConvertHpyChar2Byte(char c)
        {
            if (c > 57) {
                return (byte)(c - 87);
            } else {
                return (byte)(c - 48);
            }
        }

        /// <summary>
        ///  将整数转换成十六进制字符
        /// </summary>
        /// <returns>The hyp2 char.</returns>
        /// <param name="value">Value.</param>
        public static char ConvertHyp2Char(int value)
        {
            if (value < 0 || value > 15) {
                new Exception("ConvertHyp2Char Error!");
            }
            if (value < 10) {
                return (char)(48 + value);
            } else {
                return (char)(87 + value);
            }
        }
    }
}
