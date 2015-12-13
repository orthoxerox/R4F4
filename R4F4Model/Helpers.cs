using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace R4F4.Model
{
    public static class Helpers
    {
        public static string GetDescription(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes =
                  (DescriptionAttribute[])fi.GetCustomAttributes(
                  typeof(DescriptionAttribute), false);
            return attributes?[0].Description ?? value.ToString();
        }

        public static string Concatenate(this IEnumerable<string> source)
        {
            var sb = new StringBuilder();
            foreach (var item in source) {
                sb.Append(item);
                sb.Append(",");
            }
            return sb.Remove(sb.Length - 1, 1).ToString();
        }


        public static T GetC<T>(this T[] array, int index)
            where T : class
        {
            if (array ==null 
                || index >= array.Length 
                || index < 0) {
                return null;
            }
            return array[index];
        }

        public static char? GetS(this string array, int index)
        {
            if (array == null
                || index >= array.Length
                || index < 0) {
                return null;
            }
            return array[index];
        }
    }
}
