﻿using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DaxStudio.UI.Extensions
{
    public static class ContextExtensions
    {
        private static readonly string DatabaseNameKey = "DatabaseNameKey";
        private static readonly string TextKey = "TextKey";
        private static readonly string DataKey = "DataKey";
        private static readonly string TextDataFormatKey = "TextDataFormatKey";
        private static readonly string FormatKey = "FormatKey";

        public static Context WithDatabaseName(this Context context, string databaseName)
        {
            context[DatabaseNameKey] = databaseName;
            return context;
        }

        public static string GetDatabaseName(this Context context)
        {
            if (context.TryGetValue(DatabaseNameKey, out object databaseName))
            {
                return databaseName as string;
            }
            return null;
        }

        public static Context WithText(this Context context, string text)
        {
            context[TextKey] = text;
            return context;
        }

        public static Context WithData(this Context context, object data)
        {
            context[DataKey] = data;
            return context;
        }

        public static string GetText(this Context context)
        {
            if (context.TryGetValue(TextKey, out object text))
            {
                return text as string;
            }
            return null;
        }

        public static object GetData(this Context context)
        {
            if (context.TryGetValue(DataKey, out object data))
            {
                return data;
            }
            return null;
        }

        public static string GetFormat(this Context context)
        {
            if (context.TryGetValue(FormatKey, out object format))
            {
                return format as string;
            }
            return null;
        }

        public static Context WithTextDataFormat(this Context context, TextDataFormat format)
        {
            context[TextDataFormatKey] = format;
            return context;
        }

        public static Context WithFormat(this Context context, string format)
        {
            context[FormatKey] = format;
            return context;
        }

        public static TextDataFormat GetTextDataFormat(this Context context)
        {
            if (context.TryGetValue(TextKey, out object format))
            {
                return (TextDataFormat)format;
            }
            return TextDataFormat.Text;
        }
    }
}
