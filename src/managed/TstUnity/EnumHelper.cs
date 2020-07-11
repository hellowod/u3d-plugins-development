using System;

namespace TstUnity
{
    public static class EnumHelper
    {
        /// <summary>
        /// 枚举转换成字符串
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="enumInt"></param>
        /// <returns></returns>
        public static string EnumToString<TEnum>(this int enumInt)
        {
            string enumString = enumInt.ToString();
            if (Enum.IsDefined(typeof(TEnum), enumInt)) {
                enumString = ((TEnum)Enum.ToObject(typeof(TEnum), enumInt)).ToString();
            }
            return enumString;
        }

        /// <summary>
        /// 字符串转换成枚举
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="enumString"></param>
        /// <returns></returns>
        public static TEnum StringToEnum<TEnum>(this string enumString)
        {
            TEnum enumInt = default(TEnum);
            if (Enum.IsDefined(typeof(TEnum), enumString)) {
                enumInt = ((TEnum)Enum.ToObject(typeof(TEnum), enumString));
            }
            return enumInt;
        }
    }
}
