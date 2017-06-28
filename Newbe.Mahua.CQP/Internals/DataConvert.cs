using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Newbe.Mahua.CQP.Internals
{
    /// <summary>
    /// Base64编码解码
    /// </summary>
    internal static class DataConvertExtensions
    {
        private static readonly char[] HexChars =
            {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};

        /// <summary>
        /// Base64编码
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string Base64(this byte[] source)
        {
            return Convert.ToBase64String(source);
        }

        /// <summary>
        /// Base64解码
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static byte[] DeBase64(this string result)
        {
            return Convert.FromBase64String(result);
        }

        /// <summary>
        /// 将字节数组转换为HEX形式的字符串, 使用指定的间隔符
        /// </summary>
        /// <param name="buf"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static string ByteToHex(this byte[] buf, string separator)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < buf.Length; i++)
            {
                if (i > 0)
                {
                    sb.Append(separator);
                }
                sb.Append(HexChars[buf[i] >> 4]).Append(HexChars[buf[i] & 0x0F]);
            }
            return sb.ToString();
        }

        public static long ToLong(this byte[] bytes)
        {
            Array.Reverse(bytes);
            return BitConverter.ToInt64(bytes, 0);
        }

        public static int ToInt(this byte[] bytes)
        {
            Array.Reverse(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }

        public static short ToShort(this byte[] bytes)
        {
            Array.Reverse(bytes);
            return BitConverter.ToInt16(bytes, 0);
        }

        public static int ToByte(this byte[] bytes)
        {
            return BitConverter.ToInt32(bytes, 0);
        }

        public static byte[] ToBin(this int num)
        {
            var bytes = BitConverter.GetBytes(num);
            Array.Reverse(bytes);
            return bytes;
        }

        public static byte[] ToBin(this long num)
        {
            var bytes = BitConverter.GetBytes(num);
            Array.Reverse(bytes);
            return bytes;
        }

        public static byte[] ToBin(this short num)
        {
            var bytes = BitConverter.GetBytes(num);
            Array.Reverse(bytes);
            return bytes;
        }

        /// <summary>
        /// 从此实例检索子数组
        /// </summary>
        /// <param name="source">要检索的数组</param>
        /// <param name="startIndex">起始索引号</param>
        /// <param name="length">检索最大长度</param>
        /// <returns>与此实例中在 startIndex 处开头、长度为 length 的子数组等效的一个数组</returns>
        public static byte[] SubArray(this byte[] source, int startIndex, int length)
        {
            if (startIndex < 0 || startIndex > source.Length || length < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            var destination = startIndex + length <= source.Length
                ? source.Skip(startIndex).Take(length).ToArray()
                : source.Skip(startIndex).ToArray();

            return destination;
        }

        /// <summary>
        /// 翻转字符串
        /// </summary>
        /// <param name="str"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public static string Flip(this string str, int len)
        {
            var f = 0;
            --len;
            var sb = new StringBuilder(str);
            while (f < len)
            {
                var p = sb[len];
                sb[len] = str[f];
                sb[f] = p;
                ++f;
                --len;
            }
            return sb.ToString();
        }

        private static readonly IDictionary<Type, PropertyInfo[]> PropertiesCache =
            new Dictionary<Type, PropertyInfo[]>();

        public static string GetProperties<T>(this T t) where T : class
        {
            var tStr = string.Empty;
            if (t == null)
            {
                return tStr;
            }
            var type = t.GetType();
            if (!PropertiesCache.ContainsKey(type))
            {
                PropertiesCache[type] = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            }
            var properties = PropertiesCache[type];
            if (properties.Length <= 0)
            {
                return tStr;
            }
            var sb = new StringBuilder();
            foreach (PropertyInfo item in properties)
            {
                var name = item.Name;
                var value = item.GetValue(t, null);
                if (item.PropertyType.IsValueType || item.PropertyType.Name.StartsWith("String"))
                {
                    sb.Append($"{name}:{value},");
                }
                else
                {
                    GetProperties(value);
                }
            }
            return sb.ToString();
        }
    }
}