﻿using System;
using System.ComponentModel;

namespace DaxStudio.Interfaces.Enums
{
    public enum StorageEventTimelineStyle
    {
        [Description("None")] None,
        [Description("Thin")] Thin,
        [Description("Standard")] Standard,
        [Description("Full Height")] FullHeight
    }

    public static class Extensions
    {
        public static T Next<T>(this T src) where T : struct
        {
            if (!typeof(T).IsEnum) throw new ArgumentException(String.Format("Argument {0} is not an Enum", typeof(T).FullName));

            T[] Arr = (T[])Enum.GetValues(src.GetType());
            int j = Array.IndexOf<T>(Arr, src) + 1;
            return (Arr.Length == j) ? Arr[0] : Arr[j];
        }
    }

}
